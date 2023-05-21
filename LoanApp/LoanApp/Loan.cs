using LoanApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    internal class Loan
    {
        public string LoanHolder { get; set; }
        public double InitialLoan { get; set; }
        public double InterestRate { get; set; }

        char loanType = 'U';
        
        public char LoanType
        {   
            get
            { if (InterestRate == 3.7)
                {
                    loanType = 'H';
                }
             else if(InterestRate == 1.7)
                {
                    loanType = 'L';
                }
                return loanType;
            }

            set { }
        }

        public Loan (string loanHolder, double interestRate, double initialLoan) //pls remember to add datatype when declare a variable
        {
            LoanHolder = loanHolder;
            InterestRate = interestRate;
            InitialLoan = initialLoan;
            
        }

        public override string ToString()
        {
            string outputStr = "\nLoan Holder: " + LoanHolder +
                              "\nInterest Rate: "+ InterestRate +
                              "\nLoanType: " + LoanType +
                              "\nInitial Loan: " + InitialLoan.ToString("C");
            return outputStr;
        }
    }
}
