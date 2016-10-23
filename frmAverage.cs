using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPNV
{
    /// <summary>
    /// This class is designed
    /// to be the entry point and the main display
    /// of a application helping a Teacher to manage
    /// its classmate, specifically the student academic average
    /// </summary>
    public partial class FrmAverage : Form
    {
        #region private attributes
        private List<Student> _listOfStudents;//used to store all students currently used by the application
        private Student _studentSelectedBeforeUpdate;//used to store a student before a modification request
        private ListTools lstTools;//used to manipulated lists
        #endregion private attributes

        #region contructors
        /// <summary>
        /// This method (constructor) is designed 
        /// to create a new FrmAverage
        /// Parameter : no parameter is requiered
        /// Return : a new Average Form
        /// </summary>
        public FrmAverage()
        {
            InitializeComponent();
        }
        #endregion constructors

        #region accessors and mutators (for unit test)
        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "add student" buttton
        /// </summary>
        public bool cmdAddStudentStatus
        {
            get { return this.cmdAddStudent.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "add student" menu item
        /// </summary>
        public bool mnuItemAddStudentStatus
        {
            get { return this.mnuItemAdd.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "update student" buttton
        /// </summary>
        public bool cmdUpdateStudentStatus
        {
            get { return this.cmdUpdateStudent.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "update student" menu item
        /// </summary>
        public bool mnuItemUpdateStudentStatus
        {
            get { return this.mnuItemUpdate.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "remove student" buttton
        /// </summary>
        public bool cmdRemoveStudentStatus
        {
            get { return this.cmdRemoveStudent.Enabled; }
        }

        /// <summary>
        /// This method is designed
        /// for unit test. We return the status of the "remove student" menu item
        /// </summary>
        public bool mnuItemRemoveStudentStatus
        {
            get { return this.mnuItemRemove.Enabled; }
        }
        #endregion accessors and mutators (for unit test)

        #region GUI events
        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "load"
        /// </summary>
        private void frmOverview_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the button "add student"
        /// </summary>
        private void cmdAddStudent_Click(object sender, EventArgs e)
        {
            //we open the student form. The parameter is set to null because we do not update an existing student.
            openFrmStudentInModale(null);
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the menu item "add student"
        /// </summary>
        private void mnuItemAdd_Click(object sender, EventArgs e)
        {
            //we open the student form. The parameter is set to null because we do not update an existing student.
            openFrmStudentInModale(null);
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the button "update student"
        /// </summary>
        private void cmdUpdateStudent_Click(object sender, EventArgs e)
        {
            //we call the method studentUpdateProcess responsible to find the student to update and to open the student form
            studentUpdateProcess();
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the menu item "add student"
        /// </summary>
        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            //we call the method studentUpdateProcess responsible to find the student to update and to open the student form
            studentUpdateProcess();
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the button "remove student"
        /// </summary>
        private void cmdRemove_click(object sender, EventArgs e)
        {
            //we call the method studentRemoveProcess resposible to find the student to remove
            studentRemoveProcess();
        }

        /// <summary>
        /// This method is designed 
        /// to execute some actions after the event "click" on the menu item "remove student"
        /// </summary>
        private void mnuItemRemove_Click(object sender, EventArgs e)
        {
            //we call the method studentRemoveProcess resposible to find the student to remove
            studentRemoveProcess();
        }

        /// <summary>
        /// This method is designed 
        /// to detect all changes of index on the list box "lsbStudents"
        /// </summary>
        private void lsbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set the average form to manage all features (add, update and remove student)
            setControlsAllFeatures();
        }
        #endregion GUI events

        #region Common actions after events
        /// <summary>
        /// This method is designed
        /// to set all form's controls
        /// Only the feature "add new student" will be enable
        /// </summary>
        private void setControlsOnlyNew()
        {
            cmdUpdateStudent.Enabled = false;
            cmdUpdateStudent.Image = Properties.Resources.Croix_rouge_disable;
            cmdRemoveStudent.Enabled = false;
            cmdRemoveStudent.Image = Properties.Resources.Croix_rouge_disable;

            mnuItemUpdate.Enabled = true;
            mnuItemRemove.Enabled = true;
        }

        /// <summary>
        /// This method is designed
        /// to set all form controls
        /// All features "add, update and remove" will be enable
        /// </summary>
        private void setControlsAllFeatures()
        {
            cmdUpdateStudent.Enabled = true;
            cmdUpdateStudent.Image = null;
            cmdRemoveStudent.Enabled = true;
            cmdRemoveStudent.Image = null;

            mnuItemUpdate.Enabled = true;
            mnuItemRemove.Enabled = true;
        }

        /// <summary>
        /// This method is designed
        /// to manage the update process used to modify an
        /// existing student.
        /// -we detect the selected student in the list box
        /// -we initialize a student object containing the selected student
        /// -we store the current status of the object (before update process)
        /// -we call the student form to help the user to update the student data
        /// </summary>
        private void studentUpdateProcess()
        {
            //initialization of a ListTools to access to the specifis methods design for the lists
            lstTools = new ListTools();
            //the user selected a student in the list. We have to find the correct student in the list to update it.
            //the "findStuduentInList" is able, from a student (as a string) to find the correct student in the students list
            Student stuSelected = lstTools.findStudentInList(this._listOfStudents, this.lsbStudents.SelectedItem.ToString());
            //we store the current status of the student. StudentSelectedBeforeUpdate will be used to remove the old version of the student before update.
            this._studentSelectedBeforeUpdate = stuSelected;
            //we open the form "Student" displaying the student to update.
            openFrmStudentInModale(stuSelected);
        }

        /// <summary>
        /// This method is designed
        /// to open the form Student
        /// If the parameter "student" is different as null, it's mean that the user
        /// wants to udpate an existing student. Otherwise his intention is to add
        /// a new student in the application.
        /// </summary>
        private void openFrmStudentInModale(Student stu)
        {
            FrmStudent frmStudent;

            //either
            if (stu != null)
            {
                //we update an existing student (stu). The student form will display the student to update
                frmStudent = new FrmStudent(stu);
            }
            else
            {
                //or we add a new user (the student form will be empty just after being loaded)
                frmStudent = new FrmStudent();
            }
            
            //if the user confirm the modification, we have to update the form student as well as the list of students
            if (frmStudent.ShowDialog(this) == DialogResult.OK)
            {
                //remove student send by parameter to avoid duplicate (in case of name update, we will not be able any more to find it in the student list)
                if(this._studentSelectedBeforeUpdate != null)
                {
                    //we remove the "old" version of the student currently updated
                    this._listOfStudents.Remove(this._studentSelectedBeforeUpdate);
                    //we set to null the temporary variable used to remove the "old" version of the student currently updated
                    this._studentSelectedBeforeUpdate = null;
                }
               
                //we add the updated student to the list (to avoid exception, we check the student object before (is not null)
                if(frmStudent.student != null)
                {
                    addStudentInList(frmStudent.student);
                }           
            }
        }

        /// <summary>
        /// This method is designed
        /// to manage the remove process of an
        /// existing student.
        /// -we detect the selected student in the list box
        /// -we initialize a student object containing the selected student
        /// -we call the remove method sending the stuSelected as parameter
        /// </summary>
        private void studentRemoveProcess()
        {
            //initialization of a ListTools to access to the specifis methods design for the lists
            lstTools = new ListTools();
            //the user selected a student in the list. We have to find the correct student in the list in order to remove it.
            //the "findStuduentInList" is able, from a student (as a string) to find the correct student in the students list
            Student stuSelected = lstTools.findStudentInList(this._listOfStudents, this.lsbStudents.SelectedItem.ToString());
            //we call the method "removeStudent" and sending the stuSelected as parameter
            removeStudent(stuSelected);
        }

        #region manage listBox
        /// <summary>
        /// This method is designed
        /// to add a student to the application.
        /// -we receive as parameter the student to add (newStudent)
        /// -if it's a first student of the application, we have to initialize the list of students
        /// -we add the student to the list
        /// -we call the "updateGUI" in order to display an updated list of students in the average form
        /// </summary>
        private void addStudentInList(Student newStudent)
        {
            //we initialize a "local" student containing the student to add
            Student stu = newStudent;
            //we test if the list of student already exists
            if (this._listOfStudents == null)
            {
                //we initialize the list of student
                this._listOfStudents = new List<Student>();
            }
            //we add the new student
            this._listOfStudents.Add(stu);
            //we call the method "updateGUI" in order to update the average form
            updateGUI(this._listOfStudents);
        }

        /// <summary>
        /// This method is designed
        /// to remove an existing student from the application.
        /// We receive as parameter the student to remove (stuToRemove)
        /// If the user confirmes the remove action
        /// -we find the correct student to remove in the list of students
        /// -we remove it (creating a new list of students containing all students except the student to remove)
        /// -we update the list of students with the updated list of students just created
        /// -we call the "updateGUI" in order to display an updated list of students in the average form
        /// </summary>
        private void removeStudent(Student stuToRemove)
        {
            //we declare a list of student in order to store the new version of the list needed by the application
            List<Student> listOfStudentsUpdated = null;

            //we open the dialog windows given the choice to the user to confirme or to disapprove the removing of the selected student
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression de " + stuToRemove.name + " " + stuToRemove.firstname, MessageBoxButtons.OKCancel);

            //if the user confirme the remove action
            if (dialogResultDelete == DialogResult.OK)
            {
                //we try to find the concerned student in the list of students
                foreach (Student student in this._listOfStudents)
                {
                    //by name
                    if (stuToRemove.name != student.name)
                    {
                        //we add to the new list all student having a different name as the student to remove
                        if (listOfStudentsUpdated == null)
                        {
                            //if it's the first student to add, we have to initialize the new list of students
                            listOfStudentsUpdated = new List<Student>();
                        }
                        //then we add the student
                        listOfStudentsUpdated.Add(student);
                    }
                }
            }
            //we update the local listOfStudents
            this._listOfStudents = listOfStudentsUpdated;
            //and call the updateGUI to refresh the average form
            updateGUI(this._listOfStudents);
        }
        #endregion manage listBox

        /// <summary>
        /// This method is designed
        /// to update the average form
        /// We receive as parameter a list of students to be appeared/displayed in the GUI
        /// If the list of student isn't empty (null), means we just lauch the application or we just remove the last existing student
        /// -we clean the existing list
        /// -we add each student from the list of students in the students list box
        /// -we clean the selected index
        /// -we call the method "setControlsOnlyNew" to set the control as expected (only the feature new because no student is selected)
        /// </summary>
        private void updateGUI(List<Student> listOfStudents)
        {
            //we check if the list of students is not empty (null)
            if (listOfStudents != null)
            {
                //we clean the list box
                this.lsbStudents.Items.Clear();
                //we parse all students present in the listOfStudents
                foreach (Student stu in listOfStudents)
                {
                    //we add the current student to the student list box
                    this.lsbStudents.Items.Add(stu.ToString());
                    //we set the index selected to disable any selection
                    this.lsbStudents.ClearSelected();
                }
            }
            //there aren't any students in the application
            else
            {
                //we just clean the students list box
                this.lsbStudents.Items.Clear();
                
            }
            //we call the method "setControlsOnlyNew" because no student is selected in the list box
            setControlsOnlyNew();
        }

        #endregion Common actions after events
    }
}
