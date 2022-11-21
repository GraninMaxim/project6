using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace project6
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

        Triad triad1;
        Triad triad2;

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            inputValue1.Text = null;
            inputValue2.Text = null;
            inputValue3.Text = null;
            inputValueA.Text = null;
            inputValueB.Text = null;
            inputValueC.Text = null;
            amount1.Text = null;
            amount2.Text = null;
            triad1.ClearTriad();
            triad2.ClearTriad();
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Compare_Click(compare, null);
            }
        }

        private void About_Program_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработать операции определения равенства/неравенства " +
                "чисел true/false. Разработать операции проверки полного равенства/неравенства " +
                "чисел в триадах (a1,b1,c1) == (a2,b2,c2)", "О программе",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Compare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint value1 = uint.Parse(inputValue1.Text);
                uint value2 = uint.Parse(inputValue2.Text);
                uint value3 = uint.Parse(inputValue3.Text);
                uint valueA = uint.Parse(inputValueA.Text);
                uint valueB = uint.Parse(inputValueB.Text);
                uint valueC = uint.Parse(inputValueC.Text);

                triad1 = new Triad(value1, value2, value3);
                triad2 = new Triad(valueA, valueB, valueC);
                if (triad1 == triad2)
                {
                    MessageBox.Show("Тройки чисел равны", "Результат", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
                else MessageBox.Show("Тройки чисел не равны", "Результат", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calculate_and_Compare_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                uint value1 = uint.Parse(inputValue1.Text);
                uint value2 = uint.Parse(inputValue2.Text);
                uint value3 = uint.Parse(inputValue3.Text);
                uint valueA = uint.Parse(inputValueA.Text);
                uint valueB = uint.Parse(inputValueB.Text);
                uint valueC = uint.Parse(inputValueC.Text);

                triad1 = new Triad(value1, value2, value3);
                triad2 = new Triad(valueA, valueB, valueC);

                amount1.Text = triad1.Amount().ToString();
                amount2.Text = triad2.Amount().ToString();
                if (triad1 > triad2) MessageBox.Show("Сумма первой тройки больше суммы второй", "Результат", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                else MessageBox.Show("Сумма первой тройки меньше суммы второй", "Результат", MessageBoxButton.OK, MessageBoxImage.Asterisk);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Triad1_Check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint value1 = uint.Parse(inputValue1.Text);
                uint value2 = uint.Parse(inputValue2.Text);
                uint value3 = uint.Parse(inputValue3.Text);

                triad1 = new Triad(value1, value2, value3);

                if (triad1) MessageBox.Show("Числа в первой тройке равны", "Результат", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                else MessageBox.Show("Числа в первой тройке не равны", "Результат", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Triad2_Check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint valueA = uint.Parse(inputValueA.Text);
                uint valueB = uint.Parse(inputValueB.Text);
                uint valueC = uint.Parse(inputValueC.Text);

                triad2 = new Triad(valueA, valueB, valueC);

                if (triad2) MessageBox.Show("Числа во второй тройке равны", "Результат", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                else MessageBox.Show("Числа во второй тройке не равны", "Результат", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
