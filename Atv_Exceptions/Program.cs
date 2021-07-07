using System;
using System.Globalization;
using Atv_Exceptions.Entidades;
using Atv_Exceptions.Entidades.Exceçoes;

namespace Atv_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data :");
                Console.Write("Number : ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder : ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance : ");
                double initalbalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit : ");
                double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initalbalance, withdrawlimit);
                Console.Write("Enter amount for withdraw : ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.withdraw(amount);

                Console.Write("New Balance " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error "+ e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format Erro " +e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error " +e.Message);
            }
        }
    }
}
