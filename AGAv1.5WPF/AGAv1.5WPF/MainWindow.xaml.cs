using System;
using System.Collections;
using System.Diagnostics;
using System.Windows;

namespace AGAv1._5WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void calculator_Click(object sender, RoutedEventArgs e)
        {
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
                if ((string)ArrayCredit[i]=="" && (string)ArrayPoint[i]=="")
                {
                    count++;
                }
            }
            if (count==7)
            {
                MessageBox.Show("Դուք ոչինչ չեք մուտքագրել !!!");
            }
            string Points = string.Empty;
             string Credit = string.Empty;
            //SumPoint += Convert.ToSingle(appraisal1.Text) + Convert.ToSingle(appraisal2.Text) + Convert.ToSingle(appraisal3.Text) + Convert.ToSingle(appraisal4.Text) + Convert.ToSingle(appraisal5.Text) + Convert.ToSingle(appraisal6.Text) + Convert.ToSingle(appraisal7.Text);
            //SumCredit += Convert.ToSingle(credit1.Text) + Convert.ToSingle(credit2.Text) + Convert.ToSingle(credit3.Text) + Convert.ToSingle(credit4.Text) + Convert.ToSingle(credit5.Text) + Convert.ToSingle(credit6.Text) + Convert.ToSingle(credit7.Text);
            for (int i = 0; i < 7; i++)
            {

                if (ArrayCredit[i].ToString() != "" && ArrayPoint[i].ToString() !="" )
                {
                    try
                    {
                        SumPoint += Convert.ToSingle(ArrayPoint[i]) * Convert.ToSingle(ArrayCredit[i]);
                        LikPoint += Convert.ToSingle(ArrayPoint[i]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Մուտք է արված սխալ սիմվոլ !!!");
                        goto L;
                    }
                   
                }
                else continue;
            }
            for (int i = 0; i < ArrayCredit.ToArray().Length; i++)
            {
                if (ArrayCredit[i].ToString()!="")
                {
                    try
                    {
                        SumCredit += Convert.ToSingle(ArrayCredit[i]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Մուտք է արված սխալ սիմվոլ !!!");
                        goto L;
                    }
                   

                }
            }
            Calculator = SumPoint / SumCredit;
            MessageBox.Show(Calculator.ToString());
            L: MessageBox.Show("Կրկին կարող եք փորձել !!!");
        }

      
        private void Facebook(object sender, RoutedEventArgs e)
        {
            Process.Start("https://web.facebook.com/VANHAKOBYAN");
        }

        private void GitHub(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/VanHakobyan/AGA");
        }

        private void Autor(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ծրագրի հեղինակ ՝ Վան Հակոբյան");
        }
    }
}
