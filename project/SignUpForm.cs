using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{

    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string pathToUsers = "C:\\Users\\boudy\\Desktop\\email\\users\\UsersData.txt";
            string username = usernameBox.Text;
            try
            {
                if (File.ReadLines(pathToUsers).Any(line => line.Contains(username)))
                {
                    MessageBox.Show("Username already exists.");
                }
                else if (passwordBox.Text != confirmBox.Text)
                {
                    MessageBox.Show("Password and Confirm password not the same.");
                }
                else
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\boudy\\Desktop\\email\\users\\UsersData.txt", true))
                        {
                            writer.WriteLine(usernameBox.Text);

                        };

                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\boudy\\Desktop\\email\\users\\{usernameBox.Text}.txt", true))
                        {
                            writer.WriteLine(usernameBox.Text);
                            writer.WriteLine(passwordBox.Text);
                            writer.WriteLine(emailBox.Text);

                        };
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\boudy\\Desktop\\email\\profiles\\{usernameBox.Text}.txt", true))
                        {
                            writer.WriteLine(usernameBox.Text);
                        };
                        MessageBox.Show("Register Successfull.");
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.FormClosed += (s, args) => this.Close();
                        loginForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while writing to the file: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading from the file: {ex.Message}");
            }

        }

        private void signedLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
