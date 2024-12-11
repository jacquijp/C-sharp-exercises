//Class and objects - exercise
using System;

class Payment 
{
    public int IdPayment;
    public double Amount;
    public string Currency;
    public DateTime PaymentDate;
}

class Program
{
    static void Main(string[args])
    {
        //declare objects of the class payment
        Payment paymentOnline = new Payment();
        Payment paymentStore = new Payment();

        //assign values to the attributes
        paymentOnline.IdPayment = 1;
        paymentOnline.Amount = 1200.50;
        paymentOnline.Currency = "MXN";
        paymentOnline.PaymentDate = DateTime.Now;

        paymentStore.IdPayment = 2;
        paymentStore.Amount = 600.80;
        paymentStore.Currency = "SEK";
        paymentStore.PaymentDate = DateTime.Now;

        //print values
        Console.WriteLine("Online payment: {paymentOnline.IdPayment}, {paymentOnline.Amount}, {paymentOnline.Currency}, {paymentOnline.PaymentDate}");

        Console.WriteLine("Store payment: {paymentStore.IdPayment}, {paymentStore.Amount}, {paymentStore.Currency}, {paymentStore.PaymentDate}");

    }
}