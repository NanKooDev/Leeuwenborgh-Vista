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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public static int TableChoice;
        
        public Main()
        {
            InitializeComponent();
            CheckTableFree(null, null);
            TableChoice = 0;
            
        }

        private void CheckTableFree(object sender, RoutedEventArgs e)
        {

                string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
                string cmdString = string.Empty;

                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    cmdString = @"select TafelID from Tafels where TafelGebruik = 1";

                    SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //foreach (object obj in TableButtons.Children)
                    //{
                    //((Button)obj).Background = Brushes.Red;
                    
                    ((Button)TableButtons.Children[TableChoice]).Background = Brushes.Red;
                    //}
                };
                    sqlConnection.Close();
                }
        }

        private void Tafel_Click(object sender, RoutedEventArgs e)
        {
            TableChoice = Convert.ToInt16(((Button)sender).Content);

                string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
                string cmdString = string.Empty;

                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    cmdString = $@"UPDATE Tafels SET TafelGebruik=1 WHERE TafelID= {Main.TableChoice}";


                    SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read()){};
                sqlConnection.Close();
                }
            MainWindow.MainFrame.Navigate(new MenuKaart());
        }

        private void ShowMenuKaart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new MenuKaart());
        }

        private void ShowBonnen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Bonnen());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Agenda()); 
        }
    }
}
