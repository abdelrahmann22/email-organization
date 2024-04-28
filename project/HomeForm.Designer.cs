namespace project
{
    partial class HomeForm
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
            helloText = new Label();
            signUpBtn = new Button();
            loginBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // helloText
            // 
            helloText.AutoSize = true;
            helloText.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helloText.Location = new Point(55, 70);
            helloText.Name = "helloText";
            helloText.Size = new Size(179, 43);
            helloText.TabIndex = 0;
            helloText.Text = "Hello, User!";
            // 
            // signUpBtn
            // 
            signUpBtn.Location = new Point(227, 274);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(127, 49);
            signUpBtn.TabIndex = 1;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(395, 274);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(127, 49);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 138);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 2;
            label1.Text = "Welcome to your email organizer.";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(signUpBtn);
            Controls.Add(helloText);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label helloText;
        private Button signUpBtn;
        private Button loginBtn;
        private Label label1;
    }
}