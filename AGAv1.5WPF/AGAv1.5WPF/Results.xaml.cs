using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;

using System.Data.SqlClient;
using System.Windows;

namespace AGAv1._5WPF
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        public Results()
        {
            InitializeComponent();
            ShowMember();
        }
        //public async void ShowMember()
        //{


        //    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AGA;Integrated Security=True;");
        //    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students", con);
        //    await con.OpenAsync();
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    dataGrid.DataContext = dt;
        //}
        private async void ShowMember()
        {
            string ConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AGA;Integrated Security=True;";
            string CmdString = string.Empty;
            SqlConnection con = new SqlConnection(ConString);
            await con.OpenAsync();
            CmdString = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(CmdString, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Students");
            sda.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            con.Close();
        }
    }
}
