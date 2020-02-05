using System;

namespace pracExamWeek3
{
    class wpracExamweek3
    {
        static void Main(string[] args)
        {

            int choice = 0;


            switch (Choice(choice))
            {
                case 1:  
                    Console.WriteLine("total: {0}", CalculateQuote(0));
                    break;
                    /*case 2:
                        PrintStatistics();
                        break;
                    case 3:
                        Exit();
                        break;*/
            }
        }

        static int Choice(int choice)
        {



            Console.WriteLine("Enter Choice: ");
            choice = int.Parse(Console.ReadLine());

            return choice;





        }
        static decimal CalculateQuote(decimal total)
        {
            decimal vehicleValue = 0m;
            string gender;
            int age;
            int penaltyPoints = 0;
            const decimal BASIC_PREMIUM = 0.03m;
            const decimal PENALTY1 = 100m;
            const decimal PENALTY2 = 200m;
            const decimal PENALTY3 = 300m;
            const decimal PENALTY4 = 400m;

            Console.Write("Enter Vehicle Value: ");
            vehicleValue = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Gender: ");
            gender = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Penalty Points: ");
            penaltyPoints= int.Parse(Console.ReadLine());



            total = vehicleValue * BASIC_PREMIUM;

            if (penaltyPoints >= 1 && penaltyPoints < 5)
                total = total + PENALTY1;
            else if (penaltyPoints >= 5 && penaltyPoints < 8)
                total = total + PENALTY2;
            else if (penaltyPoints >= 8 && penaltyPoints < 11)
                total = total + PENALTY3;
            else if (penaltyPoints >= 11 && penaltyPoints < 13)
                total = total + PENALTY4;
            else if (penaltyPoints > 12)
                Console.WriteLine("No Quote Possible");

            return total;

        }

        /*static int PrintStatistics()
        {

        }
        static int Exit()
        {

        }*/






    }
}
