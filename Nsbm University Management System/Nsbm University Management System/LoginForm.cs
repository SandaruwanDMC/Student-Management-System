using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Nsbm_University_Management_System
{
    public partial class LoginForm : Form
    {
        User user = new User();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Input login data!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    user.Uname = username.Text;
                    user.Passwrd = Encript(password.Text);
                    if (user.Login())
                    {

                        Form1 main = new Form1();
                        this.Hide();
                        main.Show();

                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public string Encript(string password)
        {
            string hash = "#Pw@2021$Password!";
            byte[] data = UTF32Encoding.UTF32.GetBytes(password);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();

            tripDES.Key = md5.ComputeHash(UTF32Encoding.UTF32.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }
    }
}
