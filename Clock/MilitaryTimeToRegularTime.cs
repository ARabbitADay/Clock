using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Clock
{
    public class MilitaryTimeToRegularTime
    {
        public void Clock()
        {
           
            Console.WriteLine("請輸入分:");
            string input = Console.ReadLine();
            int mm = int.Parse(input);
            
            Console.WriteLine("請輸入時:");
            input = Console.ReadLine();
            int hh = int.Parse(input);

            /*Console.WriteLine("請輸入秒");
            input = Console.ReadLine();
            int ss = int.Parse(input);*/
           


            if (mm < 60)
            {

                if (hh < 12)
                {
                    if (hh == 0)
                    {
                        int hh1 = hh;
                        hh1 = 12;
                        String h = String.Format("{0:00}", hh1);
                        String m = String.Format("{0:00}", mm);
                        Console.WriteLine(h + ":" + m + "AM");
                       
                    }
                    else 
                    {
                        /*Console.WriteLine($"{hh}:{mm}");*/
                        String h = String.Format("{0:00}", hh);
                        String m = String.Format("{0:00}", mm);
                        Console.WriteLine(h + ":" + m + "AM");
                    }
                    
                }
                else 
                {
                    if (hh < 24)
                    {
                        String h = String.Format("{0:00}", hh);
                        String m = String.Format("{0:00}", mm);
                        Console.WriteLine(h + ":" + m + "PM");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
            }
            else 
            {
                Console.WriteLine("error");
                
            }
            /* time += ":";

             if (mm < 10)
             {
                 time += "0" + mm;
             }
             else
             {
                 time += mm;
             }
             time += ":";

             if (ss < 10)
             {
                 time += "0" + ss;
             }
             else
             {
                 time += ss;
             }*/


        }

       
    }
}
    
