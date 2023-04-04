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
    /// Interaction logic for EndDisplayPage.xaml
    /// </summary>
    public partial class EndDisplayPage : Window
    {
       
        public EndDisplayPage()
        {
            
            InitializeComponent();
            txbSR.Text = LogicModel.getUserExpenses() + " Available Balance " + LogicModel.getCalculations()[0] + " Total Expenses" + LogicModel.getCalculations()[1];


        }

        //Continue button click
        private void continue_Click(object sender, RoutedEventArgs e)
        {
            LogicModel.setisCar(false);
            LogicModel.setisRent(false);
            LogicModel.setisSavings(false);

            MainWindow MW = new MainWindow();
            this.Close();
            MW.Show();

        }

       
    }
}
