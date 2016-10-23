namespace CPNV
{
    partial class FrmGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrade));
            this.nduGradeNumber = new System.Windows.Forms.NumericUpDown();
            this.numGradeDecimal = new System.Windows.Forms.NumericUpDown();
            this.grbManageGrade = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbConfirmCancel = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nduGradeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGradeDecimal)).BeginInit();
            this.grbManageGrade.SuspendLayout();
            this.grbConfirmCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nduGradeNumber
            // 
            this.nduGradeNumber.Location = new System.Drawing.Point(24, 25);
            this.nduGradeNumber.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nduGradeNumber.Name = "nduGradeNumber";
            this.nduGradeNumber.Size = new System.Drawing.Size(53, 20);
            this.nduGradeNumber.TabIndex = 2;
            this.nduGradeNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nduGradeNumber.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numGradeDecimal
            // 
            this.numGradeDecimal.Location = new System.Drawing.Point(97, 25);
            this.numGradeDecimal.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numGradeDecimal.Name = "numGradeDecimal";
            this.numGradeDecimal.Size = new System.Drawing.Size(53, 20);
            this.numGradeDecimal.TabIndex = 3;
            this.numGradeDecimal.ValueChanged += new System.EventHandler(this.numGradeDecimal_ValueChanged);
            // 
            // grbManageGrade
            // 
            this.grbManageGrade.Controls.Add(this.label1);
            this.grbManageGrade.Controls.Add(this.nduGradeNumber);
            this.grbManageGrade.Controls.Add(this.numGradeDecimal);
            this.grbManageGrade.Location = new System.Drawing.Point(24, 13);
            this.grbManageGrade.Name = "grbManageGrade";
            this.grbManageGrade.Size = new System.Drawing.Size(178, 54);
            this.grbManageGrade.TabIndex = 4;
            this.grbManageGrade.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // grbConfirmCancel
            // 
            this.grbConfirmCancel.Controls.Add(this.btnCancel);
            this.grbConfirmCancel.Controls.Add(this.btnConfirm);
            this.grbConfirmCancel.Location = new System.Drawing.Point(24, 73);
            this.grbConfirmCancel.Name = "grbConfirmCancel";
            this.grbConfirmCancel.Size = new System.Drawing.Size(178, 45);
            this.grbConfirmCancel.TabIndex = 5;
            this.grbConfirmCancel.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(97, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(6, 15);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmGradesInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 122);
            this.Controls.Add(this.grbConfirmCancel);
            this.Controls.Add(this.grbManageGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGradesInput";
            this.Text = "Grades input";
            this.Load += new System.EventHandler(this.frmGradesInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nduGradeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGradeDecimal)).EndInit();
            this.grbManageGrade.ResumeLayout(false);
            this.grbManageGrade.PerformLayout();
            this.grbConfirmCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nduGradeNumber;
        private System.Windows.Forms.NumericUpDown numGradeDecimal;
        private System.Windows.Forms.GroupBox grbManageGrade;
        private System.Windows.Forms.GroupBox grbConfirmCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
    }
}