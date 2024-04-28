namespace project
{
    partial class ProfileForm
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
            signoutBtn = new Button();
            settingsBtn = new Button();
            inboxBtn = new Button();
            SuspendLayout();
            // 
            // signoutBtn
            // 
            signoutBtn.Location = new Point(666, 397);
            signoutBtn.Name = "signoutBtn";
            signoutBtn.Size = new Size(75, 23);
            signoutBtn.TabIndex = 0;
            signoutBtn.Text = "Sign out";
            signoutBtn.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            settingsBtn.Location = new Point(124, 312);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(227, 63);
            settingsBtn.TabIndex = 1;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            // 
            // inboxBtn
            // 
            inboxBtn.Location = new Point(383, 312);
            inboxBtn.Name = "inboxBtn";
            inboxBtn.Size = new Size(227, 63);
            inboxBtn.TabIndex = 1;
            inboxBtn.Text = "Inbox";
            inboxBtn.UseVisualStyleBackColor = true;
            inboxBtn.Click += inboxBtn_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inboxBtn);
            Controls.Add(settingsBtn);
            Controls.Add(signoutBtn);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button signoutBtn;
        private Button settingsBtn;
        private Button inboxBtn;
    }
}