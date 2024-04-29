namespace project
{
    partial class SignUpForm
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
            usernameBox = new TextBox();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            confirmBox = new TextBox();
            emailLabel = new Label();
            passwordLabel = new Label();
            confirmLabel = new Label();
            usernameLabel = new Label();
            signedLink = new LinkLabel();
            signupBtn = new Button();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(228, 53);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(302, 23);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(228, 125);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(302, 23);
            emailBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(228, 191);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(302, 23);
            passwordBox.TabIndex = 0;
            // 
            // confirmBox
            // 
            confirmBox.Location = new Point(228, 260);
            confirmBox.Name = "confirmBox";
            confirmBox.Size = new Size(302, 23);
            confirmBox.TabIndex = 0;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(228, 107);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(228, 173);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // confirmLabel
            // 
            confirmLabel.AutoSize = true;
            confirmLabel.Location = new Point(228, 242);
            confirmLabel.Name = "confirmLabel";
            confirmLabel.Size = new Size(104, 15);
            confirmLabel.TabIndex = 1;
            confirmLabel.Text = "Confirm Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(228, 35);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // signedLink
            // 
            signedLink.AutoSize = true;
            signedLink.Location = new Point(439, 302);
            signedLink.Name = "signedLink";
            signedLink.Size = new Size(91, 15);
            signedLink.TabIndex = 2;
            signedLink.TabStop = true;
            signedLink.Text = "Already Signed?";
            signedLink.LinkClicked += signedLink_LinkClicked;
            // 
            // signupBtn
            // 
            signupBtn.Location = new Point(257, 334);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(230, 50);
            signupBtn.TabIndex = 3;
            signupBtn.Text = "Sign Up";
            signupBtn.UseVisualStyleBackColor = true;
            signupBtn.Click += signupBtn_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signupBtn);
            Controls.Add(signedLink);
            Controls.Add(confirmLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(emailLabel);
            Controls.Add(confirmBox);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(usernameBox);
            Name = "SignUpForm";
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private LinkLabel signedLink;
        private Button signupBtn;
        private Label emailLabel;
        private Label passwordLabel;
        private Label confirmLabel;
        private Label usernameLabel;
        private TextBox emailBox;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private TextBox confirmBox;
    }
}