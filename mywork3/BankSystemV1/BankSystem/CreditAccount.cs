
using System;
using System.Collections;

public class CreditAccount : Account, IShowAndGetInput
{
    private double _maxCreditLine;
    private double _debt;
    private double _surplus;

    public double CreditLine
    {
        get
        {
            return _maxCreditLine;
        }
    }
    public double Debt
    {
        get
        {
            return _debt;
        }
    }
    public double Sueplus
    {
        get
        {
            return _surplus;
        }
    }

    public CreditAccount(string id, string name, string pwd, double money)
    :base(id, name, pwd, money)
    {
        _maxCreditLine = 10000;
        _debt = 0;
        _surplus = _maxCreditLine;
    }

    public bool Add_maxCreditLine(double howMuch)
    {
        if (howMuch < 0)
            return false;

        _maxCreditLine += howMuch;
        _surplus += howMuch;
        return true;
    }

    public bool Repayment(double money)
    {
        if (money < 0)
            return false;

        if(money<= _debt)
        {
            _debt -= money;
            _surplus += money;
        }
        else
        {
            base.Money += money - _debt;
            _debt = 0;
            _surplus = _maxCreditLine;
        }

        return true;
    }

    public override bool SaveMoney(double money)
    {
        if (money < 0) return false;

        if(_debt > 0)
        {
            Repayment(money);
        }
        else
            base.Money += money;
        return true;
    }

    public override bool WithdrawMoney(double money)
    {
        if (this._surplus >= money)
        {
            if (money >= base.Money)
            {
                _surplus -= money - base.Money;
                _debt += money - base.Money;
                base.Money = 0;
            }
            else
                base.Money -= money;
            return true;
        }

        return false;
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
