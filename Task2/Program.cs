using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            switch (month)
            {
                case "Yanvar":
                case "Mart":
                case "May":
                case "Iyul":
                case "Avqust":
                case "Oktyabr":
                case "Dekabr":
                    Console.WriteLine("Bu ayda 31 gune beraberdir");
                    break;

                case "Aprel":
                case "iyun":
                case "Sentyabr":
                case "Noyabr":
                    Console.WriteLine("Bu ayda 30 gun var");
                    break;

                case "Fevral":
                    Console.WriteLine("Bu ayda 28 gun var");
                    break;
                default:
                    Console.WriteLine("Bele ay yoxdur");
                    break;
            }
        }
    }
}
