using System;
using System.Collections;

/// <summary>
/// 只能对普通账户进行存取钱操作
/// </summary>
public class ATM : IShowAndGetInput
{

    Bank bank;
    public ATM(Bank bank)
    {
        this.bank = bank;
    }

    public void ATMTransaction()
    {
        Account account = FindAccount();

        if (account != null)
        {
            Show("1: display; 2: save; 3: withdraw");
            string op = GetInput();

            if (op == "1")
            {
                Show("balance: " + account.Money);
            }
            else if (op == "2")
            {
                Show("save money");
                string strMoney = GetInput();
                double money = double.Parse(strMoney);

                bool ok = account.SaveMoney(money);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + account.Money);
            }
            else if (op == "3")
            {
                Show("withdraw money");
                string strMoney = GetInput();
                double money = double.Parse(strMoney);

                bool ok = account.WithdrawMoney(money);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + account.Money);
            }
            else
                Show("eeer");
        }
    }

    private Account FindAccount()
    {
        Account account;
        Show("please insert your name or id");
        string id = GetInput();
        Show("please enter your password");
        string pwd = GetInput();

        account = bank.FindAccount(id, pwd, "1");
        if (account == null)
            Show("card invalid or password not corrent");

        return account;
    }

    private void ATMService(Account account)
    {
        Show("1: display; 2: save; 3: withdraw");
        string op = GetInput();

        if (op == "1")
        {
            Show("balance: " + account.Money);
        }
        else if (op == "2")
        {
            Show("save money");
            string strMoney = GetInput();
            double money = double.Parse(strMoney);

            bool ok = account.SaveMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + account.Money);
        }
        else if (op == "3")
        {
            Show("withdraw money");
            string strMoney = GetInput();
            double money = double.Parse(strMoney);

            bool ok = account.WithdrawMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + account.Money);
        }
        else
            Show("eeer");
    }


    public void Show(string message)
    {
        Console.WriteLine(message);
    }
    public string GetInput()
    {
        return Console.ReadLine();
    }
}
