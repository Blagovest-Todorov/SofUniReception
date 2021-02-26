using System;

namespace StamoMidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int workerOne = int.Parse(Console.ReadLine()); //Worked per hour Studs per employee
            int workerTwo = int.Parse(Console.ReadLine());
            int workerThree = int.Parse(Console.ReadLine());
            int countStud = int.Parse(Console.ReadLine());

            int sumHandledStud = workerOne + workerTwo + workerThree; //PerHourTotalWorked
            int workedHours = 0;
            int restHours = 0;            

            while (true)
            {
                if (countStud <= 0)
                {                   
                    Console.WriteLine($"Time needed: {workedHours + restHours}h.");
                    break;
                }

                workedHours++;
                countStud -= sumHandledStud;

                if (workedHours % 3 == 0 && countStud > 0)
                {
                    restHours++;
                }
            }
        }
    }
}
