using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KPrayogoFinal
{
    class Taxpayer
    {
        //Fields
        private string name;
        private decimal salary;
        private decimal investment;
        private bool isMarried;
        private int exemptCount;

        //Constants
        private const decimal unmarriedExempt = 375m;
        private const decimal marriedExempt = 500m;

        //Field Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public decimal Investment
        {
            get { return investment; }
            set { investment = value; }
        }

        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }

        public int ExemptCount
        {
            get { return exemptCount; }
            set { exemptCount = value; }
        }

        //Static Fields
        private static decimal totalTax = 0m;
        private static int marriedCount = 0;
        private static int singleCount = 0;

        //Static Properties
        //No "Set" for counts to prevent editing the class data from outside the class.

        public static decimal TotalTax
        {
            get { return totalTax; }
            set { totalTax = value; }
        }

        public static int MarriedCount
        {
            get { return marriedCount; }
        }

        public static int SingleCount
        {
            get { return singleCount; }
        }

        //Properties without fields

        public decimal Income
        {
            get { return Salary + Investment; }
        }
        
        public decimal TaxAmt
        {
            get { return ComputeTaxAmt(); }
        }

        public int TaxRate
        {
            //A method is used to keep class definition clean, all computations are at the bottom
            get { return GetTaxRate(); }    
        }

        public static decimal AvgTax
        {
            get
            {
                if (CheckDataAvail())   //Checks for division by 0 using boolean method
                {
                    return TotalTax / ( SingleCount + MarriedCount );
                }
                else
                { 
                    return 0; 
                }
            }
        }

        public string MaritalStatus
        {
            get
            {
                if (IsMarried)
                { return "Married"; }
                else
                { return "Single"; }
            }
        }

        

        //Constructor
        public Taxpayer(string name, decimal salary, decimal investment, bool isMarried, int exCount)
        {
            //Inputs
            this.Name = name;
            this.Salary = salary;
            this.Investment = investment;
            this.IsMarried = isMarried;
            this.ExemptCount = exCount;

            //Update Totals
            if (isMarried)
            { marriedCount++; }
            else
            { singleCount++; }

            //Tax computed using property
            TotalTax += TaxAmt; 
        }


        //-----------------METHODS-----------------------

        //ToString method used for testing in early versions
        public override string ToString()
        {
            return Name + "   " + Income + "   " + TaxAmt;
        }

        public static string Summary()
        {
            if (CheckDataAvail())
            {
                return "Married Taxpayers: " + MarriedCount + "      " + "Single Taxpayers: " +
                    SingleCount + "      " + "Average Tax: " + AvgTax.ToString("C");
            }
            else
            {
                return "No Data Available.";
            }
        }

        public string Display ()
        {
            return Name + "      " + "Income: " + Income.ToString("C") +
                "      " + "Tax: " + TaxAmt.ToString("C") + "      " + MaritalStatus;
        }

        //------------------------COMPUTATION METHODS---------------------------------------

        private decimal ComputeTaxAmt()
        {
            //Created local variable to avoid clutter (more readable)
            decimal taxableInc;
            
            if (IsMarried)
            {
                taxableInc = Income - (marriedExempt * ExemptCount);

                if (taxableInc > 150000m)
                { return taxableInc * 0.3m; }
                else
                { return taxableInc * 0.2m; }
            }
            else
            {
                taxableInc = Income - (unmarriedExempt * ExemptCount);

                if (taxableInc > 100000m)
                { return taxableInc * 0.18m; }
                else
                { return taxableInc * 0.15m; }
            }
        }

        private int GetTaxRate ( )
        {
            //Created local variable to avoid clutter (more readable)
            decimal taxableInc;

            if (IsMarried)
            {
                taxableInc = Income - (marriedExempt * ExemptCount);

                if (taxableInc > 150000m)
                { return 30; }
                else
                { return 20; }
            }
            else
            {
                taxableInc = Income - (unmarriedExempt * ExemptCount);

                if (taxableInc > 100000m)
                { return 18; }
                else
                { return 15; }
            }
        }

        public static bool CheckDataAvail ( )
        {
            if (MarriedCount + SingleCount != 0)
            { return true; }
            else
            { return false; }
        }

        public static void ResetData()
        {
            TotalTax = 0m;
            marriedCount = 0;
            singleCount = 0;
        }

    }
}
