using BudgetAppPROG6221.Logic;
using BudgetAppPROG6221.WindowViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BudgetAppPROG6221
{
    /// <summary>
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {
       
        public Vehicle()
        {
            InitializeComponent();
        }

      
        //View savings button click
       private void viewsav_Click(object sender, RoutedEventArgs e)
        {
            storingExpenses();
            LogicModel.setisCar(true);
            LogicModel.setisSavings(true);
            Task2 T2 = new Task2(LogicModel.getExpenditures(), LogicModel.getInput(), LogicModel.getisRent(), LogicModel.getisCar(), LogicModel.getisSavings());
            LogicModel.setUserExpenses(T2.UserExpenseList);

            Savings sav = new Savings();
            this.Close();
            sav.Show();
        }

        //Continue button click
    private void continue_Click(object sender, RoutedEventArgs e)
        {

            storingExpenses();
            LogicModel.setisCar(true);
            LogicModel.setisSavings(true);
            Task2 T2 = new Task2(LogicModel.getExpenditures(), LogicModel.getInput(), LogicModel.getisRent(), LogicModel.getisCar(), LogicModel.getisSavings());
            LogicModel.setUserExpenses(T2.UserExpenseList);

            EndDisplayPage ENP = new EndDisplayPage();
            this.Close();
            ENP.Show();

        }

        private void storingExpenses()
        {
            LogicModel.Input[0] = Convert.ToString(txbMAM.Text);
            LogicModel.Expenditures[17] = Convert.ToDouble(txbPr.Text);
            LogicModel.Expenditures[18] = Convert.ToDouble(txbTD.Text);
            LogicModel.Expenditures[19] = Convert.ToDouble(txbIntR.Text);
            LogicModel.Expenditures[20] = Convert.ToDouble(txbEI.Text);
       
        }

     
    }
    
}
