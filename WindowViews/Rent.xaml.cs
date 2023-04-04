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
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Window
    {
        
        public Rent()
        {
            InitializeComponent();
        }

       //Continue button click
        private void continue_Click(object sender, RoutedEventArgs e)
        {
            
        
            LogicModel.Expenditures[7] = Convert.ToDouble(txbMonRen.Text);


            LogicModel.setisRent(true);
            Vehicle VH = new Vehicle();
            EndDisplayPage EDP = new EndDisplayPage();
            if (ComboBox.SelectedItem.Equals(yes))
            {
               
                this.Close();
                VH.Show();
            }

            else
            {
              

                
                Task2 T2 = new Task2(LogicModel.getExpenditures(), LogicModel.getInput(), LogicModel.getisRent(), LogicModel.getisCar(), LogicModel.getisSavings());
                LogicModel.setUserExpenses(T2.UserExpenseList);
                
                this.Close();
                EDP.Show();
            }
        }

        //View savings button click
        private void viewsavn_Click(object sender, RoutedEventArgs e)
        {
            LogicModel.Expenditures[7] = Convert.ToDouble(txbMonRen.Text);
            LogicModel.setisRent(true);
            Savings sav = new Savings();
            this.Close();
            sav.Show();
        }
    }
}
