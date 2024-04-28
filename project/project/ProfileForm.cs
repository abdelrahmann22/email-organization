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
    public partial class ProfileForm : Form
    {
        private string currentUsername;
        private Label lblCurrentUsername;
        public ProfileForm(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
            lblCurrentUsername = new Label();
            Controls.Add(lblCurrentUsername);

            lblCurrentUsername.Text = $"{char.ToUpper(currentUsername[0]) + currentUsername.Substring(1)}'s profile";
            lblCurrentUsername.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentUsername.Size = new Size(500, 500);
            lblCurrentUsername.Location = new Point(55, 75);
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void inboxBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InboxForm inboxform = new InboxForm(currentUsername);
            inboxform.FormClosed += (s, args) => this.Close();
            inboxform.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
