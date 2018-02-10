using System;
using System.Collections;
using System.Collections.Generic;

public class Bank
{

    List<Account> accounts = new List<Account>();//普通账户
    List<CreditAccount> creditAccounts = new List<CreditAccount>();//信用账户

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
            CreditAccount creditAccount = new CreditAccount(id, name, pwd, money);
            creditAccounts.Add(creditAccount);
            return creditAccount;
        }
    }

    public bool CloseAccount(Account account)
    {
        int idx = accounts.IndexOf(account);
        if (idx < 0) return false;
        accounts.Remove(account);
        return true;
    }

    public bool CloseCreditAccount(CreditAccount creditAccount)
    {
        int idx = creditAccounts.IndexOf(creditAccount);
        if (idx < 0) return false;
        creditAccounts.Remove(creditAccount);
        return true;
    }

    public Account FindAccount(string nameOrId, string pwd, string op)
    {
        if(op == "1")
        {
            foreach (Account account in accounts)
            {
                if (account.IsMatch(nameOrId, pwd))
                {
                    return account;
                }
            }
        }
        else
        {
            foreach (CreditAccount creditAccount in creditAccounts)
            {
                if (creditAccount.IsMatch(nameOrId, pwd))
                {
                    return creditAccount;
                }
            }
        }

        return null;
    }
}
