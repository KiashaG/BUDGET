using BudgetAppPROG6221.WindowViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppPROG6221.Logic
{
    class Task2
    {
        delegate void Del(string BudgetApplication); // Used to point to any method, new implemetaion adapted as Task 2 Requirement
        public Task2 (double[]Expenditures, String[]Input, Boolean isRent, Boolean isCar , Boolean isSavings)
        {
            // Display Project Title

            //Console.WriteLine("CarExpenditures is zero" + CarExpenditures[0]);
            //Console.WriteLine("Number of months to repay is:" + Expenditures[11]);
            Console.WriteLine("Budget Planning Application");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            // Declare varibles
            // Initializing varibles 

            double GrossMonthlyIncome = Expenditures[0];
            double EstimatedTaxDeducted = Expenditures[1];
            double Groceries = Expenditures[2];
            double WaterAndLights = Expenditures[3];
            double TravelCostsIncludingPetrol = Expenditures[4];
            double CellphoneAndTelephone = Expenditures[5];
            double OtherExpenses = Expenditures[6];
            double MonthlyRental = Expenditures[7];
            double PurchasePriceOfProperty = Expenditures[8];
            double TotalDeposit = Expenditures[9];
            double InterestRate = Expenditures[10];
            double NumberOfMonthsToRepay = Expenditures[11];
            double Option = Expenditures[12];
            double MonthlyInstallment = Expenditures[13];
            double Vehicle = Expenditures[14];
            double VehicleA = 0;

            // Hold any number of objects referred through unique key
            // Generic collection to store the expenses
            // Further populated using the add method
            // New implemenation used as adapted version for Task 2

            Dictionary<string, double> Expenses = new Dictionary<string, double>();


            //get user iput for gross monthly income
            //Console.WriteLine("Please enter your gross monthly income");
            //int grossmonthlyincome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your gross monthly income is: " + GrossMonthlyIncome);

            // get user estimated monthly tax deducted
            //Console.WriteLine("Please enter your estimated monthly tax deducted");
            //int estimatedmonthlytaxdeducted = Convert.ToInt32(Console.ReadLine());
            Expenses.Add("Estimated monthly tax deducted", EstimatedTaxDeducted);
            Console.WriteLine("Your estimated monthly tax deducted is:" + EstimatedTaxDeducted);

            // get user input for the following monthly expenditure
            //Groceries
            //Console.WriteLine("Please enter your estimated monthly expenditures for the following categories");
            //Console.WriteLine("Please enter your groceries amount");
            //int groceries = Convert.ToInt32(Console.ReadLine());
            Expenses.Add("Groceries", Groceries);
            Console.WriteLine("Your groceries amount is:" + Groceries);

            //Water and Lights
            //Console.WriteLine("Please enter your water and lights amount");
            //int waterandlights = Convert.ToInt32(Console.ReadLine());
            Expenses.Add("Water and lights", WaterAndLights);
            Console.WriteLine("Your water and lights amount is:" + WaterAndLights);

            //Travel costs including petrol
            //Console.WriteLine("Please enter your travel costs (including petrol)");
            //int travelcostsIncludingpetrol = Convert.ToInt32(Console.ReadLine());
            Expenses.Add("Travel costs (including petrol)", TravelCostsIncludingPetrol);
            Console.WriteLine("Your travel costs(including petrol) amount is:" + TravelCostsIncludingPetrol);

            // Cellphone and Telephone
            //Console.WriteLine("Please enter your cellphone and telephone amount");
            //int cellphoneandtelephone = Convert.ToInt32(Console.ReadLine());
            Expenses.Add("Cell phone and telephone", CellphoneAndTelephone);
            Console.WriteLine("Your cellphone and telephone amount is:" + CellphoneAndTelephone);

            // Other Expenses
            //Console.WriteLine("Please enter your other expenses amount");
            //int otherexpenses = Convert.ToInt32(Console.ReadLine());
            Expenses.Add("Other expenses", OtherExpenses);
            Console.WriteLine("Your other expenses is:" + OtherExpenses);


            Console.WriteLine("Choose from the below options");
            Console.WriteLine("Select Option 1 or Select Option 2  ");
            Console.WriteLine("1. Renting accommodation");
            Console.WriteLine("2. Buying a property");

            totalExpense = EstimatedTaxDeducted+Groceries+WaterAndLights+TravelCostsIncludingPetrol+CellphoneAndTelephone+OtherExpenses;
            // if user enters rent option then monthly rental amount is asked OR
            // if user enters buying option then home loan inputs are required
            // Conditional (if-else) statement
           /* Option = Expenditures[15];*/ /*Convert.ToInt32(Console.ReadLine());*/
            if (isRent)
            {
                //Console.WriteLine("Please enter the monthly rental amount");
                double monthlyRental = Expenditures[16]; /* Convert.ToInt32(Console.ReadLine());*/
                Expenses.Add("Monthly rental amount", Math.Round(MonthlyRental,2));
                totalExpense = totalExpense + monthlyRental;
                Console.WriteLine("Monthly rental amount is:" + MonthlyRental);
            }
            else if (!isRent)
            {
                //Console.WriteLine("Please enter the following for home loan");
                //Console.WriteLine("Purchase price of property");
                double purchasepriceofproperty = Expenditures[8]; /*Convert.ToInt32(Console.ReadLine());*/
                Console.WriteLine("Purchase price of property is:" + purchasepriceofproperty);

                //Console.WriteLine("Total deposit");
                double totaldeposit = Expenditures[9];/*Convert.ToInt32(Console.ReadLine());*/
                Console.WriteLine("Total deposit is:" + totaldeposit);

                //Console.WriteLine("Interest rate (percentage)");
                double interestratepercentage = Expenditures[10]; /*Convert.ToInt32(Console.ReadLine());*/
                Console.WriteLine("Interest Rate (Percentage) is:" + interestratepercentage);

                //Console.WriteLine("Number of months to repay (between 240 and 360)");
                double numberofmonthstorepay = Expenditures[11];/*Convert.ToInt32(Console.ReadLine());*/
                Console.WriteLine("Number of months to repay is:" + numberofmonthstorepay);

                //Console.WriteLine("The monthly home loan repayment for buying a property");
                MonthlyInstallment = monthlyhomeloanrepayment(PurchasePriceOfProperty - TotalDeposit, InterestRate,
                    NumberOfMonthsToRepay / 12);
                if (MonthlyInstallment > GrossMonthlyIncome / 3)
                {
                    Console.WriteLine("Approval of the home loan is unlikely");
                  
                }
                Expenses.Add("Home Loan monthly installment", Math.Round(MonthlyInstallment,2));
                totalExpense = totalExpense + MonthlyInstallment;
                Console.WriteLine("Home Loan monthly installment is:" + MonthlyInstallment);
            }

            //Calculation for the monthly home loan repayment for purchasing property
             double monthlyhomeloanrepayment(double a, double b, double c)
            {
                double monthlyhomerepayment;
                //interest for one month
                b = b / (12 * 100);
                //monthly installment period
                c = c * 12;
                monthlyhomerepayment = (a * b * (double)Math.Pow(1 + b, c))
                / (double)(Math.Pow(1 + b, c) - 1);

                return (monthlyhomerepayment);
            }

            //Available money after all specified deductions have been made
            double MoneyAvailable = 0;
      
            Console.WriteLine("Available monthly money after all the specified deductions have been made:", MoneyAvailable);
            double vehicle = PurchaseVehicle(); // Task 2 Requirement
          


            //Task 2 requirement: POINT 1 AND POINT 2
                double PurchaseVehicle()
            {
                Console.WriteLine("Would you like to purchase a vehicle?");
                Console.WriteLine("Select Option 1 for yes OR Option 2 for No");
                Console.WriteLine("1: Yes");
                Console.WriteLine("2: No");

              
                int SelectOption = Convert.ToInt32(Console.ReadLine());
                if (isCar)
                {
                    //Console.WriteLine("Please enter the following for vehicle financing");
                    //Console.WriteLine("Model and Make");
                    string ModelandMake = Input[0]; /*Console.ReadLine();*/
                    Console.WriteLine("Model and Make is:" + ModelandMake);

                    //Console.WriteLine("Purchase Price");
                    double PurchasePrice = Expenditures[17];
                    //double.TryParse(Console.ReadLine(), out PurchasePrice);
                    Console.WriteLine("Purchase Price is:" + PurchasePrice);

                    //Console.WriteLine("Total Deposit");
                    double Totaldeposit = Expenditures[18];
                    //double.TryParse(Console.ReadLine(), out Totaldeposit);
                    Console.WriteLine("Total Deposit is:" + Totaldeposit);

                    //Console.WriteLine("Interest Rate (percentage)");
                    double Interestrate = Expenditures[19];
                    //double.TryParse(Console.ReadLine(), out Interestrate);
                    Console.WriteLine("Interest Rate is:" + Interestrate);

                    //Console.WriteLine("Estimated Insurance Premium");
                    double EstimatedInsurancePremium = Expenditures[20];
                    //double.TryParse(Console.ReadLine(), out EstimatedInsurancePremium);
                    Console.WriteLine("Estimated Insurance Premium is:" + EstimatedInsurancePremium);


                    //Task 2 requirement: POINT 3
                    VehicleA = monthlyhomeloanrepayment(PurchasePrice - Totaldeposit + EstimatedInsurancePremium, Interestrate, 5);
                    Expenses.Add("Vehicle ", Math.Round(VehicleA,2));
                    totalExpense = totalExpense + VehicleA;
                    MoneyAvailable = MoneyAvailable - VehicleA;
                }
                return VehicleA;
            }

            // Task 2 requirement: POINT 4
          
            //if (isRent && isCar)
            //{
            //    totalExpense = EstimatedTaxDeducted + Groceries + WaterAndLights + TravelCostsIncludingPetrol + CellphoneAndTelephone
            //        + MonthlyRental + OtherExpenses + VehicleA;
            //}
            //else if (!isRent && isCar)
            //{
            //    totalExpense = EstimatedTaxDeducted + Groceries + WaterAndLights + TravelCostsIncludingPetrol + CellphoneAndTelephone
            //        + OtherExpenses + MonthlyInstallment + VehicleA;
            //}
            if (totalExpense > (GrossMonthlyIncome * 3 / 4))
                Console.WriteLine("Total expenses are greater than 75 percent of the gross income");
         
            {

                // Task 2 requirement: POINT 5

                Del budgetapplication = delegate (string BudgetApplication)
                {
                    Console.WriteLine("Total expenses are greater than 75 percent of gross income");
                };
            }


            //Task 3 requirement 
            if (isSavings)
            {
                Console.WriteLine("How much would you like to save?");
                double Save = Expenditures[21];/*Convert.ToDouble(Console.ReadLine());*/
                Console.WriteLine("How much is your current balance?");
                double balance = Expenditures[22];/*Convert.ToDouble(Console.ReadLine());*/
                Console.WriteLine("Enter your interest rate amount");
                double interest = Expenditures[23];/*Convert.ToDouble(Console.ReadLine()) / 100;*/
                Console.WriteLine("How many years would you like to save for?");
                double years = Expenditures[24];/*Convert.ToDouble(Console.ReadLine());*/

                double yearsa = years * 12;
                double interestb = 1 + interest;
                double e = Math.Pow(interestb, yearsa);
                double d = (interestb - 1) * (Save - balance * e);
                double amounttosaved = d / (e - 1);

                Console.WriteLine("Amount Saved:" + amounttosaved);
                Expenses.Add("Amount Saved", Math.Round (amounttosaved,2));
                totalExpense = totalExpense + amounttosaved;

            }


            //Display the expenses to the user in descending order by value
            Console.WriteLine("Expenses to the user in descending order by value");
            foreach (KeyValuePair<string, double> expin in Expenses.OrderBy(key => key.Value))
            {
                //Console.WriteLine(expin.Key + expin.Value);
                UserExpenseList = UserExpenseList + " " + expin.Key + expin.Value;


            }
            Console.ReadLine();
            AvailableBalance = GrossMonthlyIncome - totalExpense;
            double[] Calculations = new double[3];
            Calculations[0] = Math.Round(AvailableBalance,2);
            Calculations[1] = Math.Round(totalExpense,2);
            LogicModel.setCalculations(Calculations);



        }
        public string UserExpenseList = "";
        public double AvailableBalance = 0;
        public double totalExpense = 0;
        
    }
}
