using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStuedet = 3;
            int numberOfSubjsc = 5;
            int[,] marks = new int[,] { { 1, 2, 3, 4, 5 }, { 2, 1, 3, 4, 1 }, { 2, 5, 4, 1, 3 } };

            Console.WriteLine("Subject: " + 5 + " marks: " + string.Join(",", MarksOfStudent(numOfStuedet, numberOfSubjsc, marks)));

            Console.ReadLine();
        }

        public static int[] MarksOfStudent(int input1, int input2, int[,] input3)
        {
            int firstSubjectotal = 0;
            int subjectIndex = -1;

            for (int i = 0; i < input2; i++)
            {
                int subjectSum = 0;

                for (int j = 0; j < input1; j++)
                {
                    subjectSum = subjectSum + input3[j, i];
                }

                if (subjectSum < firstSubjectotal || firstSubjectotal == 0)
                {
                    firstSubjectotal = subjectSum;
                    subjectIndex = i;
                }
            }

            int[] studentMarks = new int[input1];

            for (int i = 0; i < input1; i++)
            {
                int fma = 0;

                for (int j = 0; j < input2; j++)
                {
                    if (subjectIndex != j)
                    {
                        fma = fma + input3[i, j];
                    }
                }

                studentMarks[i] = fma;
            }

            return studentMarks;
        }
    }
}
