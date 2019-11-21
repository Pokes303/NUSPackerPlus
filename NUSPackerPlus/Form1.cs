using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Net;

namespace NUSPackerPlus
{
    public partial class Form1 : Form
    {
        bool[] checks = { false, false, false, false };
        string ckeyPath = Directory.GetCurrentDirectory() + "\\WiiU_Common_Key.txt";
        string nuspPath = Directory.GetCurrentDirectory() + "\\NUSPacker.jar";
        string presetPath = Directory.GetCurrentDirectory() + "\\config.preset";

        public Form1()
        {
            InitializeComponent();
            this.Width = 370;
            consoleTextBox.Visible = false;
        }

        void doChecks(byte check, bool value)
        {
            checks[check] = value;
            int allChecks = 0;
            for (int i = 0; i < checks.Length; i++)
                if (checks[i])
                    allChecks++;
            startButton.Enabled = (allChecks == 4);
            savepreButton.Enabled = (allChecks == 4);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(inputTextBox.Text))
            {
                inputTextBox.BackColor = Color.Aquamarine;
                inputLabel.Visible = false;
                inputOpenButton.Enabled = true;
                doChecks(0, true);
            }
            else
            {
                inputTextBox.BackColor = Color.Pink;
                inputLabel.Visible = true;
                inputOpenButton.Enabled = false;
                doChecks(0, false);
            }
        }

