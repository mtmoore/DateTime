

// Output

/*
Adding 5 bob to 24 hours
Result is Invalid 1st input ending now
*/

/*
Adding 5 minute to 24 hours
Result is Invalid use of singular - use plural in 1st value.Ending Now
*/

/*
Adding 5 minutes to 24 hours
Result is 1445 Minutes
*/

/*
Adding 5 minutes to 5 days
Result is 7205 Minutes
*/

/*
Adding 60 seconds to 5 days
Result is 7201 Minutes
*/


using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
        static object[] timeAdder(int value1, string label1, int value2, string label2)
            {
                object[] array = new object[2];

                int value1seconds = 0;
                int value2seconds = 0;
                double value3minutes = 0;

                label1 = label1.ToLower();
                label2 = label2.ToLower();

                if (label1 != "second" && label1 !="seconds" && label1 !="minutes" && label1 != "minute" && label1 !="hour" && label1 !="hours" && label1 !="day" && label1 !="days")
                {
                    array[0] = "Invalid ";
                    array[1] = "1st input ending now";
                    
                    return array;

                }
                if (label1 == "second" || label1 == "minute" || label1 == "hour" || label1 == "day" )
                {
                    if (value1 !=1)
                        {
                        array[0] = "Invalid use of";
                        array[1] = " singular - use plural in 1st value.  Ending Now";
                        return array;
                    }
                }
                if (label2 != "second" && label2 != "seconds" && label2 != "minutes" && label2 != "minute" && label2 != "hour" && label2 != "hours" && label2 != "day" && label2 != "days")
                {
                    array[0] = "Invalid ";
                    array[1] = "2nd input ending now";
                    return array;

                }
                if (label2 == "second" || label2 == "minute" || label2 == "hour" || label2 == "day")
                {
                    if (value2 != 1)
                    {
                        array[0] = "Invalid use of";
                        array[1] = " singular - use plural in 2nd value.  Ending Now";
                        return array;
                    }
                }

                // convert value 1 into seconds

                if (label1 == "seconds")
                {
                    value1seconds = Math.Abs(value1);
                }
                else if (label1 == "minutes")
                {
                    value1seconds = Math.Abs(value1) * 60;
                }
                else if (label1 == "hours")
                {
                    value1seconds = (Math.Abs(value1) * 60) * 60;
                }
                else if (label1 == "days")
                {
                    value1seconds = (Math.Abs(value1) * 24) * 60 * 60;
                }
               


                // convert value 2 into seconds

                if (label2 == "seconds")
                {
                    value2seconds = Math.Abs(value2);
                }
                else if (label2 == "minutes")
                {
                    value2seconds = Math.Abs(value2 * 60);
                }
                else if (label2 == "hours")
                {
                    value2seconds = (Math.Abs(value2) * 60) * 60;
                }
                else if (label2 == "days")
                {
                    value2seconds = (Math.Abs(value2) * 24) * 60 * 60;
                }

              


                double totalMinutes = ((value1seconds + value2seconds) / 60);
                
                value3minutes = Math.Round(totalMinutes, 0, MidpointRounding.ToEven);

                array[0] = Convert.ToInt32(value3minutes);
                array[1] = " Minutes";
                return array;

            }
            int val1 = 60;
            string lab1 = "seconds";
            int val2 = 5;
            string lab2 = "days";

            Console.WriteLine("Adding " + val1 + " " + lab1 + " to " + val2 + " " + lab2);
                object[] result = timeAdder(val1, lab1, val2, lab2);

                Console.WriteLine("Result is "+result[0]+""+result[1]);
            

            
        }
    }
}
