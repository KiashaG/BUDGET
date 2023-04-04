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
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Window
    {
  


        static Expenses Expn= new Expenses();

        public Expenses()
        {
            InitializeComponent();
        }

   
 
        // Continue button click 
        private void continue_Click(object sender, RoutedEventArgs e)
        {
            storingExpenses(); 

            Rent RT = new Rent();
            Buy By = new Buy();
            if (ComboBox.SelectedItem.Equals(rent))
            {
                LogicModel.setisRent(true);
                this.Close();
                RT.Show();
            }

            else
            {
                LogicModel.setisRent(false);
                this.Close();
                By.Show();
            }

        }
        void storingExpenses()
        {
            LogicModel.Expenditures[0]= Convert.ToDouble(txbGMI.Text);
            LogicModel.Expenditures[1] = Convert.ToDouble(txbETD.Text);
            LogicModel.Expenditures[2] = Convert.ToDouble(txbGroc.Text);
            LogicModel.Expenditures[3] = Convert.ToDouble(txbWAL.Text);
            LogicModel.Expenditures[4] = Convert.ToDouble(txbTC.Text);
            LogicModel.Expenditures[5] = Convert.ToDouble(txbCelTel.Text);
            LogicModel.Expenditures[6] = Convert.ToDouble(txbOE.Text);
            

           
        }


    }
        
    }


