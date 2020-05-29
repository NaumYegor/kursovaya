namespace WindowsFormsApp1
{
    partial class AddSpecialization
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
            this.HeaderAdd = new System.Windows.Forms.Label();
            this.SchoolBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.SpecializationBox = new System.Windows.Forms.TextBox();
            this.FacultyBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.SchoolLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.SpecializationLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AddSpecLabel = new System.Windows.Forms.TableLayoutPanel();
            this.MakeSpecButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.AddSpecLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderAdd
            // 
            this.HeaderAdd.BackColor = System.Drawing.SystemColors.Info;
            this.HeaderAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderAdd.Location = new System.Drawing.Point(0, 0);
            this.HeaderAdd.Name = "HeaderAdd";
            this.HeaderAdd.Size = new System.Drawing.Size(608, 26);
            this.HeaderAdd.TabIndex = 0;
            this.HeaderAdd.Text = "Добавить специальность";
            this.HeaderAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SchoolBox
            // 
            this.SchoolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchoolBox.Location = new System.Drawing.Point(95, 29);
            this.SchoolBox.Name = "SchoolBox";
            this.SchoolBox.Size = new System.Drawing.Size(211, 20);
            this.SchoolBox.TabIndex = 2;
            // 
            // CityBox
            // 
            this.CityBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityBox.Location = new System.Drawing.Point(95, 3);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(211, 20);
            this.CityBox.TabIndex = 1;
            // 
            // SpecializationBox
            // 
            this.SpecializationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecializationBox.Location = new System.Drawing.Point(95, 81);
            this.SpecializationBox.Name = "SpecializationBox";
            this.SpecializationBox.Size = new System.Drawing.Size(211, 20);
            this.SpecializationBox.TabIndex = 4;
            // 
            // FacultyBox
            // 
            this.FacultyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacultyBox.Location = new System.Drawing.Point(95, 55);
            this.FacultyBox.Name = "FacultyBox";
            this.FacultyBox.Size = new System.Drawing.Size(211, 20);
            this.FacultyBox.TabIndex = 3;
            // 
            // TypeBox
            // 
            this.TypeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeBox.Location = new System.Drawing.Point(95, 107);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(211, 20);
            this.TypeBox.TabIndex = 5;
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(52, 6);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(37, 13);
            this.CityLabel.TabIndex = 6;
            this.CityLabel.Text = "Город";
            // 
            // SchoolLabel
            // 
            this.SchoolLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SchoolLabel.AutoSize = true;
            this.SchoolLabel.Location = new System.Drawing.Point(60, 32);
            this.SchoolLabel.Name = "SchoolLabel";
            this.SchoolLabel.Size = new System.Drawing.Size(29, 13);
            this.SchoolLabel.TabIndex = 7;
            this.SchoolLabel.Text = "ВУЗ";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(26, 58);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(63, 13);
            this.FacultyLabel.TabIndex = 8;
            this.FacultyLabel.Text = "Факультет";
            // 
            // SpecializationLabel
            // 
            this.SpecializationLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SpecializationLabel.AutoSize = true;
            this.SpecializationLabel.Location = new System.Drawing.Point(3, 84);
            this.SpecializationLabel.Name = "SpecializationLabel";
            this.SpecializationLabel.Size = new System.Drawing.Size(86, 13);
            this.SpecializationLabel.TabIndex = 9;
            this.SpecializationLabel.Text = "Специализация";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(14, 110);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(75, 13);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = "Тип обучения";
            // 
            // AddSpecLabel
            // 
            this.AddSpecLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSpecLabel.ColumnCount = 2;
            this.AddSpecLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.AddSpecLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.AddSpecLabel.Controls.Add(this.Exit, 0, 6);
            this.AddSpecLabel.Controls.Add(this.MakeSpecButton, 1, 6);
            this.AddSpecLabel.Controls.Add(this.CityBox, 1, 0);
            this.AddSpecLabel.Controls.Add(this.TypeLabel, 0, 4);
            this.AddSpecLabel.Controls.Add(this.SchoolBox, 1, 1);
            this.AddSpecLabel.Controls.Add(this.SpecializationLabel, 0, 3);
            this.AddSpecLabel.Controls.Add(this.FacultyBox, 1, 2);
            this.AddSpecLabel.Controls.Add(this.FacultyLabel, 0, 2);
            this.AddSpecLabel.Controls.Add(this.SpecializationBox, 1, 3);
            this.AddSpecLabel.Controls.Add(this.SchoolLabel, 0, 1);
            this.AddSpecLabel.Controls.Add(this.TypeBox, 1, 4);
            this.AddSpecLabel.Controls.Add(this.CityLabel, 0, 0);
            this.AddSpecLabel.Controls.Add(this.PriceLabel, 0, 5);
            this.AddSpecLabel.Controls.Add(this.PriceBox, 1, 5);
            this.AddSpecLabel.Location = new System.Drawing.Point(117, 89);
            this.AddSpecLabel.MinimumSize = new System.Drawing.Size(309, 184);
            this.AddSpecLabel.Name = "AddSpecLabel";
            this.AddSpecLabel.RowCount = 7;
            this.AddSpecLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AddSpecLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AddSpecLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AddSpecLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AddSpecLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AddSpecLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AddSpecLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AddSpecLabel.Size = new System.Drawing.Size(309, 184);
            this.AddSpecLabel.TabIndex = 11;
            // 
            // MakeSpecButton
            // 
            this.MakeSpecButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakeSpecButton.Location = new System.Drawing.Point(95, 159);
            this.MakeSpecButton.Name = "MakeSpecButton";
            this.MakeSpecButton.Size = new System.Drawing.Size(211, 22);
            this.MakeSpecButton.TabIndex = 7;
            this.MakeSpecButton.Text = "Добавить специальность";
            this.MakeSpecButton.UseVisualStyleBackColor = true;
            this.MakeSpecButton.Click += new System.EventHandler(this.MakeSpecButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(7, 136);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(82, 13);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Цена обучения";
            // 
            // PriceBox
            // 
            this.PriceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceBox.Location = new System.Drawing.Point(95, 133);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(211, 20);
            this.PriceBox.TabIndex = 6;
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.Location = new System.Drawing.Point(3, 159);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 22);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 372);
            this.Controls.Add(this.AddSpecLabel);
            this.Controls.Add(this.HeaderAdd);
            this.Name = "AddSpecialization";
            this.Text = "AddSpecialization";
            this.Load += new System.EventHandler(this.AddSpecialization_Load);
            this.AddSpecLabel.ResumeLayout(false);
            this.AddSpecLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeaderAdd;
        private System.Windows.Forms.TextBox SchoolBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox SpecializationBox;
        private System.Windows.Forms.TextBox FacultyBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label SchoolLabel;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label SpecializationLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TableLayoutPanel AddSpecLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button MakeSpecButton;
        private System.Windows.Forms.Button Exit;
    }
}