        private void inputTextBox_DragDrop(object sender, DragEventArgs e)
        {
            inputTextBox.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void inputTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void inputOpenButton_Click(object sender, EventArgs e)
        {
            Process.Start(inputTextBox.Text);
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            if (inputBFD.ShowDialog() != DialogResult.OK)
                return;

            inputTextBox.Text = inputBFD.SelectedPath;
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

            if (Directory.Exists(outputTextBox.Text))
            {
                outputTextBox.BackColor = Color.Aquamarine;
                outputLabel.Visible = false;
                outputOpenButton.Enabled = true;
                doChecks(1, true);
            }
            else
            {
                outputTextBox.BackColor = Color.Pink;
                outputLabel.Visible = true;
                outputOpenButton.Enabled = false;
                doChecks(1, false);
            }
        }

        private void outputTextBox_DragDrop(object sender, DragEventArgs e)
        {
            outputTextBox.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void outputTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void outputOpenButton_Click(object sender, EventArgs e)
        {
            Process.Start(outputTextBox.Text);
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            if (outputBFD.ShowDialog() != DialogResult.OK)
                return;

            outputTextBox.Text = outputBFD.SelectedPath;
        }

        private void enckeyTextBox_TextChanged(object sender, EventArgs e)
        {
            bool failed = false;
            if (enckeyTextBox.Text.Length == 32)
            {
                for (int i = 0; i < enckeyTextBox.Text.Length; i++)
                {
                    if (!((enckeyTextBox.Text[i] >= '0' && enckeyTextBox.Text[i] <= '9') ||
                        (enckeyTextBox.Text[i] >= 'a' && enckeyTextBox.Text[i] <= 'f') ||
                        (enckeyTextBox.Text[i] >= 'A' && enckeyTextBox.Text[i] <= 'F')))
                    {
                        failed = true;
                        break;
                    }
                }
            }
            else
                failed = true;

            if (failed)
            {
                enckeyTextBox.BackColor = Color.Pink;
                doChecks(2, false);
            }
            else
            {
                enckeyTextBox.BackColor = Color.Aquamarine;
                doChecks(2, true);
            }
        }

        private void enckeyButton_Click(object sender, EventArgs e)
        {
            enckeyTextBox.Text = "";
            Random rnd = new Random();
            for (int i = 0; i < 32; i++)
            {
                int calcNum = rnd.Next(0, 2); //Randomize if current byte is number or hex char

                if (calcNum == 0)
                {
                    int num = rnd.Next(0, 9);
                    enckeyTextBox.Text += num.ToString();
                }
                else
                {
                    int hex = rnd.Next(0xA, 0x10);
                    enckeyTextBox.Text += $"{hex:X}";
                }
            }
        }

        string generateHash(string input)
        {
            SHA256 enc = SHA256.Create();

            byte[] b = enc.ComputeHash(Encoding.UTF8.GetBytes(input));

            string res = "";
            for (int i = 0; i < b.Length; i++)
                res += $"{b[i]:X}";

            return res;
        }

        private void comkeyTextBox_TextChanged(object sender, EventArgs e)
        {
            string hash = generateHash(comkeyTextBox.Text);

            if (hash == "318514F571FAB59A969E875DAAE9CEB7BC20A9D8E4AD5BAD69B4DFB6294D6E")
            {
                comkeyTextBox.BackColor = Color.Aquamarine;
                comkeySaveBut.Enabled = true;
                doChecks(3, true);
            }
            else
            {
                comkeyTextBox.BackColor = Color.Pink;
                comkeySaveBut.Enabled = false;
                doChecks(3, false);
            }
        }

        private void comkeyCheckBut_Click(object sender, EventArgs e)
        {
            if (File.Exists(ckeyPath) && new FileInfo(ckeyPath).Length == 75) //Safe ckey import
            {
                 string ckey = File.ReadAllLines(ckeyPath)[0];
                if (ckey.Length > 32)
                    ckey.Remove(32, ckey.Length - 32);

                comkeyTextBox.Text = ckey;
                return;
            }
            MessageBox.Show("Common Key File isn't valid or not found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comkeySaveBut_Click(object sender, EventArgs e)
        {
            string export = comkeyTextBox.Text + "\nCommon Key File generated by NUSPackerPlus";
            File.WriteAllText(ckeyPath, export);

            MessageBox.Show("Common Key File generated successfully on:\n\n" + ckeyPath, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            if (this.Width == 370)
            {
                this.Width = 770;
                expandButton.Text = "<<";
                consoleTextBox.Visible = true;
            }
            else
            {
                consoleTextBox.Visible = false;
                expandButton.Text = ">>";
                this.Width = 370;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(nuspPath))
            {
                if (MessageBox.Show($"NUSPacker.jar file not found on:\n\n{nuspPath}\n\nDo you want to download it now?", "NUSPacker.jar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        using (WebClient cli = new WebClient())
                            cli.DownloadFile(@"https://bitbucket.org/timogus/nuspacker/downloads/NUSPacker.jar", nuspPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error has ocurred while trying to download NUSPacker.jar:\n\n{ex.ToString()}", "NUSPacker.jar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                    return;
            }

            this.Width = 770;
            expandButton.Text = "<<";
            consoleTextBox.Visible = true;
            this.Update();
            expandButton.Update();

            Process nusp = new Process();
            nusp.StartInfo.UseShellExecute = false;
            nusp.StartInfo.CreateNoWindow = true;
            nusp.StartInfo.RedirectStandardOutput = true;
            nusp.StartInfo.FileName = "java";
            nusp.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();

            nusp.StartInfo.Arguments = $"-jar \"{nuspPath}\" -in \"{inputTextBox.Text}\" -out \"{outputTextBox.Text}\" -encryptionKey {enckeyTextBox.Text} -encryptKeyWith {comkeyTextBox.Text}";
            
            consoleTextBox.Text = $"-- NUSPacker.jar output --{Environment.NewLine}{Environment.NewLine}Args: {nusp.StartInfo.Arguments}{Environment.NewLine}{Environment.NewLine}";
            consoleTextBox.Update();

            nusp.Start();

            StreamReader sr = nusp.StandardOutput;
            while (!nusp.HasExited)
            {
                consoleTextBox.Text += sr.ReadLine() + Environment.NewLine;
                consoleTextBox.Update();
            }
            consoleTextBox.Text += sr.ReadToEnd();
            sr.Close();
            
            try
            {
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\output"))
                    Directory.Delete(Directory.GetCurrentDirectory() + "\\output", true);
            }
            catch (Exception ex) { }

            MessageBox.Show("Finished!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">> NUSPackerPlus [1.0] <<\n\n" +
                "This version made by Pokes303\n" +
                ">https://github.com/Pokes303\n\n" +
                "Original NUSPacker by timogus\n" +
                ">https://bitbucket.org/timogus/nuspacker\n\n" +
                "Icons are part of Google's Material Design repo", "Some info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadsetButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(presetPath) && new FileInfo(presetPath).Length < 865)
            {
                string[] preset = File.ReadAllLines(presetPath);
                if (preset.Length != 4)
                    goto presetFailed;

                short size = 400;
                for (byte i = 0; i < 2; i++)
                {
                    if (preset[i].Length > size)
                        preset[i] = preset[i].Remove(size, preset[i].Length - size);

                    if (i == 1)
                        size = 32;
                }
                
                inputTextBox.Text = preset[0];
                outputTextBox.Text = preset[1];
                enckeyTextBox.Text = preset[2];
                comkeyTextBox.Text = preset[3];
                return;
            }
            presetFailed:

            MessageBox.Show("Preset file isn't valid or not found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void savepreButton_Click(object sender, EventArgs e)
        {
            string[] preset = { inputTextBox.Text, outputTextBox.Text, enckeyTextBox.Text, comkeyTextBox.Text };
            File.WriteAllLines(presetPath, preset);

            MessageBox.Show("Preset file generated successfully on:\n\n" + presetPath, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
