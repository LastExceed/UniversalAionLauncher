using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UniversalAionLauncher {
    public partial class Form1 : Form {
        string currentDir = Directory.GetCurrentDirectory();
        bool busy = false;
        string cmd;
        const string savefile = "UAL_profiles.json";
        List<Profile> profiles = new List<Profile>();

        public Form1() {
            InitializeComponent();
            if (File.Exists(savefile)) {
                profiles = JsonConvert.DeserializeObject<List<Profile>>(File.ReadAllText(savefile));
            }
            foreach (Profile profile in profiles) {
                listBoxProfile.Items.Add(profile.name);
            }
        }
        private void SaveToFile() {
            File.WriteAllText(savefile, JsonConvert.SerializeObject(profiles));
        }

        private void ButtonProfileNew_Click(object sender, EventArgs e) {
            listBoxProfile.Items.Add("#");
            profiles.Add(new Profile());
            listBoxProfile.SelectedIndex = listBoxProfile.Items.Count - 1;
            ProfileUpdated();
        }
        private void ButtonProfileRemove_Click(object sender, EventArgs e) {
            profiles.RemoveAt(listBoxProfile.SelectedIndex);
            listBoxProfile.Items.RemoveAt(listBoxProfile.SelectedIndex);
            ProfileUpdated();
        }
        private void TextBoxProfile_TextChanged(object sender, EventArgs e) {
            if (!busy) {
                listBoxProfile.Items[listBoxProfile.SelectedIndex] = textBoxProfile.Text;
                profiles[listBoxProfile.SelectedIndex].name = listBoxProfile.Text;
            }
        }
        private void ListBoxProfile_Click(object sender, EventArgs e) {
            ProfileUpdated();
        }
        private void ProfileUpdated() {
            busy = true;
            listBoxVersion.Items.Clear();
            if (listBoxProfile.SelectedIndex == -1) {
                buttonServerRemove.Enabled = false;
                textBoxProfile.Enabled = false;
                textBoxProfile.Text = string.Empty;
                textBoxIP.Text = string.Empty;

                groupBoxClient.Enabled = false;
            } else {
                buttonServerRemove.Enabled = true;
                textBoxProfile.Enabled = true;
                textBoxProfile.Text = listBoxProfile.Text;
                profiles[listBoxProfile.SelectedIndex].name = listBoxProfile.Text;
                textBoxIP.Text = profiles[listBoxProfile.SelectedIndex].ip;
                numericUpDownCC.Value = profiles[listBoxProfile.SelectedIndex].cc;

                groupBoxClient.Enabled = true;
                foreach (var directory in Directory.GetDirectories(currentDir)) {
                    listBoxVersion.Items.Add(directory.Substring(currentDir.Length + 1));
                }
                listBoxVersion.Text = profiles[listBoxProfile.SelectedIndex].version;
                VersionUpdated();
            }
            Invoke(new Action(StatusReset));
            SaveToFile();
            busy = false;
        }

        private void ListBoxVersion_SelectedIndexChanged(object sender, EventArgs e) {
            VersionUpdated();
            profiles[listBoxProfile.SelectedIndex].version = listBoxVersion.Text;
        }
        private void VersionUpdated() {
            listBoxLanguage.Items.Clear();
            groupBoxLaunchParams.Enabled = false;
            if (listBoxVersion.SelectedIndex != -1) {
                string parentDir = currentDir + @"\" + listBoxVersion.Items[listBoxVersion.SelectedIndex].ToString() + @"\l10n";
                foreach (var directory in Directory.GetDirectories(parentDir)) {
                    listBoxLanguage.Items.Add(directory.Substring(parentDir.Length + 1));
                }
            }
            listBoxLanguage.Enabled = true;
            listBoxLanguage.Text = profiles[listBoxProfile.SelectedIndex].language;
        }
        private void ListBoxLanguage_SelectedIndexChanged(object sender, EventArgs e) {
            profiles[listBoxProfile.SelectedIndex].language = listBoxLanguage.Text;
            groupBoxLaunchParams.Enabled = (listBoxLanguage.SelectedIndex != -1);
        }
        private void TextBoxIP_TextChanged(object sender, EventArgs e) {
            profiles[listBoxProfile.SelectedIndex].ip = textBoxIP.Text;
            Invoke(new Action(StatusReset));
        }
        private void NumericUpDownPort_ValueChanged(object sender, EventArgs e) {
            profiles[listBoxProfile.SelectedIndex].port = (ushort)numericUpDownPort.Value;
            Invoke(new Action(StatusReset));
        }
        private void NumericUpDownCC_ValueChanged(object sender, EventArgs e) {
            profiles[listBoxProfile.SelectedIndex].cc = (byte)numericUpDownCC.Value;
        }

        private void ButtonParamAdd_Click(object sender, EventArgs e) {
            checkedListBoxParams.Items.Add(string.Empty);
            textBoxParam.Text = string.Empty;
            //profiles.Add(new Profile());
            checkedListBoxParams.SelectedIndex = checkedListBoxParams.Items.Count - 1;
        }
        private void ButtonParamRemove_Click(object sender, EventArgs e) {
            checkedListBoxParams.Items.RemoveAt(checkedListBoxParams.SelectedIndex);
        }
        private void CheckedListBoxParams_SelectedIndexChanged(object sender, EventArgs e) {
            busy = true;
            if (checkedListBoxParams.SelectedIndex == -1) {
                textBoxParam.Text = string.Empty;
                textBoxParam.Enabled = false;
                buttonParamRemove.Enabled = false;
            } else {
                textBoxParam.Text = checkedListBoxParams.Text;
                textBoxParam.Enabled = true;
                buttonParamRemove.Enabled = true;
            }
            busy = false;
        }
        private void TextBoxParam_TextChanged(object sender, EventArgs e) {
            if (!busy) {
                checkedListBoxParams.Items[checkedListBoxParams.SelectedIndex] = textBoxParam.Text;
                //profiles[listBoxProfile.SelectedIndex].name = listBoxProfile.Text;
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e) {
            StatusReset();
            Task.Factory.StartNew(() => ContactServer(labelStatusLogin, (int)numericUpDownPort.Value));
            Task.Factory.StartNew(() => ContactServer(labelStatusGame, 7777));
            Task.Factory.StartNew(() => ContactServer(labelStatusChat, 10241));
            //Task.Factory.StartNew(() => ContactServer(labelStatusWeb, 80));
            Task.Factory.StartNew(Ping);
            SaveToFile();
        }
        private void ContactServer(Label label, int port) {
            var client = new TcpClient();
            if (client.ConnectAsync(IPAddress.Parse(textBoxIP.Text), port).Wait(5000)) {
                Invoke(new Action(() => label.Text = "online"));
                Invoke(new Action(() => label.ForeColor = Color.Green));
                Invoke(new Action(progressBar1.PerformStep));
            } else {
                Invoke(new Action(() => label.Text = "offline"));
                Invoke(new Action(() => label.ForeColor = Color.Red));
            }
        }
        private void Ping() {
            PingReply x = new Ping().Send(textBoxIP.Text);
            if (x.Status == IPStatus.Success) {
                Invoke(new Action(() => labelStatusPing.Text = x.RoundtripTime + ""));
                Invoke(new Action(progressBar1.PerformStep));
            } else {
                Invoke(new Action(() => labelStatusPing.Text = x.Status + ""));
            }
        }
        private void StatusReset() {
            labelStatusLogin.Text = "??";
            labelStatusLogin.ForeColor = Color.Black;
            labelStatusGame.Text = "??";
            labelStatusGame.ForeColor = Color.Black;
            labelStatusChat.Text = "??";
            labelStatusChat.ForeColor = Color.Black;
            labelStatusPing.Text = "??";
            progressBar1.Value = 0;
        }

        private void ButtonExecute_Click(object sender, EventArgs e) {
            Process process = new Process() {
                StartInfo = new ProcessStartInfo() {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/c" + cmd
                }
            };
            process.Start();
            SaveToFile();
            Application.Exit();
        }
        private void Timer1_Tick(object sender, EventArgs e) {
            bool ready = true;

            string clientFolder = "???";
            if (listBoxVersion.SelectedIndex != -1) {
                clientFolder = listBoxVersion.Text;
            } else {
                ready = false;
            }
            string ip = textBoxIP.Text;
            if (IPAddress.TryParse(ip, out var x)) {
                groupBoxStatus.Enabled = true;
            } else {
                ip = "???";
                ready = false;
                groupBoxStatus.Enabled = false;
            }
            string language = "???";
            if (listBoxLanguage.SelectedIndex != -1) {
                language = listBoxLanguage.Text;
            } else {
                ready = false;
            }

            cmd = "start " + currentDir + string.Format(@"\{0}\bin32\aion.bin -ip:{1} -port:{2} -cc:{3} -lang:{4}", clientFolder, ip, numericUpDownPort.Value, numericUpDownCC.Value, language);
            foreach (var index in checkedListBoxParams.CheckedIndices) {
                cmd += " -" + checkedListBoxParams.Items[(int)index].ToString();
            }

            textBoxOutput.Text = cmd;
            buttonExecute.Enabled = ready;
        }
    }
}
