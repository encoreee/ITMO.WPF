using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Calculator;
using SimpleCalculator;

namespace WpfAppCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";
        List<Button> button = new List<Button>();

        private BackgroundWorker backgroundWorker1;
        Button KeyBGFact = new Button { Content = "! in background" };

        public MainWindow()
        {
            InitializeComponent();
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            OutputDisplay.Text = "0";

        }

        //
        // Numeric key click methods.
        //

        protected void KeyNine_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        protected void KeyEight_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        protected void KeySeven_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        protected void KeySix_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        protected void KeyFive_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        protected void KeyFour_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        protected void KeyThree_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        protected void KeyTwo_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        protected void KeyOne_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        protected void KeyZero_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        protected void KeyPoint_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }
        protected void KeyEqual_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual().Replace(",", ".");
            CalcEngine.CalcReset();
        }
        protected void KeyClear_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        protected void KeyExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        protected void KeyDate_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.GetDate();
            CalcEngine.CalcReset();
        }


        protected void KeyPlus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        protected void KeyMinus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }

        protected void KeyMultiply_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }
        protected void KeyDivide_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }
        protected void KeySign_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }


        protected void KeyExponent_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eExponentiation);
        }

        protected void KeySqrt_Click(object sender, System.EventArgs e)
        {
            try
            {
                CalcEngine.CalcUnOperation(CalcEngine.Operator.eSqrt);
                OutputDisplay.Text = CalcEngine.CalcEqual();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат!");
            }
        }

        protected void KeyInv_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eInv);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }

        protected void KeySquar_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eSquar);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }

        protected void KeySqrtKub_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eSqrtKub);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }

        protected void KeyFact_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eFact);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }

        protected void KeyBGFact_Click(object sender, System.EventArgs e)
        {
            if (!(OutputDisplay.Text == ""))
            {
                try
                {

                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат!");
                }
            }
        }

        private void engineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (StandartItem.IsChecked == true)
            {

                //update actions
                StandartItem.IsChecked = false;
                engineeringItem.IsChecked = true;
                //update actions

                for (int i = 0; i < 2; i++)
                {
                    addRow();
                }


                Button KeyExponet = new Button { Content = "^" };
                Grid.SetColumn(KeyExponet, 0);
                Grid.SetRow(KeyExponet, commonGrid.RowDefinitions.Count - 2);
                KeyExponet.AddHandler(Button.ClickEvent, new RoutedEventHandler(KeyExponent_Click));
                KeyExponet.Margin = new Thickness(1);
                commonGrid.Children.Add(KeyExponet);
                button.Add(KeyExponet);

                Button KeySqrt = new Button { Content = "Sqrt" };
                Grid.SetColumn(KeySqrt, 1);
                Grid.SetRow(KeySqrt, commonGrid.RowDefinitions.Count - 2);
                KeySqrt.AddHandler(Button.ClickEvent, new RoutedEventHandler(KeySqrt_Click));
                KeySqrt.Margin = new Thickness(1);
                commonGrid.Children.Add(KeySqrt);
                button.Add(KeySqrt);

                Button KeyInv = new Button { Content = "Inv" };
                Grid.SetColumn(KeyInv, 2);
                Grid.SetRow(KeyInv, commonGrid.RowDefinitions.Count - 2);
                KeyInv.AddHandler(Button.ClickEvent, new RoutedEventHandler(KeyInv_Click));
                KeyInv.Margin = new Thickness(1);
                commonGrid.Children.Add(KeyInv);
                button.Add(KeyInv);

                Button KeySquar = new Button { Content = "Squar" };
                Grid.SetColumn(KeySquar, 3);
                Grid.SetRow(KeySquar, commonGrid.RowDefinitions.Count - 2);
                KeySquar.AddHandler(Button.ClickEvent, new RoutedEventHandler(KeySquar_Click));
                KeySquar.Margin = new Thickness(1);
                commonGrid.Children.Add(KeySquar);
                button.Add(KeySquar);


                Button KeyFact = new Button { Content = "!" };
                Grid.SetColumn(KeyFact, 4);
                Grid.SetRow(KeyFact, commonGrid.RowDefinitions.Count - 2);
                KeyFact.AddHandler(Button.ClickEvent, new RoutedEventHandler(KeyFact_Click));
                KeyFact.Margin = new Thickness(1);
                commonGrid.Children.Add(KeyFact);
                button.Add(KeyFact);

                Button KeySqrtKub = new Button { Content = "Sqrt3" };
                Grid.SetColumn(KeySqrtKub, 5);
                Grid.SetRow(KeySqrtKub, commonGrid.RowDefinitions.Count - 2);
                KeySqrtKub.AddHandler(Button.ClickEvent, new RoutedEventHandler(KeySqrtKub_Click));
                KeySqrtKub.Margin = new Thickness(1);
                commonGrid.Children.Add(KeySqrtKub);
                button.Add(KeySqrtKub);


                Button KeyBGFact = new Button { Content = "! in background" };
                Grid.SetColumn(KeyBGFact, 0);
                Grid.SetRow(KeyBGFact, commonGrid.RowDefinitions.Count - 1);
                Grid.SetColumnSpan(KeyBGFact, 6);
                KeyBGFact.AddHandler(Button.ClickEvent, new RoutedEventHandler(KeyBGFact_Click));
                KeyBGFact.Margin = new Thickness(1);
                commonGrid.Children.Add(KeyBGFact);
                button.Add(KeyBGFact);

                setEqualWidth();
            }

        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (engineeringItem.IsChecked == true)
            {
                //update actions
                engineeringItem.IsChecked = false;
                StandartItem.IsChecked = true;
                //update actions

                commonGrid.Children.Remove(KeyBGFact);

                for (int i = 0; i < button.Count; i++)
                {
                    commonGrid.Children.Remove(button[i]);
                }

                for (int i = 0; i < 2; i++)
                {
                    deleteRow();
                }
                setEqualWidth();
            }
        }

        private void addRow()
        {
            RowDefinition row = new RowDefinition();
            row.Height = new GridLength(70);
            this.Height += row.Height.Value;
            commonGrid.RowDefinitions.Insert(commonGrid.RowDefinitions.Count - 1, row);
        }

        private void deleteRow()
        {
            RowDefinition row = commonGrid.RowDefinitions.Last();

            this.Height -= row.Height.Value;
            commonGrid.RowDefinitions.Remove(row);

        }

        private void setEqualWidth()
        {
            for (int i = 0; i < commonGrid.ColumnDefinitions.Count - 1; i++)
            {
                commonGrid.ColumnDefinitions.ElementAt(i).Width = new GridLength(commonGrid.ActualWidth / 6);
            }
        }



        private void OutputDisplay_TextInput(object sender, TextCompositionEventArgs e)
        {



            e.Handled = !((Char.IsDigit(e.Text, 0) || (e.Text == ".")));
        }

        private void CalcMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CalcRoots calcRoots = new CalcRoots();
            calcRoots.Show();
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = CalcEngine.CalcEqual();
            Result res = new Result();
            res.result = result;
            res.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            res.TopMost = true;
            res.Show();

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            CalcEngine.CalcUnOperation(CalcEngine.Operator.eFact);
            System.Threading.Thread.Sleep(1000);

            //  res.TopMost = true;
        }
        //
        // End the program.
        //
    }

}
