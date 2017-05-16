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
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

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
            string ConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AGA;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";
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

        private async void Delete_by_ID_ClickAsync(object sender, RoutedEventArgs e)
        {
            string ConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AGA; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";
            string CmdDelete = string.Empty;
            SqlConnection con = new SqlConnection(ConString);
            await con.OpenAsync();
            try
            {
                CmdDelete = $"DELETE FROM Students WHERE ID = '{Convert.ToInt32(ID.Text)}'";
                SqlCommand cmd = new SqlCommand(CmdDelete, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Students");

                adapter.Update(dt);
                adapter.Fill(dt);
                dt.AcceptChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Մուտք է արված սխալ լիմվոլ !!!");
            }
            //CollectionViewSource.GetDefaultView(dataGrid.ItemsSource).Refresh();
            //dataGrid.Items.Refresh();
            //dataGrid.UpdateLayout();
            //dataGrid.ItemsSource = dt.DefaultView;
            ShowMember();
            con.Close();
        }

        private async void DeleteAll_ClickAsync(object sender, RoutedEventArgs e)
        {
            string ConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AGA;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";
            string CmdDeleteAll = string.Empty;
            SqlConnection con = new SqlConnection(ConString);
            await con.OpenAsync();
            try
            {
                CmdDeleteAll = $"DELETE FROM Students";
                SqlCommand cmd = new SqlCommand(CmdDeleteAll, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Students");
                              
                adapter.Update(dt);
                adapter.Fill(dt);
                dt.AcceptChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Սխալ է!!!");
            }
            ShowMember();
            con.Close();
        }

        private void ID_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ID.Text = null;
        }
        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Delete_by_ID_ClickAsync(null, null);
            }
        }
    }
}
