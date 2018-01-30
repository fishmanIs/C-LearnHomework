using System;
using System.Collections;

public class ATM:Isg
{
	
	Bank bank;
	public ATM( Bank bank)
	{
		this.bank = bank;
	}
	
	public void ATMTransaction()
	{
        //查询账号
        Account account=Find();

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
                string smoney = GetInput();
                double money = double.Parse(smoney);

                bool ok = account.SaveMoney(money);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + account.Money);
            }
            else if (op == "3")
            {
                Show("withdraw money");
                string smoney = GetInput();
                double money = double.Parse(smoney);

                bool ok = account.WithdrawMoney(money);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + account.Money);
            }
            else
                Show("eeer");
        }

        //return account;
        //Account account = Find();
		//if( account != null)
		//{
            //服务
          //  ATMService(account);
        //}
	}

    //账号查询
    private Account Find()
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

    //服务
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
            string smoney = GetInput();
            double money = double.Parse(smoney);

            bool ok = account.SaveMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + account.Money);
        }
        else if (op == "3")
        {
            Show("withdraw money");
            string smoney = GetInput();
            double money = double.Parse(smoney);

            bool ok = account.WithdrawMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + account.Money);
        }
        else
            Show("eeer");
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
