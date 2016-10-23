using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPNV
{
    /// <summary>
    /// This class is designed
    /// to manipulate lists (sum, average)
    /// </summary>
    public class ListTools
    {
        #region public methodes
        /// <summary>
        /// This method is designed
        /// to return the sum of a floats list
        /// We receive as parameter a list of floats
        /// -we check if the list is not empty
        /// -if the list isn't empty (null)
        /// -we parse each item contained in the list
        /// -and we get the sum as answer
        /// </summary>
        public float sumList(List<float> listOfFloat)
        {
            float sum = 0;

            if (listOfFloat != null)
            {
                foreach (float f in listOfFloat)
                {
                    sum += f;
                }
            }
            return sum;
        }

        /// <summary>
        /// This method is designed
        /// to return the average of a floats list
        /// We receive as parameter a list of floats
        /// -we check if the list is not empty
        /// -if the list isn't empty (null)
        /// -we calculated the sum and the amount of item contained in the list
        /// -and we get the average as answer
        /// </summary>
        public float averageList(List<float> listOfFloat)
        {
            float average = 0;
            float sum = 0;
            int nbOfItemInList = 0;

            if (listOfFloat != null)
            {
                nbOfItemInList = listOfFloat.Count;
                if (nbOfItemInList > 0)
                {
                    sum = sumList(listOfFloat);
                    average = sum / nbOfItemInList;
                }
            }
            return average;
        }

        /// <summary>
        /// This method is designed
        /// to find an existing student in the listOfStudents.
        /// We receive as parameter a student string (stuSelected) coming for the list box (user's choice)
        /// -we find the correct student to in the list of students
        /// -we return the found student
        /// -if the student wasn't found, we return "null"
        /// to do - protection agains duplicate
        /// </summary>
        public Student findStudentInList(List<Student> listOfStudents, string studentSelected)
        {
            //we try to find a student in the list of students having the same name as the student selected by the user in the students list box
            foreach (Student stu in listOfStudents)
            {
                //we receive a string containg the name, firstname and average. To compare only the name, we have to extract it.
                //we get the name lenght of the student to find
                int nameLength = stu.name.Length;
                //we extract only the name
                string studentNameSelected = studentSelected.Substring(0, nameLength);
                //and we test the name extracted with the name of the current student selected in the list of students
                if (studentNameSelected == stu.name)
                {
                    //if we find it, we return the student expected
                    return stu;
                }
            }
            //if after parsing all the list of students we did not find the student, we return "null" meaning "student not find"
            return null;
        }
        #endregion public methods
    }
}
