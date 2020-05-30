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
            this.tableReg = new System.Windows.Forms.TableLayoutPanel();
            this.tableReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.BackColor = System.Drawing.SystemColors.Info;
            this.helloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.helloLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLabel.Location = new System.Drawing.Point(0, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(645, 23);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Начальный экран";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fNameBox
            // 
            this.fNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fNameBox.Location = new System.Drawing.Point(3, 31);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(316, 20);
            this.fNameBox.TabIndex = 1;
            // 
            // mNameBox
            // 
            this.mNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mNameBox.Location = new System.Drawing.Point(3, 87);
            this.mNameBox.Name = "mNameBox";
            this.mNameBox.Size = new System.Drawing.Size(316, 20);
            this.mNameBox.TabIndex = 2;
            // 
            // thNameBox
            // 
            this.thNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thNameBox.Location = new System.Drawing.Point(3, 143);
            this.thNameBox.Name = "thNameBox";
            this.thNameBox.Size = new System.Drawing.Size(316, 20);
            this.thNameBox.TabIndex = 3;
            // 
            // score1Box
            // 
            this.score1Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score1Box.Location = new System.Drawing.Point(325, 31);
            this.score1Box.Name = "score1Box";
            this.score1Box.Size = new System.Drawing.Size(317, 20);
            this.score1Box.TabIndex = 4;
            // 
            // score2Box
            // 
            this.score2Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score2Box.Location = new System.Drawing.Point(325, 87);
            this.score2Box.Name = "score2Box";
            this.score2Box.Size = new System.Drawing.Size(317, 20);
            this.score2Box.TabIndex = 5;
            // 
            // score3Box
            // 
            this.score3Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score3Box.Location = new System.Drawing.Point(325, 143);
            this.score3Box.Name = "score3Box";
            this.score3Box.Size = new System.Drawing.Size(317, 20);
            this.score3Box.TabIndex = 6;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateUser.Location = new System.Drawing.Point(3, 171);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(316, 22);
            this.buttonCreateUser.TabIndex = 7;
            this.buttonCreateUser.Text = "Создать пользователя";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonContinue.Location = new System.Drawing.Point(325, 171);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(317, 22);
            this.buttonContinue.TabIndex = 8;
            this.buttonContinue.Text = "Перейти к входу";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // openKeyLabel
            // 
            this.openKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openKeyLabel.AutoSize = true;
            this.openKeyLabel.Location = new System.Drawing.Point(3, 211);
            this.openKeyLabel.Name = "openKeyLabel";
            this.openKeyLabel.Size = new System.Drawing.Size(90, 13);
            this.openKeyLabel.TabIndex = 9;
            this.openKeyLabel.Text = "Открытый ключ:";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(325, 211);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(90, 13);
            this.privateKeyLabel.TabIndex = 10;
            this.privateKeyLabel.Text = "Закрытый ключ:";
            // 
            // FNameLabel
            // 
            this.FNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(3, 15);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FNameLabel.TabIndex = 11;
            this.FNameLabel.Text = "Имя";
            // 
            // MNameLabel
            // 
            this.MNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MNameLabel.AutoSize = true;
            this.MNameLabel.Location = new System.Drawing.Point(3, 71);
            this.MNameLabel.Name = "MNameLabel";
            this.MNameLabel.Size = new System.Drawing.Size(54, 13);
            this.MNameLabel.TabIndex = 12;
            this.MNameLabel.Text = "Отчество";
            // 
            // LNameLabel
            // 
            this.LNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(3, 127);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LNameLabel.TabIndex = 13;
            this.LNameLabel.Text = "Фамилия";
            // 
            // FScoreLabel
            // 
            this.FScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FScoreLabel.AutoSize = true;
            this.FScoreLabel.Location = new System.Drawing.Point(325, 15);
            this.FScoreLabel.Name = "FScoreLabel";
            this.FScoreLabel.Size = new System.Drawing.Size(78, 13);
            this.FScoreLabel.TabIndex = 14;
            this.FScoreLabel.Text = "Балл ЗНО №1";
            // 
            // SScoreLabel
            // 
            this.SScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SScoreLabel.AutoSize = true;
            this.SScoreLabel.Location = new System.Drawing.Point(325, 71);
            this.SScoreLabel.Name = "SScoreLabel";
            this.SScoreLabel.Size = new System.Drawing.Size(78, 13);
            this.SScoreLabel.TabIndex = 15;
            this.SScoreLabel.Text = "Балл ЗНО №2";
            // 
            // ThScoreLabel
            // 
            this.ThScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThScoreLabel.AutoSize = true;
            this.ThScoreLabel.Location = new System.Drawing.Point(325, 127);
            this.ThScoreLabel.Name = "ThScoreLabel";
            this.ThScoreLabel.Size = new System.Drawing.Size(78, 13);
            this.ThScoreLabel.TabIndex = 16;
            this.ThScoreLabel.Text = "Балл ЗНО №3";
            // 
            // OpenKeyBox
            // 
            this.OpenKeyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenKeyBox.Location = new System.Drawing.Point(3, 227);
            this.OpenKeyBox.Name = "OpenKeyBox";
            this.OpenKeyBox.ReadOnly = true;
            this.OpenKeyBox.Size = new System.Drawing.Size(316, 20);
            this.OpenKeyBox.TabIndex = 17;
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.privateKeyBox.Location = new System.Drawing.Point(325, 227);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.ReadOnly = true;
            this.privateKeyBox.Size = new System.Drawing.Size(317, 20);
            this.privateKeyBox.TabIndex = 18;
            // 
            // tableReg
            // 
            this.tableReg.AutoSize = true;
            this.tableReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableReg.ColumnCount = 2;
            this.tableReg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableReg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableReg.Controls.Add(this.privateKeyBox, 1, 8);
            this.tableReg.Controls.Add(this.fNameBox, 0, 1);
            this.tableReg.Controls.Add(this.privateKeyLabel, 1, 7);
            this.tableReg.Controls.Add(this.ThScoreLabel, 1, 4);
            this.tableReg.Controls.Add(this.buttonContinue, 1, 6);
            this.tableReg.Controls.Add(this.OpenKeyBox, 0, 8);
            this.tableReg.Controls.Add(this.score3Box, 1, 5);
            this.tableReg.Controls.Add(this.SScoreLabel, 1, 2);
            this.tableReg.Controls.Add(this.MNameLabel, 0, 2);
            this.tableReg.Controls.Add(this.score2Box, 1, 3);
            this.tableReg.Controls.Add(this.mNameBox, 0, 3);
            this.tableReg.Controls.Add(this.LNameLabel, 0, 4);
            this.tableReg.Controls.Add(this.thNameBox, 0, 5);
            this.tableReg.Controls.Add(this.score1Box, 1, 1);
            this.tableReg.Controls.Add(this.buttonCreateUser, 0, 6);
            this.tableReg.Controls.Add(this.openKeyLabel, 0, 7);
            this.tableReg.Controls.Add(this.FScoreLabel, 1, 0);
            this.tableReg.Controls.Add(this.FNameLabel, 0, 0);
            this.tableReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableReg.Location = new System.Drawing.Point(0, 23);
            this.tableReg.Name = "tableReg";
            this.tableReg.RowCount = 9;
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableReg.Size = new System.Drawing.Size(645, 261);
            this.tableReg.TabIndex = 19;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 448);
            this.Controls.Add(this.tableReg);
            this.Controls.Add(this.helloLabel);
            this.MinimumSize = new System.Drawing.Size(336, 375);
            this.Name = "RegForm";
            this.ShowIcon = false;
            this.Text = "RegForm";
            this.tableReg.ResumeLayout(false);
            this.tableReg.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableReg;
    }
}