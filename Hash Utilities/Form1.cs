using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Hash_Utilities
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void GithubOpenClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/unixLikee");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            InitCustomLabelFont();
            

        }

        public void InitCustomLabelFont()
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            int fontLength = Properties.Resources.Roboto_Thin.Length;
            byte[] fontdata = Properties.Resources.Roboto_Thin;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);

            TitleLabel.Font = new Font(pfc.Families[0], TitleLabel.Font.Size);
        }

        private String MD5(String _input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider crypt = new System.Security.Cryptography.MD5CryptoServiceProvider();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(_input), 0, Encoding.UTF8.GetByteCount(_input));

            foreach (byte b in crypto)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        private String SHA1(String _input)
        {
            System.Security.Cryptography.SHA1Managed crypt = new System.Security.Cryptography.SHA1Managed();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(_input), 0, Encoding.UTF8.GetByteCount(_input));

            foreach (byte b in crypto)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        private String SHA256(String _input)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(_input), 0, Encoding.UTF8.GetByteCount(_input));

            foreach (byte b in crypto)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        private String SHA384(String _input)
        {
            System.Security.Cryptography.SHA384Managed crypt = new System.Security.Cryptography.SHA384Managed();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(_input), 0, Encoding.UTF8.GetByteCount(_input));

            foreach (byte b in crypto)
            {
                sb.Append(b.ToString("x2"));
            }
        return sb.ToString();
        }
        private String SHA512(String _input)
        {
            System.Security.Cryptography.SHA512Managed crypt = new System.Security.Cryptography.SHA512Managed();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(_input), 0, Encoding.UTF8.GetByteCount(_input));

            foreach (byte b in crypto)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        private void StringInputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MD5CheckBox.Checked)
            {
                DisplayHashFileMD5.Text = MD5(StringInputTextBox.Text);
                DisplayHashFileMD5.BackColor = System.Drawing.Color.LimeGreen;
            } else if (!MD5CheckBox.Checked)
            {
                DisplayHashFileMD5.Text = "";
                DisplayHashFileMD5.BackColor = System.Drawing.Color.Transparent;
            }

            if (SHA1CheckBox.Checked)
            {
                DisplayHashFileSHA1.Text = SHA1(StringInputTextBox.Text);
                DisplayHashFileSHA1.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (!SHA1CheckBox.Checked)
            {
                DisplayHashFileSHA1.Text = "";
                DisplayHashFileSHA1.BackColor = System.Drawing.Color.Transparent;
            }

            if (SHA256CheckBox.Checked)
            {
                DisplayHashFileSHA256.Text = SHA256(StringInputTextBox.Text);
                DisplayHashFileSHA256.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (!SHA256CheckBox.Checked)
            {
                DisplayHashFileSHA256.Text = "";
                DisplayHashFileSHA256.BackColor = System.Drawing.Color.Transparent;
            }

            if (SHA384CheckBox.Checked)
            {
                DisplayHashFileSHA384.Text = SHA384(StringInputTextBox.Text);
                DisplayHashFileSHA384.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (!SHA384CheckBox.Checked)
            {
                DisplayHashFileSHA384.Text = "";
                DisplayHashFileSHA384.BackColor = System.Drawing.Color.Transparent;
            }

            if (SHA512CheckBox.Checked)
            {
                DisplayHashFileSHA512.Text = SHA512(StringInputTextBox.Text);
                DisplayHashFileSHA512.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (!SHA512CheckBox.Checked)
            {
                DisplayHashFileSHA512.Text = "";
                DisplayHashFileSHA512.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void StringExportToFileButton_Click(object sender, EventArgs e)
        {
            StringSaveToFile.Filter = "*.txt|*.*";
            StringSaveToFile.Title = "Save selected hash files";
            StringSaveToFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StringSaveToFile.ShowDialog();

            if (StringSaveToFile.FileName != "")
            {
                File.Create(StringSaveToFile.FileName + ".txt").Close();
                TextWriter FileWriter = new StreamWriter(StringSaveToFile.FileName + ".txt");
                if (MD5CheckBox.Checked)
                {
                    FileWriter.WriteLine(StringInputTextBox.Text + "     MD5          " + MD5(StringInputTextBox.Text));
                }

                if (SHA1CheckBox.Checked)
                {
                    FileWriter.WriteLine(StringInputTextBox.Text + "     SHA-1        " + SHA1(StringInputTextBox.Text));
                }

                if (SHA256CheckBox.Checked)
                {
                    FileWriter.WriteLine(StringInputTextBox.Text + "     SHA-256      " + SHA256(StringInputTextBox.Text));
                }

                if (SHA384CheckBox.Checked)
                {
                    FileWriter.WriteLine(StringInputTextBox.Text + "     SHA-384      " + SHA384(StringInputTextBox.Text));
                }

                if (SHA512CheckBox.Checked)
                {
                    FileWriter.WriteLine(StringInputTextBox.Text + "     SHA-512      " + SHA512(StringInputTextBox.Text));
                }

                FileWriter.Close();
            }
        }

        private void CopyButtonStringMD5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MD5(StringInputTextBox.Text));
        }

        private void CopyButtonStringSHA1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA1(StringInputTextBox.Text));
        }

        private void CopyButtonStringSHA256_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA256(StringInputTextBox.Text));
        }

        private void CopyButtonStringSHA384_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA384(StringInputTextBox.Text));
        }

        private void CopyButtonStringSHA512_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA512(StringInputTextBox.Text));
        }
    }
}
