using System;
using System.Collections;

public class BankDemo
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        bank.OpenAccount("1111", "һ���˻�", "1111", 10, "1");
        bank.OpenAccount("2222", "�����˻�", "2222", 20, "1");
        bank.OpenAccount("3333", "���������˻�", "3333", 50, "2");
        bank.OpenAccount("4444", "�ĺ������˻�", "4444", 100, "2");

        for(int i=0;i<5;i++)
        {
            Console.WriteLine("\nPlease select a service\n" +
                                "1: ATM; 2: BankCounter; ");
            string op = Console.ReadLine();
            if (op == "1")
            {
                ATM atm = new ATM(bank);
                atm.ATMTransaction();
            }
            else if (op == "2")
            {
                BankCounter BankC = new BankCounter(bank);
                BankC.BCTransaction();
            }
            else
                Console.WriteLine("eeer");
        }
    }
}
