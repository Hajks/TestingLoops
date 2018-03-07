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

namespace TestingLoops
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

        //We got 4 buttons, after clicking in one of them, TextBlock should be updated and filled according to button instruction
        //Testing conditions/operators and loops

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2; // Math.PI  class Math with PI method (PI number divided by 2) + we use double because it's floating point
            myLabel.Text = "nazwa to " + name // myLabel is my own name of TextBlock object, using method Text it lets me change text of textblock
            + "\nx jest równe " + x           // "\n" adding new line to displayed text
            + "\nd jest równe " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10) // Using conditions if/else. If variable x equals 10 then we will see message "x jest równe 10" else "x nie jest równe 10"
            {
                myLabel.Text = "x jest równe 10";
            }
            else
            {
                myLabel.Text = "x nie jest równe 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Piotrek";
            if ((someValue == 3) && (name.Equals("Krzysiek"))) // Using operator "&&" which makes that two conditions must be accepted
            {
                myLabel.Text = "Wartość jest równa 3 i imię się zgadza";
            }
            myLabel.Text = "ten wiesz zostanie wyświetlony bez względu na warunki"; // This message will be displayed anyway because it's not included into if/else instructions
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            while (count < 10)  // while variable count is under 10 keep doing this instruction
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++) // if variable "i" is lower then 5 increase variable i by 1 then do instrucion
            {
                count = count - 1;
            }
            myLabel.Text = "Odpowiedź brzmi " + count; // the anwser should be 5
        }
    }
}
