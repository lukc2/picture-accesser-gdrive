using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Drive.v3;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using File = Google.Apis.Drive.v3.Data.File;

namespace Accesser
{
    public partial class MainFrame : Form
    {
        public delegate void loginSet();

        public static DriveService drive;
        public static bool logged;
        public EditFrame editor;
        public IList<File> files;
        public IList<File> filesLoaded = null;
        public ImageList images = null;

        public loginSet loggedDelegate;
        private ProgressForm progressWindow = new ProgressForm();
        public int selected = -1;
        private Thread t;
        private bool tray;

        public MainFrame()
        {
            loggedDelegate = setLoggedIn;
            editor = new EditFrame(this);
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!logged)
                try
                {
                    t = new Thread(() => drive = API.login(this))
                    {
                        IsBackground = false
                    };
                    t.Start();
                }
                catch
                {
                    MessageBox.Show("Login failed!");
                }
            else
                setLoggedOut();
        }

        public void setLoggedIn()
        {
            loginBtn.Text = "Log out";
            logged = true;
        }

        public void setLoggedOut()
        {
            if (logged)
            {
                Directory.Delete("token.json", true);
                logged = false;
                fileList.Clear();
                loginBtn.Text = "Log in";
                MessageBox.Show("You have been logged out!", "Hey!", MessageBoxButtons.OK);
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(AppContext.BaseDirectory + "\\config.json"))
            {
                try
                {
                    JsonTextReader reader =
                        new JsonTextReader(System.IO.File.OpenText(AppContext.BaseDirectory + "\\config.json"));
                    API.configJson = (JObject) JToken.ReadFrom(reader);
                    API.img_dir = API.configJson["Config"]["Main"].ToString();
                    API.img_dir_old = API.configJson["Config"]["Main"].ToString();
                    onCloseBtn.Checked = bool.Parse(API.configJson["Config"]["Tray"].ToString());
                    reader.Close();
                }
                catch
                {
                    System.IO.File.WriteAllText(AppContext.BaseDirectory + "\\config.json",
                        "{\r\n  \"Settings\": {\r\n  },\r\n  \"Config\": {\r\n    \"Main\": \"" + API.img_dir_old +
                        "\",\r\n    \"Backup\": \"AccesserBackup,\r\n    \"Tray\":  \"false\"\r\n  }\r\n}");
                    JsonTextReader reader =
                        new JsonTextReader(System.IO.File.OpenText(AppContext.BaseDirectory + "\\config.json"));
                    API.configJson = (JObject) JToken.ReadFrom(reader);
                    API.img_dir = API.img_dir_old;
                    reader.Close();
                }
            }
            else
            {
                System.IO.File.WriteAllText(AppContext.BaseDirectory + "\\config.json",
                    "{\r\n  \"Settings\": {\r\n  },\r\n  \"Config\": {\r\n    \"Main\": \"" + API.img_dir_old +
                    "\",\r\n    \"Backup\": \"AccesserBackup,\r\n    \"Tray\":  \"false\"\r\n  }\r\n}");
                JsonTextReader reader =
                    new JsonTextReader(System.IO.File.OpenText(AppContext.BaseDirectory + "\\config.json"));
                API.configJson = (JObject) JToken.ReadFrom(reader);
                API.img_dir = API.img_dir_old;
                reader.Close();
            }

            onCloseBtn.Checked = bool.Parse(API.configJson["Config"]["Tray"].ToString());
            folderBtn.Text = API.img_dir;

            if (Directory.Exists("token.json")) drive = API.login(this);
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists("token.json")) Directory.Delete("token.json", true);

