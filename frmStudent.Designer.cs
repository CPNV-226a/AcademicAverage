namespace CPNV
{
    partial class FrmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            this.pcbStudentFace = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveGrade = new System.Windows.Forms.Button();
            this.btnUpdateGrade = new System.Windows.Forms.Button();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.lsbGrades = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbConfirmCancel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStudentFace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbConfirmCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbStudentFace
            // 
            this.pcbStudentFace.Image = ((System.Drawing.Image)(resources.GetObject("pcbStudentFace.Image")));
            this.pcbStudentFace.Location = new System.Drawing.Point(18, 19);
            this.pcbStudentFace.Name = "pcbStudentFace";
            this.pcbStudentFace.Size = new System.Drawing.Size(104, 107);
            this.pcbStudentFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStudentFace.TabIndex = 0;
            this.pcbStudentFace.TabStop = false;
            this.pcbStudentFace.Click += new System.EventHandler(this.pcbStudentFace_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblFirstname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.pcbStudentFace);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal data";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(194, 68);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(144, 20);
            this.txtFirstname.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(133, 71);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(58, 13);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "Firstname :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(133, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // txtAverage
            // 
            this.txtAverage.Enabled = false;
            this.txtAverage.Location = new System.Drawing.Point(221, 49);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(51, 20);
            this.txtAverage.TabIndex = 8;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(224, 30);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(47, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAverage);
            this.groupBox2.Controls.Add(this.btnRemoveGrade);
            this.groupBox2.Controls.Add(this.btnUpdateGrade);
            this.groupBox2.Controls.Add(this.btnAddGrade);
            this.groupBox2.Controls.Add(this.lblAverage);
            this.groupBox2.Controls.Add(this.lsbGrades);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grades";
            // 
            // btnRemoveGrade
            // 
            this.btnRemoveGrade.Location = new System.Drawing.Point(18, 78);
            this.btnRemoveGrade.Name = "btnRemoveGrade";
            this.btnRemoveGrade.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveGrade.TabIndex = 3;
            this.btnRemoveGrade.Text = "Remove";
            this.btnRemoveGrade.UseVisualStyleBackColor = true;
            this.btnRemoveGrade.Click += new System.EventHandler(this.cmdConfirm_Click);
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.Location = new System.Drawing.Point(18, 49);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGrade.TabIndex = 2;
            this.btnUpdateGrade.Text = "Update";
            this.btnUpdateGrade.UseVisualStyleBackColor = true;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(18, 20);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrade.TabIndex = 1;
            this.btnAddGrade.Text = "Add";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.cmdAddGrade_Click);
            // 
            // lsbGrades
            // 
            this.lsbGrades.FormattingEnabled = true;
            this.lsbGrades.Items.AddRange(new object[] {
            "4.5",
            "5.5",
            "6.0",
            "3.0"});
            this.lsbGrades.Location = new System.Drawing.Point(99, 20);
            this.lsbGrades.Name = "lsbGrades";
            this.lsbGrades.Size = new System.Drawing.Size(52, 82);
            this.lsbGrades.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(47, 19);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // grbConfirmCancel
            // 
            this.grbConfirmCancel.Controls.Add(this.btnConfirm);
            this.grbConfirmCancel.Controls.Add(this.btnCancel);
            this.grbConfirmCancel.Location = new System.Drawing.Point(12, 291);
            this.grbConfirmCancel.Name = "grbConfirmCancel";
            this.grbConfirmCancel.Size = new System.Drawing.Size(285, 48);
            this.grbConfirmCancel.TabIndex = 5;
            this.grbConfirmCancel.TabStop = false;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 348);
            this.Controls.Add(this.grbConfirmCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbStudentFace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbConfirmCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbStudentFace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveGrade;
        private System.Windows.Forms.Button btnUpdateGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.ListBox lsbGrades;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbConfirmCancel;
    }
}