namespace WindowsFormsApp1
{
    partial class RegForm
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.mNameBox = new System.Windows.Forms.TextBox();
            this.thNameBox = new System.Windows.Forms.TextBox();
            this.score1Box = new System.Windows.Forms.TextBox();
            this.score2Box = new System.Windows.Forms.TextBox();
            this.score3Box = new System.Windows.Forms.TextBox();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.openKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.MNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FScoreLabel = new System.Windows.Forms.Label();
            this.SScoreLabel = new System.Windows.Forms.Label();
            this.ThScoreLabel = new System.Windows.Forms.Label();
            this.OpenKeyBox = new System.Windows.Forms.TextBox();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.BackColor = System.Drawing.SystemColors.Info;
            this.helloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.helloLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLabel.Location = new System.Drawing.Point(0, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(800, 23);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Начальный экран";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(234, 72);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(100, 20);
            this.fNameBox.TabIndex = 1;
            // 
            // mNameBox
            // 
            this.mNameBox.Location = new System.Drawing.Point(234, 120);
            this.mNameBox.Name = "mNameBox";
            this.mNameBox.Size = new System.Drawing.Size(100, 20);
            this.mNameBox.TabIndex = 2;
            // 
            // thNameBox
            // 
            this.thNameBox.Location = new System.Drawing.Point(234, 163);
            this.thNameBox.Name = "thNameBox";
            this.thNameBox.Size = new System.Drawing.Size(100, 20);
            this.thNameBox.TabIndex = 3;
            // 
            // score1Box
            // 
            this.score1Box.Location = new System.Drawing.Point(438, 72);
            this.score1Box.Name = "score1Box";
            this.score1Box.Size = new System.Drawing.Size(100, 20);
            this.score1Box.TabIndex = 4;
            // 
            // score2Box
            // 
            this.score2Box.Location = new System.Drawing.Point(438, 120);
            this.score2Box.Name = "score2Box";
            this.score2Box.Size = new System.Drawing.Size(100, 20);
            this.score2Box.TabIndex = 5;
            // 
            // score3Box
            // 
            this.score3Box.Location = new System.Drawing.Point(438, 163);
            this.score3Box.Name = "score3Box";
            this.score3Box.Size = new System.Drawing.Size(100, 20);
            this.score3Box.TabIndex = 6;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(207, 270);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(141, 23);
            this.buttonCreateUser.TabIndex = 7;
            this.buttonCreateUser.Text = "Создать пользователя";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(405, 270);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(149, 23);
            this.buttonContinue.TabIndex = 8;
            this.buttonContinue.Text = "Перейти к входу";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // openKeyLabel
            // 
            this.openKeyLabel.AutoSize = true;
            this.openKeyLabel.Location = new System.Drawing.Point(234, 342);
            this.openKeyLabel.Name = "openKeyLabel";
            this.openKeyLabel.Size = new System.Drawing.Size(90, 13);
            this.openKeyLabel.TabIndex = 9;
            this.openKeyLabel.Text = "Открытый ключ:";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(438, 341);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(90, 13);
            this.privateKeyLabel.TabIndex = 10;
            this.privateKeyLabel.Text = "Закрытый ключ:";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(234, 53);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FNameLabel.TabIndex = 11;
            this.FNameLabel.Text = "Имя";
            // 
            // MNameLabel
            // 
            this.MNameLabel.AutoSize = true;
            this.MNameLabel.Location = new System.Drawing.Point(234, 99);
            this.MNameLabel.Name = "MNameLabel";
            this.MNameLabel.Size = new System.Drawing.Size(54, 13);
            this.MNameLabel.TabIndex = 12;
            this.MNameLabel.Text = "Отчество";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(234, 144);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LNameLabel.TabIndex = 13;
            this.LNameLabel.Text = "Фамилия";
            // 
            // FScoreLabel
            // 
            this.FScoreLabel.AutoSize = true;
            this.FScoreLabel.Location = new System.Drawing.Point(438, 52);
            this.FScoreLabel.Name = "FScoreLabel";
            this.FScoreLabel.Size = new System.Drawing.Size(78, 13);
            this.FScoreLabel.TabIndex = 14;
            this.FScoreLabel.Text = "Балл ЗНО №1";
            // 
            // SScoreLabel
            // 
            this.SScoreLabel.AutoSize = true;
            this.SScoreLabel.Location = new System.Drawing.Point(438, 99);
            this.SScoreLabel.Name = "SScoreLabel";
            this.SScoreLabel.Size = new System.Drawing.Size(78, 13);
            this.SScoreLabel.TabIndex = 15;
            this.SScoreLabel.Text = "Балл ЗНО №2";
            // 
            // ThScoreLabel
            // 
            this.ThScoreLabel.AutoSize = true;
            this.ThScoreLabel.Location = new System.Drawing.Point(438, 144);
            this.ThScoreLabel.Name = "ThScoreLabel";
            this.ThScoreLabel.Size = new System.Drawing.Size(78, 13);
            this.ThScoreLabel.TabIndex = 16;
            this.ThScoreLabel.Text = "Балл ЗНО №3";
            // 
            // OpenKeyBox
            // 
            this.OpenKeyBox.Location = new System.Drawing.Point(207, 358);
            this.OpenKeyBox.Name = "OpenKeyBox";
            this.OpenKeyBox.ReadOnly = true;
            this.OpenKeyBox.Size = new System.Drawing.Size(141, 20);
            this.OpenKeyBox.TabIndex = 17;
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(405, 358);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.ReadOnly = true;
            this.privateKeyBox.Size = new System.Drawing.Size(149, 20);
            this.privateKeyBox.TabIndex = 18;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.privateKeyBox);
            this.Controls.Add(this.OpenKeyBox);
            this.Controls.Add(this.ThScoreLabel);
            this.Controls.Add(this.SScoreLabel);
            this.Controls.Add(this.FScoreLabel);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.MNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.openKeyLabel);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.score3Box);
            this.Controls.Add(this.score2Box);
            this.Controls.Add(this.score1Box);
            this.Controls.Add(this.thNameBox);
            this.Controls.Add(this.mNameBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.helloLabel);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox mNameBox;
        private System.Windows.Forms.TextBox thNameBox;
        private System.Windows.Forms.TextBox score1Box;
        private System.Windows.Forms.TextBox score2Box;
        private System.Windows.Forms.TextBox score3Box;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label openKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label MNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label FScoreLabel;
        private System.Windows.Forms.Label SScoreLabel;
        private System.Windows.Forms.Label ThScoreLabel;
        internal System.Windows.Forms.TextBox OpenKeyBox;
        internal System.Windows.Forms.TextBox privateKeyBox;
    }
}