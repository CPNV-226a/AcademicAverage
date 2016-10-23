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

        #region accessors and mutators
        public Student student
        {
            get { return this._student; }
        }

        public bool cmdAddGradeStatus
        {
            get { return this.cmdAddGrade.Enabled; }
        }

        public bool cmdUpdateGradeStatus
        {
            get { return this.cmdUpdateGrade.Enabled; }
        }

        public bool cmdRemoveGradeStatus
        {
            get { return this.cmdRemoveGrade.Enabled; }
        }

        public bool cmdConfirmStatus
        {
            get { return this.cmdConfirm.Enabled; }
        }

        public bool cmdCancelStatus
        {
            get { return this.cmdCancel.Enabled; }
        }
        #endregion accessors and mutators

        #region GUI events
        private void cmdRemoveGrade_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'une note", MessageBoxButtons.OKCancel);
        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            Student stud = new Student(this.txtName.Text, this.txtFirstname.Text);
            this._student = stud;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            updateGUI();
        }

        private void pcbStudentFace_Click(object sender, EventArgs e)
        {

        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous l'annulation ?", "Suppression de la saisie", MessageBoxButtons.OKCancel);
        }

        private void cmdAddGrade_Click(object sender, EventArgs e)
        {
            
        }
        #endregion GUI actions

        #region common private methods
        private void updateGUI()
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
