using System;
using System.Collections;

/// <summary>
/// 模拟银行，用户可选ATM或银行柜台来进行操作
/// </summary>
public class BankDemo
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        bank.OpenAccount("1111", "一号账户", "1111", 10, "1");
        bank.OpenAccount("2222", "二号账户", "2222", 20, "1");
        bank.OpenAccount("3333", "三号信用账户", "3333", 50, "2");
        bank.OpenAccount("4444", "四号信用账户", "4444", 100, "2");

        for (int i = 0; i < 5; i++)
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
                BankCounter bankCounter = new BankCounter(bank);
                bankCounter.BankCounterTransaction();
            }
            else
                Console.WriteLine("eeer");
        }
    }
}
