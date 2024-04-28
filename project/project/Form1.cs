using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        // Dictionary to map row index to file path
        private Dictionary<int, string> fileMapping;
        // Paths to different mail folders
        String allfile = @"C:\Users\youss\OneDrive\Desktop\bb\profilles\mails\all";
        string sentfile = @"C:\Users\youss\OneDrive\Desktop\bb\profilles\mails\sent";
        string recfile = @"C:\Users\youss\OneDrive\Desktop\bb\profilles\mails\reccived";
        string spamfile = @"C:\Users\youss\OneDrive\Desktop\bb\profilles\mails\spam";

        public Form1()
        {
            InitializeComponent();
            // Initialize the dictionary
            fileMapping = new Dictionary<int, string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to be executed when the form loads
        }

        // Button click event to create a new mail
        private void create_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        // Button click event to load all mails
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshTextBox(allfile);
        }

        // Button click event to load sent mails
        private void sent_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshTextBox(sentfile);
        }

        // Button click event to load received mails
        private void reccievd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshTextBox(recfile);
        }

        // Button click event to load spam mails
        private void spam_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshTextBox(spamfile);
        }

        // Method to refresh the DataGridView with file information from a given folder
        private void RefreshTextBox(string filepath)
        {
            // Clear the file mapping dictionary
            fileMapping.Clear();

            // Get all files in the specified folder
            string[] files = Directory.GetFiles(filepath);

            // Iterate through each file
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                string firstLine = ReadFirstLine(files[i]); // Read the first line of the file
                string FileName = Path.GetFileNameWithoutExtension(files[i]); // Get the file name without extension
                DateTime creationTime = file.CreationTime; // Get the creation time of the file
                // Add file information to the DataGridView
                this.dataGridView1.Rows.Add(firstLine, FileName, creationTime);
                // Add mapping of row index to file path
                fileMapping.Add(i, files[i]);
            }
        }

        // DataGridView cell content click event
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the "change" button is clicked
            if (dataGridView1.Columns[e.ColumnIndex].Name == "change")
            {
                MessageBox.Show("aa"); // Display a message box
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method is not currently being used
        }
    }
}
