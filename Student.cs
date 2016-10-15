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
        private List<Grade> _listOfGrades = null;
        private float _average = 0;
        #endregion private attributes

        #region constructors
        public Student(string name, string firstname)
        {
            _name = name;
            _firstname = firstname;
            _listOfGrades = new List<Grade>();
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

        public List<Grade> listOfGrades
        {
            get { return this._listOfGrades; }
        }
        #endregion accessors and mutators

        #region public methodes
        public void addGrade(Grade grade)
        {
            this._listOfGrades.Add(grade);
        }
        #endregion public methodes

        #region private methodes
        private float average(List<float> listOfGrades)
        {
            List<float> listOfGradesToCalculateAverage = listOfGrades;
            float averageCalculated = 0;

            if (listOfGradesToCalculateAverage != null)
            {
                foreach (float garde in listOfGradesToCalculateAverage)
                {

                }
            }

            return averageCalculated;
        }
        #endregion private methodes
    }
}
