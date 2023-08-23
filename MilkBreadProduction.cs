using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkAndBreadCL
{
    public class MilkBreadProduction
    {
        private static MilkBread fac = new MilkBread();
        List<MilkBread> Factory = new List<MilkBread>();

        private static int iSize = 0;

        public void addToArray(String ID, String strProductName, String Date, String BBdate, String BatchNumber)
        {
            Factory.Add(new MilkBread(ID, strProductName, Date, BBdate, BatchNumber));
            iSize++;
        }

        public MilkBread search(String ID)
        {
            MilkBread output = new MilkBread();
            for (int i = 0; i < iSize; i++)
            {
                MilkBread Temp = Factory[i];
                if ((string)Temp["ID"] == ID) // if ((string)Factory[x]["ID"]==ID)
                {
                    output = Temp;
                }
            }
            return output;
        }
    }
}
