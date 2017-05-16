using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AGAv1._5WPF
{

    public partial class MainWindow : Window
    {

        //SqlConnection Connection = new SqlConnection();
        public MainWindow()
        {
            InitializeComponent();
        }
        SqlConnectionStringBuilder conStr = new SqlConnectionStringBuilder();
        public async void DataSaving(float Calculator)
        {
            conStr.DataSource = @"(localdb)\MSSQLLocalDB";
            conStr.InitialCatalog = "AGA";
            conStr.IntegratedSecurity = true;
            SqlConnection connetion = new SqlConnection(conStr.ConnectionString);
            string cmdText = "INSERT INTO Students(Name,AGA,Date) VALUES (@UserName,@calculator,@date)";
            SqlCommand cmd = new SqlCommand(cmdText, connetion);
            //cmd.Parameters.AddWithValue("ID", 1);
            cmd.Parameters.AddWithValue("UserName", UserName.Text);
            cmd.Parameters.AddWithValue("calculator", Calculator);
            cmd.Parameters.AddWithValue("date", DateTime.Now);
            cmd.CommandType = CommandType.Text;

            try
            {
                await connetion.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connetion != null)
                    connetion.Close();
            }
        }

        private async void Calculator_Click(object sender, RoutedEventArgs e)
        {
            string Name = UserName.Text;
            float SumPoint = 0;
            float SumCredit = 0;
            float LikPoint = 0;
            float Calculator = 0;
            int count = 0;
            ArrayList ArrayPoint = new ArrayList()
            {
               appraisal1.Text,
               appraisal2.Text,
               appraisal3.Text,
               appraisal4.Text,
               appraisal5.Text,
               appraisal6.Text,
               appraisal7.Text

            };

            ArrayList ArrayCredit = new ArrayList()
            {
              credit1.Text,
              credit2.Text,
              credit3.Text,
              credit4.Text,
              credit5.Text,
              credit6.Text,
              credit7.Text
            };
            for (int i = 0; i < 7; i++)
            {
                if ((string)ArrayCredit[i] == "" && (string)ArrayPoint[i] == "")
                {
                    count++;
                }
            }
            if (count == 7)
            {
                await Task.Run(() => MessageBox.Show("Դուք ոչինչ չեք մուտքագրել !!!"));
            }
            string Points = string.Empty;
            string Credit = string.Empty;
            //SumPoint += Convert.ToSingle(appraisal1.Text) + Convert.ToSingle(appraisal2.Text) + Convert.ToSingle(appraisal3.Text) + Convert.ToSingle(appraisal4.Text) + Convert.ToSingle(appraisal5.Text) + Convert.ToSingle(appraisal6.Text) + Convert.ToSingle(appraisal7.Text);
            //SumCredit += Convert.ToSingle(credit1.Text) + Convert.ToSingle(credit2.Text) + Convert.ToSingle(credit3.Text) + Convert.ToSingle(credit4.Text) + Convert.ToSingle(credit5.Text) + Convert.ToSingle(credit6.Text) + Convert.ToSingle(credit7.Text);
            for (int i = 0; i < 7; i++)
            {

                if (ArrayCredit[i].ToString() != "" && ArrayPoint[i].ToString() != "")
                {
                    try
                    {
                        SumPoint += Convert.ToSingle(ArrayPoint[i]) * Convert.ToSingle(ArrayCredit[i]);
                        LikPoint += Convert.ToSingle(ArrayPoint[i]);
                    }
                    catch (Exception)
                    {
                        await Task.Run(() => MessageBox.Show("Մուտք է արված սխալ սիմվոլ !!!"));
                        goto L;
                    }

                }
                else continue;
            }
            for (int i = 0; i < ArrayCredit.ToArray().Length; i++)
            {
                if (ArrayCredit[i].ToString() != "")
                {
                    try
                    {
                        SumCredit += Convert.ToSingle(ArrayCredit[i]);
                    }
                    catch (Exception)
                    {
                        await Task.Run(() => MessageBox.Show("Մուտք է արված սխալ սիմվոլ !!!"));
                        goto L;
                    }


                }
            }
            Calculator = SumPoint / SumCredit;
            DataSaving(Calculator);

            await Task.Run(() => MessageBox.Show($"Հարգելի {Name} Ձեր ՄՈԳ-ը կազմում է`" + Calculator.ToString()));
            L: await Task.Run(() => MessageBox.Show($"{Name} կարող եք կրկին հաշվել!!!"));
        }


        private async void Facebook(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => Process.Start("https://web.facebook.com/VANHAKOBYAN"));
        }

        private async void GitHub(object sender, RoutedEventArgs e)
        {

            await Task.Run(() => Process.Start("https://github.com/VanHakobyan"));
        }

        private async void Autor(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => MessageBox.Show("Ծրագրի հեղինակն է Վան Հակոբյանը"));
        }

        private void UserName_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e) => UserName.Text = null;


       private void ShowList_Click(object sender, RoutedEventArgs e) => new Results().Show();

    }
}
