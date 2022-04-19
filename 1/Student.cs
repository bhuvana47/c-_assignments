using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    using System;
    using System.Collections.Generic;
    class Student
    {
        static void getStudentsList(string[] file)
        {
            int avgScore;
            int maxAvgScore = Int32.MinValue;
            List<string> names = new List<string>();
            for (int i = 0; i < file.Length; i += 4)
            {
                avgScore = (Int32.Parse(file[i + 1]) +
                            Int32.Parse(file[i + 2]) +
                        Int32.Parse(file[i + 3])) / 3;

                if (avgScore > maxAvgScore)
                {
                    maxAvgScore = avgScore;
                    names.Clear();
                    names.Add(file[i]);
                }

                else if (avgScore == maxAvgScore)
                    names.Add(file[i]);
            }


            for (int i = 0; i < names.Count; i++)
            {
                Console.Write(names[i] + " ");
            }

            Console.WriteLine(maxAvgScore);
        }

        public static void Main()
        {
            string[] file = { "ganesh", "100", "50", "10", "Satish", "72", "48", "98", "Jan", "97", "65", "93", "qwe", "67", "79", "65" };
            getStudentsList(file);
        }
    }

}
