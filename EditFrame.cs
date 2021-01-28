using System;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Accesser
{
    public partial class EditFrame : Form
    {
        public EditFrame()
        {
            InitializeComponent();
        }

        public EditFrame(MainFrame frame)
        {
            InitializeComponent();
        }


        private void EditFrame_Shown(object sender, EventArgs e)
        {
            populateCombo();
        }

        private void EditFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void getChangedBtn_Click(object sender, EventArgs e)
        {
            StringCollection paths = new StringCollection();
            paths.Add(pictureBox.ImageLocation);
            Clipboard.SetFileDropList(paths);
        }


        private void saveSetBtn_Click(object sender, EventArgs e)
        {
            if (!settingsCombo.Items.Contains(settingsCombo.Text))
            {
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);

                JsonWriter writer = new JsonTextWriter(sw);

                writer.Formatting = Formatting.Indented;
                writer.WritePropertyName(settingsCombo.Text);
                writer.WriteStartObject();
                writer.WritePropertyName("Width");
                writer.WriteValue(fileWidthBox.Value.ToString());
                writer.WritePropertyName("Height");
                writer.WriteValue(fileHeightBox.Value.ToString());
                writer.WriteEndObject();


                string holder = API.configJson["Settings"].ToString();
                holder = holder.Remove(holder.Length - 1, 1);
                holder = holder + "," + sb + "}";
                API.configJson["Settings"] = JToken.Parse(holder);
                File.WriteAllText(AppContext.BaseDirectory + "\\config.json", API.configJson.ToString());
                populateCombo();
            }
        }

        private void loadSetBtn_Click(object sender, EventArgs e)
        {
            if (settingsCombo.Items.Contains(settingsCombo.SelectedItem))
            {
                fileWidthBox.Value = (int) API.configJson["Settings"][settingsCombo.SelectedItem.ToString()]["Width"];
                fileHeightBox.Value = (int) API.configJson["Settings"][settingsCombo.SelectedItem.ToString()]["Height"];
            }
        }

        private void populateCombo()
        {
            string holder = API.configJson["Settings"].ToString();
            holder = holder.Remove(holder.Length - 1, 1);
            JsonTextReader reader = new JsonTextReader(new StringReader(holder));
            int i = 0;
            settingsCombo.Items.Clear();
            while (reader.Read())
                if (reader.Value != null)
                {
                    if (i == 0) settingsCombo.Items.Add(reader.Value);

                    i = (i + 1) % 5;
                }

            reader.Close();
            settingsCombo.Refresh();
        }

        private void delSettingBtn_Click(object sender, EventArgs e)
        {
            if (settingsCombo.Items.Contains(settingsCombo.Text))
                if (File.Exists(AppContext.BaseDirectory + "\\config.json"))
                {
                    JsonTextReader reader =
                        new JsonTextReader(File.OpenText(AppContext.BaseDirectory + "\\config.json"));
                    API.configJson = (JObject) JToken.ReadFrom(reader);
                    string toDelete = API.configJson["Settings"][settingsCombo.Text].ToString();
                    string json = API.configJson.ToString();
                    int index = json.IndexOf(settingsCombo.Text);
                    Console.WriteLine(toDelete.Length);
                    string cleanPat = json.Remove(index - 1, toDelete.Length + 31);
                    reader.Close();
                    File.WriteAllText(AppContext.BaseDirectory + "\\config.json",
                        cleanPat);
                    reader = new JsonTextReader(File.OpenText(AppContext.BaseDirectory + "\\config.json"));
                    API.configJson = (JObject) JToken.ReadFrom(reader);
                    reader.Close();
                    populateCombo();
                }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}