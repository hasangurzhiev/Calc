using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private double a;
        private double b;
        private string op;
        private double res;
        string t = "b";
        bool Zap = true;

     

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "0";
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            plus.IsEnabled = true;
            percent.IsEnabled = true;
            X.IsEnabled = true;
            div.IsEnabled = true;
            two_zero.IsEnabled = true;
            MRC.IsEnabled = true;
            M_minus.IsEnabled = true;
            M_plus.IsEnabled = true;
            kor.IsEnabled = true;
            CE.IsEnabled = true;
            bool Zap = true;
            label1.Text = " ";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void percent_Click(object sender, RoutedEventArgs e)
        {
            bool Zap = true;
            a = double.Parse(textBox1.Text) / 100;
            textBox1.Text = a.ToString();
        }

        private void kor_Click(object sender, RoutedEventArgs e)
        {
            Zap = true;
            a = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sqrt(a).ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            bool Zap = true;
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            op = "*";
            label1.Text = a.ToString() + op;
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            bool Zap = true;
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            op = "/";
            label1.Text = a.ToString() + op;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            op = "+";
            label1.Text = a.ToString() + op;
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            bool Zap = true;
            switch (op)
            {
                case "+":
                    {
                        b = double.Parse(textBox1.Text);
                        res = a + b;
                        textBox1.Text = res.ToString();
                        label1.Text += b;
                        a = res;
                    }
                    break;
                case "-":
                    {
                        b = double.Parse(textBox1.Text);
                        res = a - b;
                        textBox1.Text = res.ToString();
                        label1.Text += b;
                        a = res;
                    }
                    break;

                case "*":
                    {
                        b = double.Parse(textBox1.Text);
                        res = a * b;
                        textBox1.Text = res.ToString();
                        label1.Text += b;
                        a = res;
                    }
                    break;
                case "/":
                    {
                        b = double.Parse(textBox1.Text);
                        label1.Text += b;
                        if (b == 0)
                        {
                            textBox1.Text = "0";
                            button2.IsEnabled = false;
                            button3.IsEnabled = false;
                            button4.IsEnabled = false;
                            button5.IsEnabled = false;
                            button6.IsEnabled = false;
                            button7.IsEnabled = false;
                            button8.IsEnabled = false;
                            button9.IsEnabled = false;
                            plus.IsEnabled = false;
                            percent.IsEnabled = false;
                            X.IsEnabled = false;
                            div.IsEnabled = false;
                            two_zero.IsEnabled = false;
                            MRC.IsEnabled = false;
                            M_minus.IsEnabled = false;
                            M_plus.IsEnabled = true;
                            kor.IsEnabled = false;
                            
                        }
                        else
                        {
                            res = a / b;
                            textBox1.Text = res.ToString();
                            label1.Text += b;
                            a = res;
                        }
                    }
                    break;
            }
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void two_zero_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0,00";
            }
            else
            {
                textBox1.Text = textBox1.Text + "00";
            }
        }

        private void tochka_Click(object sender, RoutedEventArgs e)
        {

            if (Zap && textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + ",";
            }
            else if (Zap && textBox1.Text == "")
            {
                textBox1.Text += "0,";
                Zap = false;
            }
            Zap = false;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            bool Zap = true;
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            op = "-";
            label1.Text = a.ToString() + op;
        }
    }
}
