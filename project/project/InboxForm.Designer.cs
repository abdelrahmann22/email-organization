namespace project
{
    partial class InboxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailView = new DataGridView();
            checkboxColumn = new DataGridViewCheckBoxColumn();
            nameView = new DataGridViewTextBoxColumn();
            subjectView = new DataGridViewTextBoxColumn();
            dateView = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)emailView).BeginInit();
            SuspendLayout();
            // 
            // emailView
            // 
            emailView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emailView.Columns.AddRange(new DataGridViewColumn[] { checkboxColumn, nameView, subjectView, dateView });
            emailView.Dock = DockStyle.Right;
            emailView.Location = new Point(195, 0);
            emailView.Name = "emailView";
            emailView.Size = new Size(1062, 582);
            // 
            // checkboxColumn
            // 
            checkboxColumn.HeaderText = "";
            checkboxColumn.Name = "checkboxColumn";
            checkboxColumn.Resizable = DataGridViewTriState.False;
            checkboxColumn.Width = 50;
            // 
            // nameView
            // 
            nameView.HeaderText = "Name";
            nameView.Name = "nameView";
            nameView.ReadOnly = true;
            nameView.Resizable = DataGridViewTriState.False;
            nameView.Width = 300;
            // 
            // subjectView
            // 
            subjectView.HeaderText = "Subject";
            subjectView.Name = "subjectView";
            subjectView.ReadOnly = true;
            subjectView.Resizable = DataGridViewTriState.False;
            subjectView.Width = 500;
            // 
            // dateView
            // 
            dateView.HeaderText = "Date";
            dateView.Name = "dateView";
            dateView.ReadOnly = true;
            dateView.Resizable = DataGridViewTriState.False;
            dateView.SortMode = DataGridViewColumnSortMode.NotSortable;
            dateView.Width = 200;
            // 
            // InboxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 582);
            Controls.Add(emailView);
            Name = "InboxForm";
            Text = "InboxForm";
            ((System.ComponentModel.ISupportInitialize)emailView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView emailView;
        private DataGridViewCheckBoxColumn checkboxColumn;
        private DataGridViewTextBoxColumn nameView;
        private DataGridViewTextBoxColumn subjectView;
        private DataGridViewTextBoxColumn dateView;
    }
}