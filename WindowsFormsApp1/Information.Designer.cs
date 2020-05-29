namespace WindowsFormsApp1
{
    partial class Information
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
            this.DetailListView = new System.Windows.Forms.ListView();
            this.StudentFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentMName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailListView
            // 
            this.DetailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentFName,
            this.StudentMName,
            this.StudentLName,
            this.Score1,
            this.Score2,
            this.Score3});
            this.DetailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailListView.FullRowSelect = true;
            this.DetailListView.GridLines = true;
            this.DetailListView.HideSelection = false;
            this.DetailListView.Location = new System.Drawing.Point(3, 48);
            this.DetailListView.MultiSelect = false;
            this.DetailListView.Name = "DetailListView";
            this.DetailListView.Size = new System.Drawing.Size(717, 400);
            this.DetailListView.TabIndex = 0;
            this.DetailListView.UseCompatibleStateImageBehavior = false;
            this.DetailListView.View = System.Windows.Forms.View.Details;
            // 
            // StudentFName
            // 
            this.StudentFName.Text = "Имя";
            this.StudentFName.Width = 47;
            // 
            // StudentMName
            // 
            this.StudentMName.Text = "Отчество";
            this.StudentMName.Width = 84;
            // 
            // StudentLName
            // 
            this.StudentLName.Text = "Фамилия";
            this.StudentLName.Width = 93;
            // 
            // Score1
            // 
            this.Score1.Text = "Балл №1";
            this.Score1.Width = 64;
            // 
            // Score2
            // 
            this.Score2.Text = "Балл №2";
            // 
            // Score3
            // 
            this.Score3.Text = "Балл №3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DetailListView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 451);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(717, 39);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Information";
            this.Text = "Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DetailListView;
        private System.Windows.Forms.ColumnHeader StudentFName;
        private System.Windows.Forms.ColumnHeader StudentMName;
        private System.Windows.Forms.ColumnHeader StudentLName;
        private System.Windows.Forms.ColumnHeader Score1;
        private System.Windows.Forms.ColumnHeader Score2;
        private System.Windows.Forms.ColumnHeader Score3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button backButton;
    }
}