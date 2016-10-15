using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPNV
{
    public class ListTools
    {
        #region public methodes
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
        #endregion public methods
    }
}
