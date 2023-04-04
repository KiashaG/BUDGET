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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        public Savings()
        {
            InitializeComponent();
        }

        //Continue button click
        private void continue_Click(object sender, RoutedEventArgs e)
        {

            MainWindow MW = new MainWindow();
            this.Close();
            MW.Show();
        }

        private void storingExpenses()
        {
            LogicModel.Expenditures[21] = Convert.ToDouble(txbSavAm.Text);
            LogicModel.Expenditures[22] = Convert.ToDouble(txbCurrBal.Text);
            LogicModel.Expenditures[23] = Convert.ToDouble(txbinterate.Text);
            LogicModel.Expenditures[24] = Convert.ToDouble(txbNumYears.Text);
         
        }

        //View savings button click
        private void viewsumrep_Click(object sender, RoutedEventArgs e)
        {
            storingExpenses();
            LogicModel.setisSavings(true);
            Task2 T2 = new Task2(LogicModel.getExpenditures(), LogicModel.getInput(), LogicModel.getisRent(), LogicModel.getisCar(), LogicModel.getisSavings());
            LogicModel.setUserExpenses(T2.UserExpenseList);
            EndDisplayPage End = new EndDisplayPage();
            this.Close();
            End.Show();

        }
    }
  
}
