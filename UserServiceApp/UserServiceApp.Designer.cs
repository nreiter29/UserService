namespace UserServiceApp
{
    partial class UserServiceApp : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            registerButton = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            roleTextBox = new TextBox();
            roleLabel = new Label();
            isInRoleButton = new Button();
            roleInRoleTextBox = new TextBox();
            label1 = new Label();
            usernameInRoleTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            //
            // usernameLabel
            //
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(163, 89);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            //
            // passwordLabel
            //
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(163, 117);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            //
            // loginButton
            //
            loginButton.Location = new Point(163, 186);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(90, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            //
            // registerButton
            //
            registerButton.Location = new Point(259, 186);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(100, 23);
            registerButton.TabIndex = 3;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            //
            // usernameTextBox
            //
            usernameTextBox.Location = new Point(259, 87);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 4;
            //
            // passwordTextBox
            //
            passwordTextBox.Location = new Point(259, 117);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            //
            // roleTextBox
            //
            roleTextBox.Location = new Point(259, 146);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.Size = new Size(100, 23);
            roleTextBox.TabIndex = 7;
            //
            // roleLabel
            //
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(163, 146);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(30, 15);
            roleLabel.TabIndex = 6;
            roleLabel.Text = "Roles";
            //
            // isInRoleButton
            //
            isInRoleButton.Location = new Point(434, 147);
            isInRoleButton.Name = "isInRoleButton";
            isInRoleButton.Size = new Size(171, 23);
            isInRoleButton.TabIndex = 8;
            isInRoleButton.Text = "IsInRole";
            isInRoleButton.UseVisualStyleBackColor = true;
            isInRoleButton.Click += isInRoleButton_Click;
            //
            // roleInRoleTextBox
            //
            roleInRoleTextBox.Location = new Point(500, 118);
            roleInRoleTextBox.Name = "roleInRoleTextBox";
            roleInRoleTextBox.Size = new Size(100, 23);
            roleInRoleTextBox.TabIndex = 12;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(434, 121);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 11;
            label1.Text = "Roles";
            //
            // usernameInRoleTextBox
            //
            usernameInRoleTextBox.Location = new Point(500, 89);
            usernameInRoleTextBox.Name = "usernameInRoleTextBox";
            usernameInRoleTextBox.Size = new Size(100, 23);
            usernameInRoleTextBox.TabIndex = 10;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(434, 91);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Username";
            //
            // UserServiceApp
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(roleInRoleTextBox);
            Controls.Add(label1);
            Controls.Add(usernameInRoleTextBox);
            Controls.Add(label2);
            Controls.Add(isInRoleButton);
            Controls.Add(roleTextBox);
            Controls.Add(roleLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "UserServiceApp";
            Text = "UserServiceApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Button registerButton;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox roleTextBox;
        private Label roleLabel;
        private Button isInRoleButton;
        private TextBox roleInRoleTextBox;
        private Label label1;
        private TextBox usernameInRoleTextBox;
        private Label label2;
    }
}
