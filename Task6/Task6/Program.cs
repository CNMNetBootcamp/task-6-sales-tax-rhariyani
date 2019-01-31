using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)

        {
            double ordertotal = 0.0;
            //double totaltax = 0.0;
            double grandtotal = 0.0;
            double statetax = 0.05;
            double salestax = 0.03;
            string question = "Y";

            do
            {


                Console.WriteLine("What is your ordertotal? ");
                ordertotal = double.Parse(Console.ReadLine());
                //TODO: Dont use a ref. 
                grandtotal = Taxcal(ordertotal, ref statetax, ref salestax);
                Console.WriteLine("Would you like to do another order (Y/N)");
                question = Console.ReadLine();

            } while (question == "Y");

        }
        // Dont use ref
        private static double Taxcal(double ordertotal, ref double statetax, ref double salestax)
        {
            double grandtotal;
            salestax = ordertotal * salestax;
            statetax = ordertotal * statetax;
            grandtotal = statetax + ordertotal + salestax;

            Console.WriteLine("The sales tax on your oder is:" + salestax);
            Console.WriteLine("The state tax on your oder is:" + statetax);
            Console.WriteLine("The grandtotal on your oder is:" + grandtotal);
            Console.ReadLine();
            return grandtotal; 
        }

    }

}
















