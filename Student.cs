using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPNV
{
    public class Student
    {
        #region private attributes
        private string _name = "";
        private string _firstname = "";
        private List<float> _listOfGrades = null;
        private float _average = 0;
        #endregion private attributes

        #region constructors
        public Student(string name, string firstname)
        {
            _name = name;
            _firstname = firstname;
            _listOfGrades = new List<float>();
        }
        #endregion constructors

        #region accessors and mutators
        public string name
        {
            get { return this._name; }
        }

        public string firstname
        {
            get { return this._firstname; }
        }

        public List<float> listOfGrades
        {
            get { return this._listOfGrades; }
        }

        public float average
        {
            get { return this._average; }
        }
        #endregion accessors and mutators

        #region public methodes
        public void addGrade(float grade)
        {
            this._listOfGrades.Add(grade);
            updateAverage(this._listOfGrades);
        }
        #endregion public methodes

        #region private methodes
        private void updateAverage(List<float> listOfGrades)
        {
            List<float> listOfGradesToCalculateAverage = listOfGrades;
            float averageCalculated = 0;

            if (listOfGradesToCalculateAverage != null)
            {
                //we get the sum of the float list
                ListTools lstTools = new ListTools();
                averageCalculated = lstTools.averageList(listOfGrades);
            }
            this._average = averageCalculated;
        }
        #endregion private methodes
    }
}
