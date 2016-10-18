namespace CPNV
{
    partial class frmAverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAverage));
            this.grbStudents = new System.Windows.Forms.GroupBox();
            this.lsbStudents = new System.Windows.Forms.ListBox();
            this.cmdAddStudent = new System.Windows.Forms.Button();
            this.cmdUpdateStudent = new System.Windows.Forms.Button();
            this.cmdRemoveStudent = new System.Windows.Forms.Button();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.grbStudents.SuspendLayout();
            this.grbActions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbStudents
            // 
            this.grbStudents.Controls.Add(this.lsbStudents);
            this.grbStudents.Location = new System.Drawing.Point(4, 42);
            this.grbStudents.Name = "grbStudents";
            this.grbStudents.Size = new System.Drawing.Size(130, 265);
            this.grbStudents.TabIndex = 0;
            this.grbStudents.TabStop = false;
            this.grbStudents.Text = "Students";
            // 
            // lsbStudents
            // 
            this.lsbStudents.FormattingEnabled = true;
            this.lsbStudents.Items.AddRange(new object[] {
            "Eleve 1 - 4.5",
            "Eleve 2 - 3.5",
            "Eleve 3 - 2.5",
            "Eleve 4 - 5.5",
            "Eleve 5 - 4.5",
            "Eleve 6 - 3.5",
            "Eleve 7 - 2.5",
            "Eleve 8 - 5.5",
            "Eleve 9 - 4.5",
            "Eleve 10 - 3.5",
            "Eleve 11 - 2.5",
            "Eleve 12 - 5.5",
            "Eleve 13 - 4.5",
            "Eleve 14 - 3.5",
            "Eleve 15 - 2.5",
            "Eleve 16 - 5.5"});
            this.lsbStudents.Location = new System.Drawing.Point(8, 26);
            this.lsbStudents.Name = "lsbStudents";
            this.lsbStudents.Size = new System.Drawing.Size(103, 225);
            this.lsbStudents.TabIndex = 0;
            this.lsbStudents.SelectedIndexChanged += new System.EventHandler(this.lsbStudents_SelectedIndexChanged);
            // 
            // cmdAddStudent
            // 
            this.cmdAddStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAddStudent.BackgroundImage")));
            this.cmdAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAddStudent.Location = new System.Drawing.Point(13, 30);
            this.cmdAddStudent.Name = "cmdAddStudent";
            this.cmdAddStudent.Size = new System.Drawing.Size(60, 70);
            this.cmdAddStudent.TabIndex = 0;
            this.cmdAddStudent.UseVisualStyleBackColor = true;
            this.cmdAddStudent.Click += new System.EventHandler(this.cmdAddStudent_Click);
            // 
            // cmdUpdateStudent
            // 
            this.cmdUpdateStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdUpdateStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdUpdateStudent.BackgroundImage")));
            this.cmdUpdateStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdUpdateStudent.Enabled = false;
            this.cmdUpdateStudent.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpdateStudent.Image")));
            this.cmdUpdateStudent.Location = new System.Drawing.Point(15, 106);
            this.cmdUpdateStudent.Name = "cmdUpdateStudent";
            this.cmdUpdateStudent.Size = new System.Drawing.Size(60, 68);
            this.cmdUpdateStudent.TabIndex = 1;
            this.cmdUpdateStudent.UseVisualStyleBackColor = false;
            this.cmdUpdateStudent.Click += new System.EventHandler(this.cmdUpdateStudent_Click);
            // 
            // cmdRemoveStudent
            // 
            this.cmdRemoveStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRemoveStudent.BackgroundImage")));
            this.cmdRemoveStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRemoveStudent.Enabled = false;
            this.cmdRemoveStudent.Image = ((System.Drawing.Image)(resources.GetObject("cmdRemoveStudent.Image")));
            this.cmdRemoveStudent.Location = new System.Drawing.Point(16, 180);
            this.cmdRemoveStudent.Name = "cmdRemoveStudent";
            this.cmdRemoveStudent.Size = new System.Drawing.Size(60, 67);
            this.cmdRemoveStudent.TabIndex = 2;
            this.cmdRemoveStudent.UseVisualStyleBackColor = true;
            this.cmdRemoveStudent.Click += new System.EventHandler(this.cmdDelete_click);
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.cmdRemoveStudent);
            this.grbActions.Controls.Add(this.cmdUpdateStudent);
            this.grbActions.Controls.Add(this.cmdAddStudent);
            this.grbActions.Location = new System.Drawing.Point(140, 44);
            this.grbActions.Name = "grbActions";
            this.grbActions.Size = new System.Drawing.Size(92, 263);
            this.grbActions.TabIndex = 1;
            this.grbActions.TabStop = false;
            this.grbActions.Text = "Actions";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudent,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(245, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStudent
            // 
            this.mnuStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAdd,
            this.mnuItemUpdate,
            this.mnuItemRemove});
            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Size = new System.Drawing.Size(60, 20);
            this.mnuStudent.Text = "Student";
            // 
            // mnuItemAdd
            // 
            this.mnuItemAdd.Name = "mnuItemAdd";
            this.mnuItemAdd.Size = new System.Drawing.Size(117, 22);
            this.mnuItemAdd.Text = "Add";
            this.mnuItemAdd.Click += new System.EventHandler(this.mnuItemAdd_Click);
            // 
            // mnuItemUpdate
            // 
            this.mnuItemUpdate.Enabled = false;
            this.mnuItemUpdate.Name = "mnuItemUpdate";
            this.mnuItemUpdate.Size = new System.Drawing.Size(117, 22);
            this.mnuItemUpdate.Text = "Update";
            this.mnuItemUpdate.Click += new System.EventHandler(this.mnuItemUpdate_Click);
            // 
            // mnuItemRemove
            // 
            this.mnuItemRemove.Enabled = false;
            this.mnuItemRemove.Name = "mnuItemRemove";
            this.mnuItemRemove.Size = new System.Drawing.Size(117, 22);
            this.mnuItemRemove.Text = "Remove";
            this.mnuItemRemove.Click += new System.EventHandler(this.mnuItemRemove_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // frmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 319);
            this.Controls.Add(this.grbActions);
            this.Controls.Add(this.grbStudents);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOverview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.frmOverview_Load);
            this.grbStudents.ResumeLayout(false);
            this.grbActions.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudents;
        private System.Windows.Forms.ListBox lsbStudents;
        private System.Windows.Forms.Button cmdAddStudent;
        private System.Windows.Forms.Button cmdUpdateStudent;
        private System.Windows.Forms.Button cmdRemoveStudent;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
    }
}

