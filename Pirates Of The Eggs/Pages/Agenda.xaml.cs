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
    /// Interaction logic for Agenda.xaml
    /// </summary>
    public partial class Agenda : Page
    {
        Pirates_of_the_eggsDataSet datasource = new Pirates_of_the_eggsDataSet();

        public Agenda()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }

        public void Datum()
        {
            

            
        }        

        public void DataSender_Click(object sender, RoutedEventArgs e)
        {

            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string Opslaan = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                LastName.Text.ToString();
                

                Opslaan = @"Insert into Reserveringen (LastName, ReservedDateTime)" +
                "Values('" + LastName + "', '" + ReservedDateTime + "')";

                SqlCommand cmd = new SqlCommand(Opslaan, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
            }
        }
    }
}
