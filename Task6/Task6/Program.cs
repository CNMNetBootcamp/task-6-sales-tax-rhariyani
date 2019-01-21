using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double ordertotal = 0.0;
            double totaltax = 0.0;
            double grandtotal = 0.0;
            double statetax = 0.0;
            double salestax = 0.0;
            
            double tax1= 0.03;
            double tax2= 0.05;


            Console.WriteLine("What is your ordertotal? ");
            ordertotal = double.Parse(Console.ReadLine());


            
                salestax = ordertotal * tax1; 
                Console.WriteLine("The sales tax on your oder is:" + salestax);
                Console.ReadLine();
            
                statetax = ordertotal * tax2;
                Console.WriteLine("The state tax on your oder is:" + statetax);
                Console.ReadLine();


                  totaltax = salestax + statetax;
                Console.WriteLine("The total tax on your oder is:" + totaltax);
                Console.ReadLine();



                 grandtotal = totaltax + ordertotal;
                Console.WriteLine("The grandtotal on your oder is:" + grandtotal);
                Console.ReadLine();

           
        }
    }
    }
    

        
















