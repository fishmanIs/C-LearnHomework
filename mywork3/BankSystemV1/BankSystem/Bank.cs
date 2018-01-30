using System;
using System.Collections;
using System.Collections.Generic;

public class Bank
{

    List<Account> accounts = new List<Account>();//普通账户
    List<CreditAccount> crdAccounts = new List<CreditAccount>();//信用账户

    //开户
    public Account OpenAccount(string id, string name, string pwd, double money, string op)
    {
        if(op == "1")
        {
            Account account = new Account(id, name, pwd, money);
            accounts.Add(account);
            return account;
        }
        else
        {
            CreditAccount crdAccount = new CreditAccount(id, name, pwd, money);
            crdAccounts.Add(crdAccount);
            return crdAccount;
        }
    }

    //销户,普通账户
    public bool CloseAccount(Account account)
    {
        int idx = accounts.IndexOf(account);
        if (idx < 0) return false;
        accounts.Remove(account);
        return true;
    }

    //销户,信用账户
    public bool CloseCreditAccount(CreditAccount crdAccount)
    {
        int idx = crdAccounts.IndexOf(crdAccount);
        if (idx < 0) return false;
        crdAccounts.Remove(crdAccount);
        return true;
    }

    //查找账户
    public Account FindAccount(string noi, string pwd, string op)
    {
        if(op == "1")
        {
            foreach (Account account in accounts)
            {
                if (account.IsMatch(noi, pwd))
                {
                    return account;
                }
            }
        }
        else
        {
            foreach (CreditAccount crdAccount in crdAccounts)
            {
                if (crdAccount.IsMatch(noi, pwd))
                {
                    return crdAccount;
                }
            }
        }

        return null;
        //for (int i = 0; i < accounts.Count; i++)
        //{
        //    Account account = accounts[i];

        //    if( account.IsMatch(id, pwd))
        //    {
        //        return account;
        //    }
        //}
    }
}
