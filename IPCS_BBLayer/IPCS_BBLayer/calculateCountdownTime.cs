/*
 * Developed by: Fathima Amra
 * Date: 19/2/2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLApp;

namespace IPCS_BBLayer
{
    public class calculateCountdownTime
    {

        public Tuple<int, int> countdownTime(string iPEnd1, string ipEnd2, string pDistance)
        {
            MLApp.MLApp mFile = new MLApp.MLApp();//Matlab access function through COM mechanism 

            int countdownTime = 0; //Declare variable
            int holdTime = 0;
            int intPDistance = Convert.ToInt32(pDistance);

            //Calling image processing funtion
            string Output = mFile.Execute("PImagePixelCount('" + iPEnd1 + "', '" + ipEnd2 + "')"); 

            //Hide Matlab CP Window
            mFile.Visible = 0;
            mFile.Quit();

            string weightEnd1 = Output.Substring(8, 5);
            string weightEnd2 = Output.Substring(19, 5);

            double dWeightEnd1 = Convert.ToDouble(weightEnd1);
            double dWeightEnd2 = Convert.ToDouble(weightEnd2);

            if (dWeightEnd1 < 0.900 && dWeightEnd2 < 0.900)
            {
                countdownTime = 00;
            }
            else if (31.00 <= dWeightEnd1 || 31.00 <= dWeightEnd2)
            {
                if (intPDistance <= 10)
                {
                    countdownTime = 15;
                }
                else if (11 <= intPDistance || intPDistance <= 15)
                {
                    countdownTime = 20;
                }
                else if (intPDistance >= 20)
                {
                    countdownTime = 25;
                }
            }
            else if ((21.00 <= dWeightEnd1 && dWeightEnd1 < 30.99) || (21.00 <= dWeightEnd2 && dWeightEnd2 < 30.99))
            {
                if (intPDistance <= 10)
                {
                    countdownTime = 12;
                }
                else if (11 <= intPDistance || intPDistance <= 15)
                {
                    countdownTime = 16;
                }
                else if (intPDistance >= 20)
                {
                    countdownTime = 20;
                }
            }
            else if ((11.00 <= dWeightEnd1 && dWeightEnd1 < 20.99) || (11.00 <= dWeightEnd2 && dWeightEnd2 < 20.99))
            {
                if (intPDistance <= 10)
                {
                    countdownTime = 09;
                }
                else if (11 <= intPDistance || intPDistance <= 15)
                {
                    countdownTime = 12;
                }
                else if (intPDistance >= 20)
                {
                    countdownTime = 15;
                }

                holdTime = 30;

            }
            else if ((1.000 <= dWeightEnd1 && dWeightEnd1 < 10.99) || (1.000 <= dWeightEnd2 && dWeightEnd2 < 10.99))
            {
                if (intPDistance <= 10)
                {
                    countdownTime = 06;
                }
                else if (11 <= intPDistance || intPDistance <= 15)
                {
                    countdownTime = 08;
                }
                else if (intPDistance >= 20)
                {
                    countdownTime = 10;
                }

                holdTime = 60;

            }
            
            return Tuple.Create(countdownTime, holdTime);

        }

    }
}
