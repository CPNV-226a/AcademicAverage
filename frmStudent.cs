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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void pcbStudentFace_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'une note", MessageBoxButtons.OKCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Confirmez-vous l'annulation ?", "Suppression de la saisie", MessageBoxButtons.OKCancel);
        }

        private void cmdAddGrade_Click(object sender, EventArgs e)
        {
            frmGradesInput frmManageMark = new frmGradesInput();
            
            frmManageMark.ShowDialog(this);
        }

        #region common private methods
        //private openFrmGrade()
        //{

        //}

        #endregion common private methods

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
