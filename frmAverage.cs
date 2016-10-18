using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPNV
{
    public partial class FrmAverage : Form
    {
        #region contructors
        public FrmAverage()
        {
            InitializeComponent();
        }
        #endregion constructors

        #region private methods
        #region GUI events listener
        private void frmOverview_Load(object sender, EventArgs e)
        {
            cmdAddStudent.Enabled = true;
        }

        private void cmdAddStudent_Click(object sender, EventArgs e)
        {
            openFrmStudentInModale();
        }

        private void mnuItemAdd_Click(object sender, EventArgs e)
        {
            openFrmStudentInModale();
        }

        private void cmdUpdateStudent_Click(object sender, EventArgs e)
        {
            openFrmStudentInModale();
        }

        private void cmdDelete_click(object sender, EventArgs e)
        {
            removeStudent();
        }

        private void mnuItemRemove_Click(object sender, EventArgs e)
        {
            removeStudent();
        }
        private void lsbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdUpdateStudent.Enabled = true;
            cmdUpdateStudent.Image = null;
            cmdRemoveStudent.Enabled = true;
            cmdRemoveStudent.Image = null;

            mnuItemUpdate.Enabled = true;
            mnuItemRemove.Enabled = true;
        }

        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            openFrmStudentInModale();
        }
        #endregion GUI events listener

        #region Common actions after events
        private void openFrmStudentInModale()
        {
            FrmStudent frmStudent = new FrmStudent();
            if (frmStudent.ShowDialog(this) == DialogResult.OK)
            {


            }
        }

        private void removeStudent()
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'un élève", MessageBoxButtons.OKCancel);
        }
        #endregion Common actions after events
        #endregion private methods

        #region accessors and mutators for unit test
        public bool cmdAddStudentStatus
        {
            get { return this.cmdAddStudent.Enabled; }
        }

        public bool mnuItemAddStudentStatus
        {
            get { return this.mnuItemAdd.Enabled; }
        }

        public bool cmdUpdateStudentStatus
        {
            get { return this.cmdUpdateStudent.Enabled; }
        }

        public bool mnuItemUpdateStudentStatus
        {
            get { return this.mnuItemUpdate.Enabled; }
        }

        public bool cmdRemoveStudentStatus
        {
            get { return this.cmdRemoveStudent.Enabled; }
        }

        public bool mnuItemRemoveStudentStatus
        {
            get { return this.mnuItemRemove.Enabled; }
        }
        #endregion accessors and mutators for unit test
    }
}
