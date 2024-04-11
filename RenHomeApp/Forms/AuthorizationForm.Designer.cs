
namespace RenHomeApp.Forms
{
    partial class AuthorizationForm
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
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelError = new Label();
            bEntry = new Button();
            bExit = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(103, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(41, 15);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(95, 63);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 27);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(213, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 81);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(213, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 117);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 4;
            // 
            // bEntry
            // 
            bEntry.Location = new Point(12, 139);
            bEntry.Name = "bEntry";
            bEntry.Size = new Size(75, 23);
            bEntry.TabIndex = 5;
            bEntry.Text = "Войти";
            bEntry.UseVisualStyleBackColor = true;
            bEntry.Click += bEntry_Click;
            // 
            // bExit
            // 
            bExit.Location = new Point(150, 139);
            bExit.Name = "bExit";
            bExit.Size = new Size(75, 23);
            bExit.TabIndex = 6;
            bExit.Text = "Выход";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 174);
            ControlBox = false;
            Controls.Add(bExit);
            Controls.Add(bEntry);
            Controls.Add(labelError);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelError;
        private Button bEntry;
        private Button bExit;
    }
}