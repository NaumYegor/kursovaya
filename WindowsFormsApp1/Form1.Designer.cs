namespace WindowsFormsApp1
{
    partial class welcomeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.buttonSigned = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.buttonUnknown = new System.Windows.Forms.Button();
            this.buttonMake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(522, 27);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Вход в программу";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSigned
            // 
            this.buttonSigned.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSigned.AutoSize = true;
            this.buttonSigned.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSigned.Location = new System.Drawing.Point(194, 191);
            this.buttonSigned.MaximumSize = new System.Drawing.Size(100, 30);
            this.buttonSigned.Name = "buttonSigned";
            this.buttonSigned.Size = new System.Drawing.Size(90, 23);
            this.buttonSigned.TabIndex = 1;
            this.buttonSigned.Text = "Начать работу";
            this.buttonSigned.UseVisualStyleBackColor = true;
            this.buttonSigned.Click += new System.EventHandler(this.welcomeButton_Click);
            // 
            // loginBox
            // 
            this.loginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(195, 122);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 20);
            this.loginBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(194, 163);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 22);
            this.passwordBox.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(196, 104);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(99, 15);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Открытый ключ:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(196, 145);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 15);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Закрытый ключ:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // buttonUnknown
            // 
            this.buttonUnknown.Location = new System.Drawing.Point(195, 269);
            this.buttonUnknown.Name = "buttonUnknown";
            this.buttonUnknown.Size = new System.Drawing.Size(75, 23);
            this.buttonUnknown.TabIndex = 6;
            this.buttonUnknown.Text = "Нет ключа";
            this.buttonUnknown.UseVisualStyleBackColor = true;
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(194, 240);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(115, 23);
            this.buttonMake.TabIndex = 7;
            this.buttonMake.Text = "Зарегистрировать";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(522, 345);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.buttonUnknown);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.buttonSigned);
            this.Controls.Add(this.welcomeLabel);
            this.MaximumSize = new System.Drawing.Size(538, 384);
            this.MinimumSize = new System.Drawing.Size(538, 384);
            this.Name = "welcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button buttonSigned;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button buttonUnknown;
        private System.Windows.Forms.Button buttonMake;
    }
}

