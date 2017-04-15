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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            float AGA = 0;
            float[] ArrayPoint = new float[n];
            float[] ArrayCredit = new float[n];
            string Points = string.Empty;
            string Credit = string.Empty;
        }
    }
}
