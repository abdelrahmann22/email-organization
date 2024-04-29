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
    public partial class SettingsForm : Form
    {
        private string currentUsername;
        public SettingsForm(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string filePath = @$"C:\Users\boudy\Desktop\email\users\{this.currentUsername}.txt";
            string newPassword = textBox1.Text;
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                lines[1] = newPassword;
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Password changed successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            this.Hide();
            ProfileForm profileform = new ProfileForm(this.currentUsername);
            profileform.FormClosed += (s, args) => this.Close();
            profileform.Show();

        }
    }
}
