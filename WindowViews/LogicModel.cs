using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppPROG6221.WindowViews
{
    class LogicModel
    {
        public static double[] Expenditures = new double[25];
        public static string[] Input = new string[5];
        public static double[] Calculations = new double[3];
        public static string UserExpenses;
        public static Boolean isRent =false;
        public static Boolean isCar = false;
        public static Boolean isSavings = false;
        
        public static double[] getExpenditures()

        {
            return (Expenditures);
        }

        public static string[] getInput()
        {
            return (Input);
        }

        public static string getUserExpenses()
        {
            return (UserExpenses);


        }
        public static void setUserExpenses(string theExpenses)
        {
            UserExpenses = theExpenses;
        }

        public static Boolean getisRent()
        {
            return (isRent);


        }
        public static void setisRent(Boolean theExpenses)
        {
            isRent = theExpenses;
        }
        public static Boolean getisCar()
        {
            return (isCar);


        }
        public static void setisCar(Boolean theExpenses)
        {
            isCar = theExpenses;
        }

        public static Boolean getisSavings()
        {
            return (isSavings);


        }
        public static void setisSavings(Boolean theExpenses)
        {
            isSavings = theExpenses;
        }

        public static double [] getCalculations()
        {
            return (Calculations);


        }
        public static void setCalculations(double [] theExpenses)
        {
            Calculations = theExpenses;
        }

    }
}

