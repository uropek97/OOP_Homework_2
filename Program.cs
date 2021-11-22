using System;

namespace OOP_Homework_2
{

    class Program
    {
        static void Main(string[] args)
        {
            string file = @"NumberAcc.txt";
            Files.CreateFail(file);
            BankAcc a = new BankAcc();
            a.SetNumberAcc(file);
            a.PutInBalance();
            a.ChooseType();
            Console.WriteLine("___________________________________");
            a.Display();
            Console.WriteLine("___________________________________");
            a.DisplayBalance();
            Console.WriteLine("___________________________________");
            a.DisplayNumbAcc();
            Console.WriteLine("___________________________________");
            a.DisplayType();

            Console.ReadLine();
        }

    }
}
