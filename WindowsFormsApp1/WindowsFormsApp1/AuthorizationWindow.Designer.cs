
namespace WindowsFormsApp1
{
    partial class AuthorizationWindow
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
            this.PasswordInput_Label = new System.Windows.Forms.Label();
            this.PasswordInput_textBox = new System.Windows.Forms.TextBox();
            this.Password_OK_Botton = new System.Windows.Forms.Button();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PasswordInput_Label
            // 
            this.PasswordInput_Label.AutoSize = true;
            this.PasswordInput_Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInput_Label.Location = new System.Drawing.Point(10, 9);
            this.PasswordInput_Label.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordInput_Label.Name = "PasswordInput_Label";
            this.PasswordInput_Label.Size = new System.Drawing.Size(306, 19);
            this.PasswordInput_Label.TabIndex = 8;
            this.PasswordInput_Label.Text = "Введите логин и пароль для использования";
            this.PasswordInput_Label.Click += new System.EventHandler(this.PasswordInput_Label_Click);
            // 
            // PasswordInput_textBox
            // 
            this.PasswordInput_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInput_textBox.Location = new System.Drawing.Point(12, 75);
            this.PasswordInput_textBox.Name = "PasswordInput_textBox";
            this.PasswordInput_textBox.Size = new System.Drawing.Size(200, 26);
            this.PasswordInput_textBox.TabIndex = 7;
            this.PasswordInput_textBox.TextChanged += new System.EventHandler(this.PasswordInput_textBox_TextChanged);
            this.PasswordInput_textBox.Enter += new System.EventHandler(this.PasswordInput_textBox_Enter);
            this.PasswordInput_textBox.Leave += new System.EventHandler(this.PasswordInput_textBox_Leave);
            // 
            // Password_OK_Botton
            // 
            this.Password_OK_Botton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Password_OK_Botton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_OK_Botton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Password_OK_Botton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_OK_Botton.Location = new System.Drawing.Point(247, 55);
            this.Password_OK_Botton.Name = "Password_OK_Botton";
            this.Password_OK_Botton.Size = new System.Drawing.Size(50, 26);
            this.Password_OK_Botton.TabIndex = 6;
            this.Password_OK_Botton.Text = "OK";
            this.Password_OK_Botton.UseVisualStyleBackColor = true;
            this.Password_OK_Botton.Click += new System.EventHandler(this.Password_OK_Botton_Click);
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(12, 34);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(200, 26);
            this.login_textBox.TabIndex = 9;
            this.login_textBox.TextChanged += new System.EventHandler(this.login_textBox_TextChanged);
            this.login_textBox.Enter += new System.EventHandler(this.login_textBox_Enter);
            this.login_textBox.Leave += new System.EventHandler(this.login_textBox_Leave);
            // 
            // AuthorizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 127);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.PasswordInput_Label);
            this.Controls.Add(this.PasswordInput_textBox);
            this.Controls.Add(this.Password_OK_Botton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AuthorizationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LittleBrother. Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordInput_Label;
        private System.Windows.Forms.TextBox PasswordInput_textBox;
        private System.Windows.Forms.Button Password_OK_Botton;
        private System.Windows.Forms.TextBox login_textBox;
    }
}