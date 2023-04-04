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
    /// Interaction logic for Buy.xaml
    /// </summary>
    public partial class Buy : Window
    {
     
        public Buy()
        {
            InitializeComponent();
          
        }

       // Continue button click
        private void Con_Click(object sender, RoutedEventArgs e)
        {
            LogicModel.setisRent(false);

            storingExpenses();
            Task2 T2 = new Task2(LogicModel.getExpenditures(), LogicModel.getInput(), LogicModel.getisRent(), LogicModel.getisCar(),LogicModel.getisSavings());
            LogicModel.setUserExpenses(T2.UserExpenseList);
            Vehicle VH = new Vehicle();
            EndDisplayPage ENP = new EndDisplayPage();

            if(ComboBox.SelectedItem.Equals(yes))
            {
                

                this.Close();
                VH.Show();
            }
          else
            {
             
               
                this.Close();
                ENP.Show();

            }

        }
        void storingExpenses()
        {
            LogicModel.Expenditures[8] = Convert.ToDouble(txbPP.Text);
            LogicModel.Expenditures[9] = Convert.ToDouble(txbTDep.Text);
            LogicModel.Expenditures[10] = Convert.ToDouble(txbIR.Text);
            LogicModel.Expenditures[11] = Convert.ToDouble(txbNumMon.Text);
            


        }

        // View savings button click
        private void viewsavn_Click(object sender, RoutedEventArgs e)
        {
            storingExpenses();
            LogicModel.setisRent(false);
            Savings sav = new Savings();
            this.Close();
            sav.Show();
        }
    }
}
