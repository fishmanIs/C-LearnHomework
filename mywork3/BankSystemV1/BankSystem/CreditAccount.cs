
using System;
using System.Collections;

public class CreditAccount : Account,Isg
{
    private double creditLine;
    private double debt;
    private double surplus;

    //属性
    public double CreditLine
    {
        get
        {
            return creditLine;
        }
    }
    public double Debt
    {
        get
        {
            return debt;
        }
    }
    public double Sueplus
    {
        get
        {
            return surplus;
        }
    }

    public CreditAccount(string id, string name, string pwd, double money)
    :base(id, name, pwd, money)
    {
        creditLine = 10000;
        debt = 0;
        surplus = creditLine;
    }

    //增加额度
    public bool AddLimit(double limit)
    {
        if (limit < 0)
            return false;

        creditLine += limit;
        surplus += limit;
        return true;
    }

    //还款
    public bool Repayment(double money)
    {
        if (money < 0)
            return false;

        if(money<=debt)
        {
            debt -= money;
            surplus += money;
        }
        else
        {
            base.Money += money - debt;
            debt = 0;
            surplus = creditLine;
        }

        return true;
    }

    //存钱
    public override bool SaveMoney(double money)
    {
        if (money < 0) return false;  //卫语句

        if(debt>0)
        {
            Repayment(money);
        }
        else
            base.Money += money;
        return true;
    }

    //取钱
    public override bool WithdrawMoney(double money)
    {
        if (this.surplus >= money)
        {
            if (money >= base.Money)
            {
                surplus -= money - base.Money;
                debt += money - base.Money;
                base.Money = 0;
            }
            else
                base.Money -= money;
            return true;
        }

        return false;
    }

    public void Show(string msg)
    {
        Console.WriteLine(msg);
    }
    public string GetInput()
    {
        return Console.ReadLine();// 输入字符
    }
}
