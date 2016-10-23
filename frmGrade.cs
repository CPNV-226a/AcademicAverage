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
    public partial class FrmGrade : Form
    {
        #region private attributes
        private float _gradeInput = 0;
        #endregion private attributes


        #region constructors
        public FrmGrade()
        {
            InitializeComponent();
        }

        public FrmGrade(float grade)
        {
            InitializeComponent();
            this._gradeInput = grade;
        }
        #endregion constructors

        #region accessors and mutators
        public float grade
        {
            get { return this._gradeInput;}
        }
        #endregion accessors and mutators

        #region IHM events
        private void frmGradesInput_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numGradeDecimal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        #endregion IHM events
    }
}