                t = new Thread(() => drive = API.login(this))
                {
                    IsBackground = false
                };
                t.Start();
            }
            catch
            {
                MessageBox.Show("Login failed!");
            }
        }

        public void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLoggedOut();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                fileList.Items.Clear();
                Loader.check(this, drive);
                Loader.list(this, drive);
            }
            else
            {
                if (MessageBox.Show("You have to log in first!\n\nWould you like to do it now?", "Hey!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    loginBtn.PerformClick();
            }
        }


        public void fileList_ItemActivate(object sender, EventArgs e)
        {
            selected = fileList.FocusedItem.Index;
            if (selected >= 0)
                if (filesLoaded.Count > 0)
                {
                    nameText.Text = filesLoaded[selected].Name;
                    thumbLinkBox.Text = filesLoaded[selected].ThumbnailLink;
                    fileLinkBox.Text = filesLoaded[selected].WebContentLink;
                    editor.fileWidthBox.Text = filesLoaded[selected].ImageMediaMetadata.Width.ToString();
                    editor.fileHeightBox.Text = filesLoaded[selected].ImageMediaMetadata.Height.ToString();
                }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0)
            {
                bool changes = false;
                string edited;
                string name = filesLoaded[selected].Name;
                if (nameText.Text != filesLoaded[selected].Name)
                {
                    name = nameText.Text;
                    Loader.updateName(this, drive, filesLoaded[selected]);
                    changes = true;
                }

                if (editor.fileWidthBox.Value == 0 && editor.fileHeightBox.Value == 0)
                {
                    editor.fileWidthBox.Value = filesLoaded[selected].ImageMediaMetadata.Width.Value;
                    editor.fileHeightBox.Value = filesLoaded[selected].ImageMediaMetadata.Height.Value;
                }
                else if (editor.fileWidthBox.Value == 0)
                {
                    editor.fileWidthBox.Value = filesLoaded[selected].ImageMediaMetadata.Width.Value *
                                                editor.fileHeightBox.Value /
                                                filesLoaded[selected].ImageMediaMetadata.Height.Value;
                }
                else if (editor.fileHeightBox.Value == 0)
                {
                    editor.fileHeightBox.Value = filesLoaded[selected].ImageMediaMetadata.Height.Value *
                                                 editor.fileWidthBox.Value /
                                                 filesLoaded[selected].ImageMediaMetadata.Width.Value;
                }

                if (editor.fileHeightBox.Value != filesLoaded[selected].ImageMediaMetadata.Height.Value ||
                    editor.fileWidthBox.Value != filesLoaded[selected].ImageMediaMetadata.Width.Value)
                {
                    editor.Hide();
                    File f = new File();
                    f.Name = name;
                    f.Id = API.img_dir_id;
                    f = Loader.getFile(this, drive, f, f);
                    edited = Loader.resizeImg(this, drive, f);
                    Loader.deleteFile(this, drive, f);
                    Loader.uploadFile(this, drive, f, edited);
                    changes = true;
                }

                if (changes) loadBtn_Click(sender, e);
            }
        }

        private void copyFileBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0)
            {
                StringCollection paths = new StringCollection();
                paths.Add(Loader.downloadFile(this, drive, filesLoaded[selected]));
                Clipboard.SetFileDropList(paths);
            }
        }

        private void copyThumbBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0) Clipboard.SetImage(images.Images[selected]);
        }

        private void thumbLinkBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0) Clipboard.SetText(thumbLinkBox.Text);
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onCloseBtn.Checked && !tray)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (Directory.Exists(AppContext.BaseDirectory + "temp"))
                    Directory.Delete(AppContext.BaseDirectory + "temp", true);
                barIcon.Visible = false;
                editor.Close();
            }
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            string output = ShowDialog("Change folder name:", "Change Folder");
            if (output != null && output != API.img_dir)
            {
                API.img_dir_old_id = API.img_dir_id;
                API.img_dir_old = API.img_dir;
                API.img_dir = output;
                API.configJson["Config"]["Main"] = output;
                System.IO.File.WriteAllText(AppContext.BaseDirectory + "\\config.json", API.configJson.ToString());
                if (filesLoaded != null)
                {
                    loadBtn_Click(sender, e);
                    if (MessageBox.Show("Do you want to move your files to new folder?", "Warning!",
                            MessageBoxButtons.YesNo)
                        == DialogResult.Yes)
                    {
                        Loader.moveFiles(this, drive);
                        loadBtn_Click(sender, e);
                    }
                }

                folderBtn.Text = API.img_dir;
            }
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Width = 400;
            prompt.Height = 200;
            prompt.Text = caption;
            Label textLabel = new Label {Left = 50, Top = 20};
            textLabel.Text = text;
            TextBox inputBox = new TextBox {Left = 50, Top = 50, Width = 300};
            Button confirmation = new Button {Text = "Save", Width = 100, Top = 100, Left = 140};
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            inputBox.Text = API.img_dir;
            prompt.ShowDialog();
            return inputBox.Text;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0)
            {
                Loader.deleteFile(this, drive, filesLoaded[selected]);
                Loader.list(this, drive);
            }
        }

        private void removeTempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(AppContext.BaseDirectory + "temp"))
                Directory.Delete(AppContext.BaseDirectory + "temp", true);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0)
            {
                editor.pictureBox.ImageLocation = Loader.downloadFile(this, drive, filesLoaded[selected]);
                editor.Show();
                editor.Focus();
            }
        }

        private void fileLinkBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0) Clipboard.SetText(fileLinkBox.Text);
        }

        private void copyEditedThBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0)
            {
                if (editor.fileWidthBox.Value == 0 && editor.fileHeightBox.Value == 0)
                {
                    editor.fileWidthBox.Value = filesLoaded[selected].ImageMediaMetadata.Width.Value;
                    editor.fileHeightBox.Value = filesLoaded[selected].ImageMediaMetadata.Height.Value;
                }
                else if (editor.fileWidthBox.Value == 0)
                {
                    editor.fileWidthBox.Value = filesLoaded[selected].ImageMediaMetadata.Width.Value *
                                                editor.fileHeightBox.Value /
                                                filesLoaded[selected].ImageMediaMetadata.Height.Value;
                }
                else if (editor.fileHeightBox.Value == 0)
                {
                    editor.fileHeightBox.Value = filesLoaded[selected].ImageMediaMetadata.Height.Value *
                                                 editor.fileWidthBox.Value /
                                                 filesLoaded[selected].ImageMediaMetadata.Width.Value;
                }

                if (nameText.Text != filesLoaded[selected].Name)
                    if (!Path.HasExtension(nameText.Text))
                        nameText.Text = nameText.Text + filesLoaded[selected].FileExtension;

                Image resized = new Bitmap(images.Images[selected],
                    new Size((int) editor.fileWidthBox.Value, (int) editor.fileHeightBox.Value));
                Clipboard.SetImage(resized);
            }
        }

        private void copyEditedBtn_Click(object sender, EventArgs e)
        {
            if (selected >= 0)
            {
                string edited = null;
                if (editor.fileWidthBox.Value == 0 && editor.fileHeightBox.Value == 0)
                {
                    editor.fileWidthBox.Value = filesLoaded[selected].ImageMediaMetadata.Width.Value;
                    editor.fileHeightBox.Value = filesLoaded[selected].ImageMediaMetadata.Height.Value;
                }
                else if (editor.fileWidthBox.Value == 0)
                {
                    editor.fileWidthBox.Value = filesLoaded[selected].ImageMediaMetadata.Width.Value *
                                                editor.fileHeightBox.Value /
                                                filesLoaded[selected].ImageMediaMetadata.Height.Value;
                }
                else if (editor.fileHeightBox.Value == 0)
                {
                    editor.fileHeightBox.Value = filesLoaded[selected].ImageMediaMetadata.Height.Value *
                                                 editor.fileWidthBox.Value /
                                                 filesLoaded[selected].ImageMediaMetadata.Width.Value;
                }

                if (editor.fileHeightBox.Value != filesLoaded[selected].ImageMediaMetadata.Height.Value ||
                    editor.fileWidthBox.Value != filesLoaded[selected].ImageMediaMetadata.Width.Value)
                {
                    edited = Loader.resizeImg(this, drive, filesLoaded[selected]);
                    Loader.uploadFile(this, drive, filesLoaded[selected], edited);
                }
                else
                {
                    edited = Loader.downloadFile(this, drive, filesLoaded[selected]);
                }

                if (nameText.Text != filesLoaded[selected].Name)
                {
                    if (!Path.HasExtension(nameText.Text))
                        nameText.Text = nameText.Text + filesLoaded[selected].FileExtension;

                    System.IO.File.Move(edited, Path.GetDirectoryName(edited) + "\\" + nameText.Text);
                }


                StringCollection paths = new StringCollection();
                paths.Add(edited);
                Clipboard.SetFileDropList(paths);
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (logged)
                try
                {
                    File file = new File();
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG,*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";
                    dialog.FilterIndex = 1;
                    dialog.Multiselect = true;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        int progress = 0;
                        ProgressForm f = new ProgressForm();
                        f.progressBar.Maximum = dialog.FileNames.Length;
                        f.Show();
                        foreach (string item in dialog.FileNames)
                        {
                            Loader.uploadFile(this, drive, new File(), item);
                            Loader.ActionProgress(f, progress++);
                        }

                        Loader.ActionProgress(f, progress++);
                        f.Close();
                        Loader.list(this, drive);
                    }
                }
                catch
                {
                }
        }

        private void uploadDragDrop(object sender, DragEventArgs e)
        {
            if (logged)
                try
                {
                    string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
                    int progress = 0;
                    ProgressForm f = new ProgressForm();
                    f.progressBar.Maximum = files.Length;
                    f.Show();
                    foreach (string item in files)
                    {
                        Loader.uploadFile(this, drive, new File(), item);
                        Loader.ActionProgress(f, progress++);
                    }

                    Loader.ActionProgress(f, progress++);
                    f.Close();
                    Loader.list(this, drive);
                }
                catch
                {
                }
        }

        private void uploadDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                fileList.Items.Clear();
                Loader.check(this, drive);
                Loader.list(this, drive, searchBox.Text);
            }
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (logged)
                if (e.KeyChar == (char) Keys.Enter)
                {
                    fileList.Items.Clear();
                    Loader.check(this, drive);
                    Loader.list(this, drive, searchBox.Text);
                }
        }

        private void MainFrame_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                barIcon.ShowBalloonTip(1000);
                Hide();
            }
        }

        private void barIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }


        private void exitBar_Click(object sender, EventArgs e)
        {
            tray = true;
            Close();
        }

        private void barIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0) barIcon_DoubleClick(this, null);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel1;
            Label label1;
            Label label2;

            Form prompt = new Form();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
                GraphicsUnit.Point, 238);
            linkLabel1.Location = new Point(86, 89);
            linkLabel1.Size = new Size(176, 20);
            linkLabel1.Text = "https://github.com/lukc2";
            linkLabel1.Links.Add(0, 24, "https://github.com/lukc2");
            linkLabel1.LinkClicked += link_Clicked;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold,
                GraphicsUnit.Point, 238);
            label1.Location = new Point(85, 19);
            label1.Size = new Size(190, 25);
            label1.Text = "Picture Accessor";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
                GraphicsUnit.Point, 238);
            label2.Location = new Point(64, 55);
            label2.Size = new Size(246, 20);
            label2.Text = "Small uni project by Łukasz Ćwiek";

            prompt.MaximumSize = new Size(377, 174);
            prompt.MinimumSize = new Size(377, 174);
            prompt.Controls.Add(label2);
            prompt.Controls.Add(label1);
            prompt.Controls.Add(linkLabel1);
            prompt.Text = "About";
            prompt.Icon = Icon;
            prompt.Show();
        }

        private void link_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/lukc2");
        }

        private void onCloseMenu_Click(object sender, EventArgs e)
        {
            API.configJson["Config"]["Tray"] = onCloseBtn.Checked.ToString();
            System.IO.File.WriteAllText(AppContext.BaseDirectory + "\\config.json", API.configJson.ToString());
        }
    }
}