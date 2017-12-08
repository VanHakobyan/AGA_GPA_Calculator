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
        public async void DataSaving(float calculator)
        {
            conStr.DataSource = @"(localdb)\MSSQLLocalDB";
            conStr.InitialCatalog = "AGA";
            conStr.IntegratedSecurity = true;
            var connetion = new SqlConnection(conStr.ConnectionString);
            var cmdText = "INSERT INTO Students(Name,AGA,Date) VALUES (@UserName,@calculator,@date)";
            var cmd = new SqlCommand(cmdText, connetion);
            //cmd.Parameters.AddWithValue("ID", 1);
            cmd.Parameters.AddWithValue("UserName", UserName.Text);
            cmd.Parameters.AddWithValue("calculator", calculator);
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
                connetion.Close();
            }
        }

        private async void Calculator_Click(object sender, RoutedEventArgs e)
        {
            var name = UserName.Text;
            float sumPoint = 0;
            float sumCredit = 0;
            var count = 0;
            var arrayPoint = new ArrayList
            {
               appraisal1.Text,
               appraisal2.Text,
               appraisal3.Text,
               appraisal4.Text,
               appraisal5.Text,
               appraisal6.Text,
               appraisal7.Text
            };

            var arrayCredit = new ArrayList
            {
              credit1.Text,
              credit2.Text,
              credit3.Text,
              credit4.Text,
              credit5.Text,
              credit6.Text,
              credit7.Text
            };
            for (var i = 0; i < 7; i++) if ((string)arrayCredit[i] == string.Empty && (string)arrayPoint[i] == String.Empty) count++;
            if (count == 7) await Task.Run(() => MessageBox.Show("Դուք ոչինչ չեք մուտքագրել !!!"));
            for (var i = 0; i < 7; i++)
            {
                if (arrayCredit[i].ToString() != "" && arrayPoint[i].ToString() != "")
                {
                    try
                    {
                        sumPoint += Convert.ToSingle(arrayPoint[i]) * Convert.ToSingle(arrayCredit[i]);
                    }
                    catch (Exception)
                    {
                        await Task.Run(() => MessageBox.Show("Մուտք է արված սխալ սիմվոլ !!!"));
                        goto L;
                    }
                }
                else continue;
            }
            for (var i = 0; i < arrayCredit.ToArray().Length; i++)
            {
                if (arrayCredit[i].ToString() == String.Empty) continue;
                try
                {
                    sumCredit += Convert.ToSingle(arrayCredit[i]);
                }
                catch (Exception)
                {
                    await Task.Run(() => MessageBox.Show("Մուտք է արված սխալ սիմվոլ !!!"));
                    goto L;
                }
            }
            var calculatorLocal = sumPoint / sumCredit;
            DataSaving(calculatorLocal);

            await Task.Run(() => MessageBox.Show($"Հարգելի {name} Ձեր ՄՈԳ-ը կազմում է`" + calculatorLocal));
            L: await Task.Run(() => MessageBox.Show($"{name} կարող եք կրկին հաշվել!!!"));
        }


        private async void Facebook(object sender, RoutedEventArgs e) => await Task.Run(() => Process.Start("https://web.facebook.com/VANHAKOBYAN"));

        private async void GitHub(object sender, RoutedEventArgs e) => await Task.Run(() => Process.Start("https://github.com/VanHakobyan"));

        private async void Autor(object sender, RoutedEventArgs e) => await Task.Run(() => MessageBox.Show("Ծրագրի հեղինակն է Վան Հակոբյանը"));

        private void UserName_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e) => UserName.Text = null;


        private void ShowList_Click(object sender, RoutedEventArgs e) => new Results().Show();

    }
}
