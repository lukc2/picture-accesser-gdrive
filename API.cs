using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using ImageMagick;
using MimeTypes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using File = Google.Apis.Drive.v3.Data.File;

namespace Accesser
{
    public class API
    {
        private static readonly string[] Scopes = {DriveService.Scope.Drive};
        private static readonly string ApplicationName = "Picture Accessor";
        public static string img_dir = "";
        public static string img_dir_id = "";
        public static string img_dir_old = "emotes";
        public static string img_dir_old_id = "";
        public static JObject configJson;

        public static DriveService login(MainFrame frame)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Drive API service.
            DriveService service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });


            frame.Invoke(frame.loggedDelegate);
            return service;
        }
    }

    public class Loader
    {
        public static bool check(MainFrame frame, DriveService service)
        {
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            string query = "mimeType='application/vnd.google-apps.folder' and trashed=false and name='" + API.img_dir +
                           "'";
            listRequest.Q = query;
            listRequest.Fields = "nextPageToken, files(id, name, contentHints)";
            listRequest.PageToken = null;
            File folder = null;
            // List files.
            try
            {
                folder = listRequest.Execute().Files[0];
            }
            catch
            {
                if (MessageBox.Show(
                    "There is no folder " + API.img_dir + " on your drive. Should I make one to continue? ", "Warning!",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    frame.logOutToolStripMenuItem_Click(frame, null);
                    MessageBox.Show("You have been logged out!", "Well...", MessageBoxButtons.OK);
                    return false;
                }

                File newFolder = new File();
                newFolder.Name = API.img_dir;
                newFolder.MimeType = "application/vnd.google-apps.folder";
                File adding = service.Files.Create(newFolder).Execute();

                folder = listRequest.Execute().Files[0];
            }

            Console.WriteLine("Got access to: {0} ({1})", folder.Name, folder.Id);
            API.img_dir_id = folder.Id;
            return true;
        }

        public static void list(MainFrame frame, DriveService service, string search = null)
        {
            frame.selected = -1;
            ProgressForm f = new ProgressForm();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(
                frame.DesktopLocation.X + (frame.Width - f.Width) / 2,
                frame.DesktopLocation.Y + (frame.Width - f.Width) / 2);
            int progress = 0;
            f.Show();
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 1000;
            string query = "trashed=false and '" + API.img_dir_id + "' in parents";
            if (search != null) query += " and fullText contains '" + search + "'";

            listRequest.Q = query;
            listRequest.Fields =
                "nextPageToken, files(id, name, imageMediaMetadata ,fileExtension, parents, thumbnailLink, size, webContentLink)";
            listRequest.PageToken = null;
            IList<File> folder = null;
            // List files.
            try
            {
                frame.fileList.Items.Clear();
                folder = listRequest.Execute().Files;
                if (folder.Count > 0)
                {
                    f.progressBar.Maximum = folder.Count;
                    ActionProgress(f, progress);
                    frame.files = folder;
                    frame.filesLoaded = new List<File>();
                    ;
                    frame.images = new ImageList();
                    int count = 0;
                    foreach (var file in folder)
                    {
                        ActionProgress(f, progress++);
                        if (file.ThumbnailLink != null)
                        {
                            WebClient client = new WebClient();
                            Stream stream = client.OpenRead(file.ThumbnailLink);
                            Bitmap bitmap = new Bitmap(stream);
                            frame.images.Images.Add(bitmap);
                            stream.Flush();
                            stream.Close();
                            client.Dispose();
                            ListViewItem listItem = new ListViewItem(folder[count].Name);
                            frame.fileList.Items.Add(listItem);
                            frame.fileList.Items[count].ImageIndex = count;
                            frame.filesLoaded.Add(file);
                            count++;
                        }
                    }

                    frame.images.ImageSize = new Size(80, 80);
                    frame.fileList.SmallImageList = frame.images;
                    frame.fileList.LargeImageList = frame.images;
                    frame.fileList.Items[0].Focused = true;
                    frame.fileList_ItemActivate(frame, null);
                }
            }
            catch
            {
                MessageBox.Show("Request error", "Error", MessageBoxButtons.OK);
            }

            ActionProgress(f, progress++);
            f.Close();
        }


        public static File getFile(MainFrame frame, DriveService service, File file, File folder)
        {
            FilesResource.ListRequest checkRequest = service.Files.List();
            checkRequest.PageSize = 1000;
            var query = "trashed=false and '" + folder.Id + "' in parents and name = '" + file.Name + "'";
            checkRequest.Q = query;
            checkRequest.Fields =
                "nextPageToken, files(id, name, imageMediaMetadata ,fileExtension, parents, thumbnailLink, size, webContentLink)";
            checkRequest.PageToken = null;
            IList<File> files = checkRequest.Execute().Files;
            if (files.Count > 0)
                return files[0];
            return null;
        }

        public static void updateName(MainFrame frame, DriveService service, File file)
        {
            try
            {
                FilesResource.UpdateRequest request;
                File f = new File();
                if (Path.HasExtension(frame.nameText.Text))
                    f.Name = frame.nameText.Text;
                else
                    f.Name = frame.nameText.Text + file.FileExtension;


                // Rename the file.
                request = new FilesResource.UpdateRequest(service, f, file.Id);
                request.Execute();
            }
            catch (Exception e)
            {
                MessageBox.Show("Action failed!", "Error!", MessageBoxButtons.OK);
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }


        public static string downloadFile(MainFrame frame, DriveService service, File file)
        {
            string path = AppContext.BaseDirectory + "temp\\";
            Directory.CreateDirectory(path);
            path += file.Name;
            var getRequest = service.Files.Get(file.Id);
            using (var fileStream = new FileStream(
                path,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite))
            {
                getRequest.MediaDownloader.ProgressChanged += delegate(IDownloadProgress progress)
                {
                    ProgressForm f = new ProgressForm();
                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(
                        frame.DesktopLocation.X + (frame.Width - f.Width) / 2,
                        frame.DesktopLocation.Y + (frame.Width - f.Width) / 2);
                    f.progressBar.Maximum = int.Parse(file.Size.ToString());
                    f.Show();
                    DownloadProgress(progress, f);
                };
                getRequest.Download(fileStream);
                return path;
            }
        }

        public static File uploadFile(MainFrame frame, DriveService service, File file, string path = null)
        {
            if (path == null)
            {
                path = AppContext.BaseDirectory + "temp\\";
                path += file.Name;
            }

            Console.WriteLine(MimeTypeMap.GetMimeType(Path.GetExtension(path)));
            File body = new File();
            body.Name = Path.GetFileName(path);
            body.MimeType = MimeTypeMap.GetMimeType(Path.GetExtension(path));
            body.Parents = new List<string>();
            body.Parents.Add(API.img_dir_id);
            byte[] byteArray = System.IO.File.ReadAllBytes(path);
            MemoryStream stream = new MemoryStream(byteArray);
            try
            {
                FilesResource.CreateMediaUpload request = service.Files.Create(body, stream, body.MimeType);
                request.Upload();
                body = request.ResponseBody;
            }
            catch (Exception e)
            {
                MessageBox.Show("Action failed!", "Error!", MessageBoxButtons.OK);
                Console.WriteLine("An error occurred: " + e.Message);
            }

            return body;
        }


        private static void DownloadProgress(IDownloadProgress progress, ProgressForm f)
        {
            f.progressBar.Step = int.Parse(progress.BytesDownloaded.ToString()) - f.progressBar.Value;
            f.progressBar.PerformStep();
            f.progressBar.Refresh();
            f.progressLabel.Text = progress.BytesDownloaded + "/" + f.progressBar.Maximum;
            f.progressLabel.Refresh();
            Console.WriteLine(progress.Status + " " + progress.BytesDownloaded);
            if (progress.Status == DownloadStatus.Completed)
            {
                f.progressBar.Value = f.progressBar.Maximum;
                f.progressBar.Refresh();
                f.progressLabel.Text = "" + f.progressBar.Maximum + "/" + f.progressBar.Maximum;
                f.progressLabel.Refresh();
                f.Close();
            }
        }

        public static void moveFiles(MainFrame frame, DriveService service)
        {
            try
            {
                FilesResource.UpdateRequest request;
                foreach (File item in frame.filesLoaded)
                {
                    request = service.Files.Update(new File(), item.Id);
                    request.AddParents = API.img_dir_id;
                    request.RemoveParents = item.Parents[0];
                    request.Execute();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Action failed!", "Error!", MessageBoxButtons.OK);
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        public static void deleteFile(MainFrame frame, DriveService service, File file)
        {
            try
            {
                FilesResource.DeleteRequest request;
                request = service.Files.Delete(file.Id);
                request.Execute();
            }
            catch (Exception e)
            {
                MessageBox.Show("Action failed!", "Error!", MessageBoxButtons.OK);
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        public static void backupFile(MainFrame frame, DriveService service, File file)
        {
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 1;
            string query = "mimeType='application/vnd.google-apps.folder' and trashed=false and name='AccesserBackup'";
            listRequest.Q = query;
            listRequest.Fields = "nextPageToken, files(id, name, contentHints)";
            listRequest.PageToken = null;
            File folder = null;

            try
            {
                folder = listRequest.Execute().Files[0];
            }
            catch
            {
                File newFolder = new File();
                newFolder.Name = "AccesserBackup";
                newFolder.MimeType = "application/vnd.google-apps.folder";
                File adding = service.Files.Create(newFolder).Execute();

                folder = listRequest.Execute().Files[0];
            }

            try
            {
                File existing = getFile(frame, service, file, folder);

                if (existing != null) deleteFile(frame, service, existing);

                ;
                FilesResource.CopyRequest request;
                File f = new File();
                f.Name = file.Name;
                request = service.Files.Copy(f, file.Id);
                request.Fields = "id, name, parents";
                existing = request.Execute();
                FilesResource.UpdateRequest moveRequest;
                moveRequest = service.Files.Update(new File(), existing.Id);
                moveRequest.AddParents = folder.Id;
                moveRequest.RemoveParents = existing.Parents[0];
                moveRequest.Execute();
            }
            catch (Exception e)
            {
                MessageBox.Show("Action failed!", "Error!", MessageBoxButtons.OK);
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        public static string resizeImg(MainFrame frame, DriveService service, File file)
        {
            string path = downloadFile(frame, service, file);
            ProgressForm f = new ProgressForm();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(
                frame.DesktopLocation.X + (frame.Width - f.Width) / 2,
                frame.DesktopLocation.Y + (frame.Width - f.Width) / 2);
            int progress = 0;
            f.Location = frame.DesktopLocation;
            f.Show();
            int height = int.Parse(frame.editor.fileHeightBox.Text);
            int width = int.Parse(frame.editor.fileWidthBox.Text);
            MagickGeometry size = new MagickGeometry(width, height);
            size.IgnoreAspectRatio = true;

            using (var collection = new MagickImageCollection(new FileInfo(path)))
            {
                f.progressBar.Maximum = collection.Count;
                ActionProgress(f, progress);
                collection.Coalesce();
                foreach (var image in collection)
                {
                    image.Resize(size);
                    ActionProgress(f, progress++);
                }

                collection.Write(path);
            }

            ActionProgress(f, progress++);
            f.Close();
            return path;
        }

        public static void ActionProgress(ProgressForm f, int value)
        {
            f.progressLabel.Text = "" + value + "\\" + f.progressBar.Maximum;
            f.progressBar.PerformStep();
            f.progressBar.Refresh();
            f.progressLabel.Refresh();
        }
    }
}