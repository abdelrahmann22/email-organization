using System;
using System.Windows.Forms;
using System.IO;

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // This method is called when Form2 is loaded
        private void Form2_Load(object sender, EventArgs e)
        {
            // No action needed on form load in this example
        }

        // This method is called when button1 is clicked
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
