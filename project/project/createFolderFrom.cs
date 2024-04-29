using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class createFolderFrom : Form
    {
        public createFolderFrom()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Define the folder path where the new folder will be created
            string folderPath = $"C:\\Users\\youss\\OneDrive\\Desktop\\bb\\profilles\\mails\\created\\{textBox1.Text}";

            // Check if the text box is not empty
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                try
                {
                    // Check if the folder doesn't exist
                    if (!Directory.Exists(folderPath))
                    {
                        // Create the folder
                        Directory.CreateDirectory(folderPath);
                        MessageBox.Show("Folder created successfully!");
                    }
                    else
                    {
                        // Display message if the folder already exists
                        MessageBox.Show("Folder already exists!");
                    }
                }
                catch (Exception ex)
                {
                    // Display error message if folder creation fails
                    MessageBox.Show($"Error creating folder: {ex.Message}");
                }
            }
            else
            {
                // Display message if the text box is empty
                MessageBox.Show("Please enter a valid folder name!");
            }

            // Close the form after folder creation attempt
            this.Close();
        }
    }
}
