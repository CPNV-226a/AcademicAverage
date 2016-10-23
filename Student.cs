using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPNV
{
    /// <summary>
    /// This class is designed
    /// to manage student in an academic average application
    /// </summary>
    public class Student
    {
        #region private attributes
        private string _name = "";//used to store the student's name
        private string _firstname = "";//used to store the student's firstname
        private List<float> _listOfGrades = null;//used to store all grades attributed to the student
        private float _average = 0;//used to store the current student's average (based on the list of grades)
        #endregion private attributes

        /// <summary>
        /// This method (constructor) is designed 
        /// to create a new Student Object
        /// Parameter : the student's name as string, the student's firstname as a string
        /// Return : a Student
        /// </summary>
        #region constructors
        public Student(string name, string firstname)
        {
            _name = name;
            _firstname = firstname;
            _listOfGrades = new List<float>();
        }
        #endregion constructors

        #region accessors and mutators
        /// <summary>
        /// This method is designed
        /// to get access in read only to the value "name".
        /// </summary>
        public string name
        {
            get { return this._name; }
        }

        /// <summary>
        /// This method is designed
        /// to get access in read only to the value "firstname".
        /// </summary>
        public string firstname
        {
            get { return this._firstname; }
        }

        /// <summary>
        /// This method is designed
        /// to get access in read only to the value "listOfGrades".
        /// </summary>
        public List<float> listOfGrades
        {
            get { return this._listOfGrades; }
        }

        /// <summary>
        /// This method is designed
        /// to get access in read only to the value "average".
        /// </summary>
        public float average
        {
            get { return this._average; }
        }

        /// <summary>
        /// This method is designed
        /// to get access in read only to the value "firstname".
        /// This is an override of the standard accessor "ToString"
        /// </summary>
        public override string ToString()
        {
            return this._name + "-" + this._firstname + "-" + this.average.ToString();
        }
        #endregion accessors and mutators

        #region public methodes
        /// <summary>
        /// This method is designed
        /// to add a grade to add a grade to a list of grade
        /// Parameter : we receive a float representing the garde to add
        /// Return : no return, but during the process, we add the garde to a listOfGrades (private member)
        /// </summary>
        public void addGrade(float grade)
        {
            //we add the grade received as parameter to the local member "listOfGrades"
            this._listOfGrades.Add(grade);
            //we call the private method "updateAverage" to refresh the student average
            updateAverage(this._listOfGrades);
        }
        #endregion public methodes

        #region private methodes
        /// <summary>
        /// This method is designed
        /// to update the average of the student
        /// Parameter : we receive a float representing the garde to add
        /// Return : no return, but during the process, we update the average of the student (private member this._average)
        /// </summary>
        private void updateAverage(List<float> listOfGrades)
        {
            //we initialize a temporary variable to store the average
            float averageCalculated = 0;

            //we check if the listOfGrades contains at least one garde
            if (listOfGrades != null)
            {
                //if yes
                //we initialize a ListTools helping us to calculate the average directly by passing the list of grades (float)
                ListTools lstTools = new ListTools();
                //we get the sum of the float list and store it in the temporarly variable "averageCalculated"
                averageCalculated = lstTools.averageList(listOfGrades);
            }
            //no specific action if the list is empty
            //we set the private membre "average" either with 0 (meaning average no calculated) or with the result obtained by the ListTools Object
            this._average = averageCalculated;
        }
        #endregion private methodes
    }
}
