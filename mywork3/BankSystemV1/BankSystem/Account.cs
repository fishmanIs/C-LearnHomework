using System;
using System.Collections;

public class Account
{

    private double _money;
    private string _id;
    private string _pwd;
    private string _name;

    public double Money
    {
        set
        {
            _money = value;
        }
        get
        {
            return _money;
        }
    }
    public string Id
    {
        set
        {
            _id = value;
        }
        get
        {
            return _id;
        }
    }
    public string Pwd
    {
        set
        {
            _pwd = value;
        }
        get
        {
            return _pwd;
        }
    }
    public string Name
    {
        set
        {
            _name = value;
        }
        get
        {
            return _name;
        }
    }

    public Account(string id, string name, string pwd, double money)
    {
        
        this._id = id;
        this._pwd = pwd;
        this._name = name;
        if (money >= 0)
            this._money = money;
        else
            this._money = 0;
    }

    public virtual bool SaveMoney(double money)
    {
        if (money < 0) return false;

        this._money += money;
        return true;
    }

    public virtual bool WithdrawMoney(double money)
    {
        if (this._money >= money)
        {
            this._money -= money;
            return true;
        }

        return false;
    }

    //≈–∂œ’Àªß «∑Ò¥Ê‘⁄
    public bool IsMatch(string nameOrId, string pwd)
    {
        return (nameOrId == this._id || nameOrId == this._name) && pwd == this._pwd;
    }
}
