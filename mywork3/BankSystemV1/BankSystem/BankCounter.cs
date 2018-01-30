using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class BankCounter:Isg
{
    Bank bank;
    public BankCounter(Bank bank)
    {
        this.bank = bank;
    }

    public void BCTransaction()
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


    //搞钱服务
    private void MoneyService()
    {
        Show("\nMoneyService(CreditAccount Only)");
        //查询账号
        CreditAccount crdAccount = Find("2") as CreditAccount;
        if (crdAccount == null)
        {
            Show("eeer");
            return;
        } 

        Show("1: display; 2: save; 3: withdraw 4: repayment; 5: AddLimit;");
        string op = GetInput();

        if (op == "1")
        {
            Show("balance: " + crdAccount.Money +
                " surplus: " + crdAccount.Sueplus + " debt: " + crdAccount.Debt);
        }
        else if (op == "2")
        {
            Show("save money");
            string smoney = GetInput();
            double money = double.Parse(smoney);

            bool ok = crdAccount.SaveMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + crdAccount.Money +
                " surplus: " + crdAccount.Sueplus + " debt: " + crdAccount.Debt);
        }
        else if (op == "3")
        {
            Show("withdraw money");
            string smoney = GetInput();
            double money = double.Parse(smoney);

            bool ok = crdAccount.WithdrawMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + crdAccount.Money + 
                " surplus: " + crdAccount.Sueplus + " debt: " + crdAccount.Debt);
        }
        else if (op == "4")
        {
            Show("repayment money\n" +
                    "debt: " + crdAccount.Debt);
            string smoney = GetInput();
            double money = double.Parse(smoney);

            bool ok = crdAccount.Repayment(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + crdAccount.Money +
                " surplus: " + crdAccount.Sueplus + " debt: " + crdAccount.Debt);
        }
        else if (op == "5")
        {
            Show("AddLimit\n" +
                    "CreditLine: " + crdAccount.CreditLine);
            string sLimit = GetInput();
            double limit = double.Parse(sLimit);

            bool ok = crdAccount.AddLimit(limit);
            if (ok) Show("ok");
            else Show("eeer");

            Show("CreditLine: " + crdAccount.CreditLine);
        }
        else
            Show("eeer");
    }

    //账号服务
    public void AccountService()
    {
        Show("\nAccountService\n" +
            "1: OpenAccount; 2: OpenCreditAccount; 3: CloseAccount 4: CloseCreditAccount;");
        string op = GetInput();

        if (op == "1" || op == "2")
        {
            string id = GetInput();
            string name = GetInput();
            string pwd = GetInput();
            string smoney = GetInput();
            double money = double.Parse(smoney);

            Account account = bank.OpenAccount(id, name, pwd, money, op);
            if (account != null) Show("ok");
            else Show("eeer");
        }
        else if (op == "3")
        {
            Account account = Find("1");
            bool ok = bank.CloseAccount(account);
            if (ok) Show("ok");
            else Show("eeer");
        }
        else if (op == "4")
        {
            CreditAccount crdAccount = Find("2") as CreditAccount;
            bool ok = bank.CloseCreditAccount(crdAccount);
            if (ok) Show("ok");
            else Show("eeer");
        }
        else
            Show("eeer");
    }

    //查询账号
    private Account Find(string op)
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


    //接口实现
    public void Show(string msg)
    {
        Console.WriteLine(msg);
    }
    public string GetInput()
    {
        return Console.ReadLine();// 输入字符
    }
}

