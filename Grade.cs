using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPNV
{
    public class Grade
    {
        #region private attributes
        private float _grade = 0;
        #endregion private attributes

        #region constructors
        public Grade(float grade)
        {
            _grade = grade;
        }
        #endregion construtors

        #region accessors and mutators
        public float value
        {
            get
            {
                return this._grade;
            }
        }
        #endregion accessors and mutators
    }
}
