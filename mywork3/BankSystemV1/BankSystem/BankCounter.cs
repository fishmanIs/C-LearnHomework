using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 可对信用账户进行所有操作，对普通账户仅开户销户
/// </summary>
public class BankCounter: IShowAndGetInput
{
    Bank bank;
    public BankCounter(Bank bank)
    {
        this.bank = bank;
    }

    public void BankCounterTransaction()
    {
        Show("\n1: MoneyService; 2: AccountService;");
        string op = GetInput();

        if (op == "1")
        {
            MoneyService();
        }
        else if (op == "2")
        {
            AccountService();
        }
    }

    private void MoneyService()
    {
        Show("\nMoneyService(CreditAccount Only)");
        
        CreditAccount creditAccount = FindAccount("2") as CreditAccount;
        if (creditAccount == null)
        {
            Show("eeer");
            return;
        } 

        Show("1: display; 2: save; 3: withdraw 4: repayment; 5: AddCreditLimit;");
        string op = GetInput();

        if (op == "1")
        {
            Show("balance: " + creditAccount.Money +
                " surplus: " + creditAccount.Sueplus + " debt: " + creditAccount.Debt);
        }
        else if (op == "2")
        {
            Show("save money");
            string strMoney = GetInput();
            double money = double.Parse(strMoney);

            bool ok = creditAccount.SaveMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + creditAccount.Money +
                " surplus: " + creditAccount.Sueplus + " debt: " + creditAccount.Debt);
        }
        else if (op == "3")
        {
            Show("withdraw money");
            string strMoney = GetInput();
            double money = double.Parse(strMoney);

            bool ok = creditAccount.WithdrawMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + creditAccount.Money + 
                " surplus: " + creditAccount.Sueplus + " debt: " + creditAccount.Debt);
        }
        else if (op == "4")
        {
            Show("repayment money\n" +
                    "debt: " + creditAccount.Debt);
            string strMoney = GetInput();
            double money = double.Parse(strMoney);

            bool ok = creditAccount.Repayment(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + creditAccount.Money +
                " surplus: " + creditAccount.Sueplus + " debt: " + creditAccount.Debt);
        }
        else if (op == "5")
        {
            Show("AddCreditLimit\n" +
                    "CreditLine: " + creditAccount.CreditLine);
            string strLimit = GetInput();
            double limit = double.Parse(strLimit);

            bool ok = creditAccount.Add_maxCreditLine(limit);
            if (ok) Show("ok");
            else Show("eeer");

            Show("CreditLine: " + creditAccount.CreditLine);
        }
        else
            Show("eeer");
    }

    public void AccountService()
    {
        Show("\nAccountService\n" +
            "1: OpenAccount; 2: OpenCreditAccount; 3: CloseAccount 4: CloseCreditAccount;");
        string op = GetInput();

        if (op == "1" || op == "2")
        {
            Show("id: ");
            string id = GetInput();
            Show("name: ");
            string name = GetInput();
            Show("pwd: ");
            string pwd = GetInput();
            Show("money: ");
            string strMoney = GetInput();
            double money = double.Parse(strMoney);

            Account account = bank.OpenAccount(id, name, pwd, money, op);
            if (account != null) Show("ok");
            else Show("eeer");
        }
        else if (op == "3")
        {
            Account account = FindAccount("1");
            bool ok = bank.CloseAccount(account);
            if (ok) Show("ok");
            else Show("eeer");
        }
        else if (op == "4")
        {
            CreditAccount creditAccount = FindAccount("2") as CreditAccount;
            bool ok = bank.CloseCreditAccount(creditAccount);
            if (ok) Show("ok");
            else Show("eeer");
        }
        else
            Show("eeer");
    }

    private Account FindAccount(string op)
    {
        Account account;
        Show("please insert your name or id");
        string id = GetInput();
        Show("please enter your password");
        string pwd = GetInput();

        account = bank.FindAccount(id, pwd, op);
        if (account == null)
            Show("card invalid or password not corrent");

        return account;
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

