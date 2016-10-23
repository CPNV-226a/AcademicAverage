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
    /// <summary>
    /// This class is designed
    /// to be a form used by the teacher to add data in the application
    /// The teacher will be able to add, modify all components of a student, included its list of grades
    /// </summary>
    public partial class FrmStudent : Form
    {
        #region private attributes
        private Student _student = null;//used to store the unique student currently created or modified by the Teacher
        private List<float> _listOfGrades;//used to store the list of grade currently updated, created
        #endregion private attributes

        #region constructors
        /// <summary>
        /// This method (constructor) is designed 
        /// to create a new FrmStudent
        /// Parameter : no parameter is requiered
        /// Return : a new Average Form - empty (to create a brand new student
        /// </summary>
        public FrmStudent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method (constructor) is designed 
        /// to create a new FrmStudent
        /// Parameter : a Student Object (not null)
        /// Return : a new Average Form filled with an existing student to update
        /// </summary>
        public FrmStudent(Student student)
        {
            InitializeComponent();
            //to do, add a try and catch to manage a "null" student
            _student = student;       
        }
        #endregion constructors

        #region accessors and mutators (for unit test)
        /// <summary>
        /// This method is designed to return the current student object.
        /// Usage sample : access possible to a parent form calling in modal this student form
        /// </summary>
        public Student student
        {
            get { return this._student; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "add grade" buttton
        /// </summary>
        public bool cmdAddGradeStatus
        {
            get { return this.cmdAddGrade.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "update grade" buttton
        /// </summary>
        public bool cmdUpdateGradeStatus
        {
            get { return this.cmdUpdateGrade.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "remove grade" buttton
        /// </summary>
        public bool cmdRemoveGradeStatus
        {
            get { return this.cmdRemoveGrade.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "confirm" buttton which save the user input
        /// </summary>
        public bool cmdConfirmStatus
        {
            get { return this.cmdConfirm.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "cancel" buttton which close the form without saving user input
        /// </summary>
        public bool cmdCancelStatus
        {
            get { return this.cmdCancel.Enabled; }
        }
        #endregion accessors and mutators (for unit test)

        #region GUI events
        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "load"
        /// </summary>
        private void frmStudent_Load(object sender, EventArgs e)
        {
            updateGUI();
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the picture box "studentFace"
        /// </summary>
        private void pcbStudentStudentFace_Click(object sender, EventArgs e)
        {
            //to do - manage upload new face image for student
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the button "add grade"
        /// </summary>
        private void cmdAddGrade_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the button "update grade"
        /// </summary>
        private void cmdUpdateGrade_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the button "remove grade"
        /// </summary>
        private void cmdRemoveGrade_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'une note", MessageBoxButtons.OKCancel);
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on button "confirm"
        /// to confirm that all user input have to be saved
        /// </summary>
        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            Student stud = new Student(this.txtName.Text, this.txtFirstname.Text);
            this._student = stud;
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on button "cancel"
        /// to cancel all user input and go back to the parent form (average)
        /// </summary>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous l'annulation ?", "Suppression de la saisie", MessageBoxButtons.OKCancel);
        }
        #endregion GUI actions

        #region common private methods
        /// <summary>
        /// This method is designed 
        /// to refresh all control on the GUI
        /// </summary>
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
