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
    public partial class InboxForm : Form
    {
        private string currentUsername;
        private Label lblCurrentUsername;
        public InboxForm(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
            lblCurrentUsername = new Label();
            Controls.Add(lblCurrentUsername);

            lblCurrentUsername.Text = char.ToUpper(currentUsername[0]) + currentUsername.Substring(1);
            lblCurrentUsername.Font = new Font(lblCurrentUsername.Font.FontFamily, 12);
            lblCurrentUsername.Location = new Point(20, 20);
        }

        private void emailView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
