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

namespace Calculator
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

        private void Button_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // get the first value
           var input1 =  this.Value1.Text;
            // get the second value
            var input2 = this.Value2.Text;
            // add them
            var total = int.Parse(input1) + int.Parse(input2);
            // dislay the total to a label
            this.Answer.Content = total;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // get the first value
            var input1 = this.Value1.Text;
            // get the second value
            var input2 = this.Value2.Text;
            // subtract them
            var total = int.Parse(input1) - int.Parse(input2);
            // dislay the total to a label
            this.Answer.Content = total;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // get the first value
            var input1 = this.Value1.Text;
            // get the second value
            var input2 = this.Value2.Text;
            // multiply them
            var total = int.Parse(input1) * int.Parse(input2);
            // dislay the total to a label
            this.Answer.Content = total;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // get the first value
            var input1 = this.Value1.Text;
            // get the second value
            var input2 = this.Value2.Text;
            // divide them
            var total = int.Parse(input1) / int.Parse(input2);
            // dislay the total to a label
            this.Answer.Content = total;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            // get the first value
            var input1 = this.Value1.Text;
            // get the second value
            var input2 = this.Value2.Text;
            // mod
            var total = int.Parse(input1) % int.Parse(input2);
            // dislay the total to a label
            this.Answer.Content = total;
        }
    }
}
