using Microsoft.VisualBasic.Devices;
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
        private Dictionary<int, string> fileMapping;

        private string allfile;
        private string sentfile;
        private string recfile;
        private string spamfile;

        private string currentUsername;

        public InboxForm(string currentUsername)
        {
            InitializeComponent();
            fileMapping = new Dictionary<int, string>();
            this.currentUsername = currentUsername;
            this.allfile = @$"C:\Users\youss\OneDrive\Desktop\bb\profilles\{this.currentUsername}\mails\all";
            this.sentfile = @$"C:\Users\youss\OneDrive\Desktop\bb\profilles\{this.currentUsername}\mails\sent";
            this.recfile = $@"C:\Users\youss\OneDrive\Desktop\bb\profilles\{this.currentUsername}\mails\reccived";
            this.spamfile = @$"C:\Users\youss\OneDrive\Desktop\bb\profilles\{this.currentUsername}\mails\spam";
        }

        private void create_Click(object sender, EventArgs e)
        {
            createFolderFrom f2 = new createFolderFrom();
            f2.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshTextBox(this.allfile);
        }
        private void sent_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshTextBox(this.sentfile);
        }

        // Button click event to load received mails
        private void reccievd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshTextBox(this.recfile);
        }

        // Button click event to load spam mails
        private void spam_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshTextBox(this.spamfile);
        }

        // Method to refresh the DataGridView with file information from a given folder
        private void RefreshTextBox(string filepath)
        {
            try
            {
                // Clear the file mapping dictionary
                fileMapping.Clear();

                // Get all files in the specified folder
                string[] files = Directory.GetFiles(filepath);

                // Iterate through each file
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = new FileInfo(files[i]);

                    // Check if the file exists
                    if (file.Exists)
                    {
                        string firstLine = ReadFirstLine(files[i]); // Read the first line of the file
                        string FileName = Path.GetFileNameWithoutExtension(files[i]); // Get the file name without extension
                        DateTime creationTime = file.CreationTime; // Get the creation time of the file
                                                                   // Add file information to the DataGridView
                        this.dataGridView1.Rows.Add(firstLine, FileName, creationTime);
                        // Add mapping of row index to file path
                        fileMapping.Add(i, files[i]);
                    }
                    else
                    {
                        // Handle the case where the file does not exist
                        // You can log the error, show a message to the user, or take any other appropriate action
                        Console.WriteLine($"File '{files[i]}' does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the execution of the method
                // You can log the exception, display an error message to the user, or take any other appropriate action
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        // DataGridView cell content click event
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the "change" button is clicked
            if (dataGridView1.Columns[e.ColumnIndex].Name == "change")
            {

                // Open a folder dialog to select the destination folder
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.SelectedPath = @$"C:\Users\youss\OneDrive\Desktop\bb\profilles\{this.currentUsername}\mails\created\";
                    DialogResult result = folderDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                    {
                        try
                        {

                            // Get the source file path
                            string sourceFilePath = fileMapping[e.RowIndex];

                            // Combine the destination folder path with the file name
                            string fileName = Path.GetFileName(sourceFilePath);
                            string destinationFilePath = Path.Combine(folderDialog.SelectedPath, fileName);

                            // Copy the file to the selected folder
                            File.Copy(sourceFilePath, destinationFilePath);

                            MessageBox.Show("File copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while copying the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
            // Check if the "view" button is clicked
            if (dataGridView1.Columns[e.ColumnIndex].Name == "view")
            {
                OpenFile(e.RowIndex); // Open the selected file
            }
        }

        // Method to open the file associated with the selected row in DataGridView
        private void OpenFile(int lineIndex)
        {
            // Check if the file mapping dictionary contains the selected row index
            if (fileMapping.ContainsKey(lineIndex))
            {
                string filePath = fileMapping[lineIndex]; // Get the file path from the dictionary
                System.Diagnostics.Process.Start("explorer.exe", filePath); // Open the file using the default application
            }
        }

        // DataGridView column header mouse click event
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Check if the "Creation Time" header is clicked
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Creation Time")
            {
                // Sort the DataGridView by creation time in ascending order
                dataGridView1.Sort(dataGridView1.Columns[e.ColumnIndex], ListSortDirection.Ascending);
            }
        }

        // Method to read the first line of a file
        private string ReadFirstLine(string filePath)
        {
            string firstLine = string.Empty;

            // Read the first line of the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                firstLine = reader.ReadLine();
            }
            return firstLine;
        }

    }
}