namespace project
{
    partial class LoginForm
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
            enterPasswordLabel = new Label();
            enterUsernameLabel = new Label();
            enterUsernameBox = new TextBox();
            enterPasswordBox = new TextBox();
            loginBtn = new Button();
            RegisterLink = new LinkLabel();
            SuspendLayout();
            // 
            // enterPasswordLabel
            // 
            enterPasswordLabel.AutoSize = true;
            enterPasswordLabel.Location = new Point(322, 210);
            enterPasswordLabel.Name = "enterPasswordLabel";
            enterPasswordLabel.Size = new Size(57, 15);
            enterPasswordLabel.TabIndex = 0;
            enterPasswordLabel.Text = "Password";
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.AutoSize = true;
            enterUsernameLabel.Location = new Point(322, 119);
            enterUsernameLabel.Name = "enterUsernameLabel";
            enterUsernameLabel.Size = new Size(60, 15);
            enterUsernameLabel.TabIndex = 0;
            enterUsernameLabel.Text = "Username";
            enterUsernameLabel.Click += enterUsernameLabel_Click;
            // 
            // enterUsernameBox
            // 
            enterUsernameBox.Location = new Point(322, 154);
            enterUsernameBox.Name = "enterUsernameBox";
            enterUsernameBox.Size = new Size(304, 23);
            enterUsernameBox.TabIndex = 1;
            // 
            // enterPasswordBox
            // 
            enterPasswordBox.Location = new Point(322, 247);
            enterPasswordBox.Name = "enterPasswordBox";
            enterPasswordBox.Size = new Size(304, 23);
            enterPasswordBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(432, 331);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Location = new Point(545, 288);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(81, 15);
            RegisterLink.TabIndex = 3;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "New Register?";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 450);
            Controls.Add(RegisterLink);
            Controls.Add(loginBtn);
            Controls.Add(enterPasswordBox);
            Controls.Add(enterUsernameBox);
            Controls.Add(enterUsernameLabel);
            Controls.Add(enterPasswordLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox enterUsernameBox;
        private TextBox enterPasswordBox;
        private Label enterUsernameLabel;
        private Label enterPasswordLabel;
        private LinkLabel RegisterLink;
        private Button loginBtn;
    }
}