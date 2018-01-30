using System;
using System.Collections;

public class Account
{

    private double money; //decimal money;
    private string id;
    private string pwd;
    private string name;

    // Ù–‘
    public double Money
    {
        set
        {
            money = value;
        }
        get
        {
            return money;
        }
    }
    public string Id
    {
        set
        {
            id = value;
        }
        get
        {
            return id;
        }
    }
    public string Pwd
    {
        set
        {
            pwd = value;
        }
        get
        {
            return pwd;
        }
    }
    public string Name
    {
        set
        {
            name = value;
        }
        get
        {
            return name;
        }
    }

    public Account(string id, string name, string pwd, double money)
    {
        
        this.id = id;
        this.pwd = pwd;
        this.name = name;
        if (money >= 0)
            this.money = money;
        else
            this.money = 0;
        //Console.WriteLine(this.money);
    }

    //¥Ê«Æ
    public virtual bool SaveMoney(double money)
    {
        if (money < 0) return false;  //Œ¿”Ôæ‰

        this.money += money;
        return true;
    }

    //»°«Æ
    public virtual bool WithdrawMoney(double money)
    {
        if (this.money >= money)
        {
            this.money -= money;
            return true;
        }

        return false;
    }

    //≤È’“’Àªß
    public bool IsMatch(string noi, string pwd)
    {
        return (noi == this.id||noi == this.name) && pwd == this.pwd;
    }
}
