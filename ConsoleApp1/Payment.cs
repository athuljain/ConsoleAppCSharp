using Program;
using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Payment
    {

        public virtual void MakePayment()
        {
                       Console.WriteLine("Processsing Payment");

        }
    }
}


public class CreditcarPayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Payment done, Credit Card Payment");
    }
}

public class UPIpayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Payment done, UPI Payment");
    }
}

public class CashPayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Processing Cash Payment");
    }
}