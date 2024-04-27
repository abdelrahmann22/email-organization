using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string pathToUser = $"C:\\Users\\boudy\\Desktop\\email\\users\\{enterUsernameBox.Text}.txt";
            if (File.Exists(pathToUser))
            {
                string[] lines = File.ReadAllLines(pathToUser);
                if (lines[0] == enterUsernameBox.Text && lines[1] == enterPasswordBox.Text)
                {
                    MessageBox.Show("Login Successfull.");
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or passowrd");
            }
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signupForm = new SignUpForm();
            signupForm.FormClosed += (s, args) => this.Close();
            signupForm.Show();
        }

        private void enterUsernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
