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
            all = new Button();
            sent = new Button();
            reccievd = new Button();
            spam = new Button();
            dataGridView1 = new DataGridView();
            subject = new DataGridViewTextBoxColumn();
            sender = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            view = new DataGridViewButtonColumn();
            change = new DataGridViewButtonColumn();
            create = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // all
            // 
            all.Location = new Point(52, 22);
            all.Name = "all";
            all.Size = new Size(75, 67);
            all.TabIndex = 1;
            all.Text = "all";
            all.UseVisualStyleBackColor = true;
            all.Click += button1_Click;
            // 
            // sent
            // 
            sent.Location = new Point(52, 118);
            sent.Name = "sent";
            sent.Size = new Size(75, 67);
            sent.TabIndex = 2;
            sent.Text = "sent";
            sent.UseVisualStyleBackColor = true;
            sent.Click += sent_Click;
            // 
            // reccievd
            // 
            reccievd.Location = new Point(52, 220);
            reccievd.Name = "reccievd";
            reccievd.Size = new Size(75, 67);
            reccievd.TabIndex = 3;
            reccievd.Text = "reccievd";
            reccievd.UseVisualStyleBackColor = true;
            reccievd.Click += reccievd_Click;
            // 
            // spam
            // 
            spam.Location = new Point(52, 324);
            spam.Name = "spam";
            spam.Size = new Size(75, 67);
            spam.TabIndex = 4;
            spam.Text = "spam";
            spam.UseVisualStyleBackColor = true;
            spam.Click += spam_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { subject, sender, time, view, change });
            dataGridView1.Location = new Point(178, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(610, 369);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentClick;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            // 
            // subject
            // 
            subject.HeaderText = "subject";
            subject.Name = "subject";
            // 
            // sender
            // 
            sender.HeaderText = "sender";
            sender.Name = "sender";
            // 
            // time
            // 
            time.HeaderText = "time";
            time.Name = "time";
            // 
            // view
            // 
            view.HeaderText = "view";
            view.Name = "view";
            // 
            // change
            // 
            change.HeaderText = "change";
            change.Name = "change";
            // 
            // create
            // 
            create.Location = new Point(178, 398);
            create.Name = "create";
            create.Size = new Size(104, 40);
            create.TabIndex = 6;
            create.Text = "create folder";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // InboxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(create);
            Controls.Add(dataGridView1);
            Controls.Add(spam);
            Controls.Add(reccievd);
            Controls.Add(sent);
            Controls.Add(all);
            Name = "InboxForm";
            Text = "InboxView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button all;
        private Button sent;
        private Button reccievd;
        private Button spam;
        private DataGridView dataGridView1;
        private Button create;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn sender;
        private DataGridViewTextBoxColumn time;
        private DataGridViewButtonColumn view;
        private DataGridViewButtonColumn change;
    }
}