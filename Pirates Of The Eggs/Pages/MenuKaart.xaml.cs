﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for MenuKaart.xaml
    /// </summary>
    public partial class MenuKaart : Page
    {
        Pirates_of_the_eggsDataSet datasource = new Pirates_of_the_eggsDataSet();

        public MenuKaart()
        {
            InitializeComponent();
            SelectedGerechten.Text = SelectedGerechten.Text + "\r\n" + "Order No. ";
            SelectedGerechtenPrice.Text = Main.TableChoice + "\r\n";
            AantalProduct.Text = AantalProduct.Text + "\r\n\r\n";
        }

        private void ShowTerug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }

        private void ShowOpsplitsen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Opsplitsen());
        }

        private void GerechtenFilter(object sender, RoutedEventArgs e)
        {
            datasource.Clear();
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string CmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = @"SELECT * FROM Gerechten INNER JOIN GerechtCategorie ON GerechtSoort = GerechtCategorie.GerechtID";
                if (((Button)sender).Content.ToString() != "Alle")
                {
                    CmdString = CmdString + $" where GerechtCategorie.SoortNaam = '{((Button)sender).Content.ToString()}'";
                    //CmdString = CmdString + " where GerechtCategorie.SoortNaam = '" + ((Button)sender).Content + "'";
                }

                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                DataTable dt = datasource.Tables["Gerechten"];

                sda.Fill(dt);
                MyDataGrid.ItemsSource = dt.DefaultView;
                MyDataGrid.Columns[0].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[3].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[4].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
        }

        private void GerechtClick(object sender, SelectionChangedEventArgs e)
        {
            string Order;
            string Price =string.Empty;
            int AantalProduct;
            DataRowView drv = (DataRowView)MyDataGrid.SelectedItem;
            if (drv != null)
                Order = (drv[1].ToString());
            else
                return;
            SelectedGerechten.Text = SelectedGerechten.Text + "\r\n" + Order;
            if (drv != null)
                Price = (drv[2].ToString());
            else
                return;
                SelectedGerechtenPrice.Text = SelectedGerechtenPrice.Text + "\r\n" + Price;
   
        }

        private void Btn_ClickNumber(object sender, RoutedEventArgs e)
        {
            TxtBlockNumber.Text = TxtBlockNumber.Text + ((Button)sender).Content;
        }

        private void Btn_ClickBackspace(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ClickClear(object sender, RoutedEventArgs e)
        {
            TxtBlockNumber.Text = String.Empty;
        }
    }
}
