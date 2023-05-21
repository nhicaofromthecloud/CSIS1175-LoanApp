using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LoanApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            GetDetails(out string loanHolder, out double interestRate, out double initialLoan);
            Loan Loan1 = new Loan(loanHolder, interestRate, initialLoan);
            WriteLine(Loan1);

            WriteLine("Processing loan and debt payment data...");
           
            Write("Please enter yearly payment: ");
            double.TryParse(ReadLine(), out double yearlyPayment);
            int currentYear = 1;
            double currentBalance = initialLoan;
            while (currentBalance > -1)
            {
                WriteLine("Year "+ currentYear +"     Current Balance: "+ currentBalance+ "     Yearly Payment: "+ yearlyPayment);
                currentYear++;
                currentBalance -= yearlyPayment;
               
            }
      
            
             
        }

        static void GetDetails(out string loanHolder, out double interestRate, out double initialLoan)
        {
            WriteLine("Please enter student name: ");
            loanHolder= ReadLine();
            while(loanHolder =="")
            {
                WriteLine("Student name cannot be empty. Please re-enter");
                loanHolder = ReadLine();
            }

            //WriteLine("Please enter student ID: ");
            //string studentId = ReadLine();

            WriteLine("Please enter interest rate: ");
            double.TryParse(ReadLine(), out interestRate);
                       
            WriteLine("Please enter initial loan: ");
            double.TryParse(ReadLine(), out initialLoan);
          

        }
    }
}
