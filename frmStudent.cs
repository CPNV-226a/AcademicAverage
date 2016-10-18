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
    public partial class FrmStudent : Form
    {
        #region private attributes
        private Student _student = null;
        #endregion private attributes

        #region constructors
        public FrmStudent()
        {
            InitializeComponent();
        }

        public FrmStudent(Student student)
        {
            InitializeComponent();
            _student = student;
        }
        #endregion constructors

        #region IHM actions
        private void frmStudent_Load(object sender, EventArgs e)
        {
            updateIHM();
        }

        private void pcbStudentFace_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'une note", MessageBoxButtons.OKCancel);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous l'annulation ?", "Suppression de la saisie", MessageBoxButtons.OKCancel);
        }

        private void cmdAddGrade_Click(object sender, EventArgs e)
        {
            frmGradesInput frmManageMark = new frmGradesInput();
            
            frmManageMark.ShowDialog(this);
        }
        #endregion IHM actions

        #region common private methods
        //private openFrmGrade()
        //{

        //}

        private void updateIHM()
        {
            Student stud = this._student;
            if (stud != null)
            {
                txtFirstname.Text = stud.firstname;
                txtName.Text = stud.name;
            }
        }

        #endregion common private methods
    }
}
