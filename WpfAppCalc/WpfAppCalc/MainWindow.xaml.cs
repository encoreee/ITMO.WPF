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

        private BackgroundWorker backgroundWorker1;

        public MainWindow()
        {

            InitializeComponent();

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
            OutputDisplay.Text = CalcEngine.CalcEqual();
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

                this.Height += 70;
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(70);
                commonGrid.RowDefinitions.Insert(commonGrid.RowDefinitions.Count - 1, row);

                Button KeyExponet = new Button { Content = "^" };
                
                Grid.SetColumn(KeyExponet, 0);
                Grid.SetRow(KeyExponet, commonGrid.RowDefinitions.Count - 1);
                commonGrid.Children.Add(KeyExponet);

                //this.KeyExponet.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                //this.KeyExponet.ForeColor = System.Drawing.Color.Blue;
                //this.KeyExponet.Location = new System.Drawing.Point(12, 292);
                //this.KeyExponet.Name = "KeyExponet";
                //this.KeyExponet.Size = new System.Drawing.Size(40, 40);
                //this.KeyExponet.TabIndex = 21;
                //this.KeyExponet.TabStop = false;
                //this.KeyExponet.Text = "^";
                //this.KeyExponet.Click += new System.EventHandler(this.KeyExponent_Click);
                //this.toolTip1.SetToolTip(KeyExponet, "Exponentiation operation");
                //this.Controls.Add(this.KeyExponet);

                //this.KeySqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                //this.KeySqrt.ForeColor = System.Drawing.Color.Blue;
                //this.KeySqrt.Location = new System.Drawing.Point(60, 292);
                //this.KeySqrt.Name = "KeySqrt";
                //this.KeySqrt.Size = new System.Drawing.Size(40, 40);
                //this.KeySqrt.TabIndex = 22;
                //this.KeySqrt.TabStop = false;
                //this.KeySqrt.Text = "Sqrt";
                //this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
                //this.toolTip1.SetToolTip(KeySqrt, "Square root");
                //this.Controls.Add(this.KeySqrt);

                //this.KeyInv.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
                //this.KeyInv.ForeColor = System.Drawing.Color.Blue;
                //this.KeyInv.Location = new System.Drawing.Point(108, 292);
                //this.KeyInv.Name = "KeyInv";
                //this.KeyInv.Size = new System.Drawing.Size(40, 40);
                //this.KeyInv.TabIndex = 23;
                //this.KeyInv.TabStop = false;
                //this.KeyInv.Text = "Inv";
                //this.KeyInv.Click += new System.EventHandler(this.KeyInv_Click);
                //this.toolTip1.SetToolTip(KeyInv, "Inversion operation");
                //this.Controls.Add(this.KeyInv);

                //this.KeySquar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                //this.KeySquar.ForeColor = System.Drawing.Color.Blue;
                //this.KeySquar.Location = new System.Drawing.Point(156, 292);
                //this.KeySquar.Name = "KeySquar";
                //this.KeySquar.Size = new System.Drawing.Size(40, 40);
                //this.KeySquar.TabIndex = 24;
                //this.KeySquar.TabStop = false;
                //this.KeySquar.Text = "Squar";
                //this.toolTip1.SetToolTip(KeySquar, "Squaring operation");
                //this.KeySquar.Click += new System.EventHandler(this.KeySquar_Click);
                //this.Controls.Add(this.KeySquar);

                //this.KeyFact.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                //this.KeyFact.ForeColor = System.Drawing.Color.Blue;
                //this.KeyFact.Location = new System.Drawing.Point(204, 292);
                //this.KeyFact.Name = "KeyFact";
                //this.KeyFact.Size = new System.Drawing.Size(56, 40);
                //this.KeyFact.TabIndex = 25;
                //this.KeyFact.TabStop = false;
                //this.KeyFact.Text = "!";
                //this.toolTip1.SetToolTip(this.KeyFact, "Calculate factorial");
                //this.KeyFact.Click += new System.EventHandler(this.KeyFact_Click);
                //this.Controls.Add(this.KeyFact);


                //this.KeySqrtKub.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                //this.KeySqrtKub.ForeColor = System.Drawing.Color.Blue;
                //this.KeySqrtKub.Location = new System.Drawing.Point(12, 340);
                //this.KeySqrtKub.Name = "KeySqrtKub";
                //this.KeySqrtKub.Size = new System.Drawing.Size(40, 40);
                //this.KeySqrtKub.TabIndex = 26;
                //this.KeySqrtKub.TabStop = false;
                //this.KeySqrtKub.Text = "Sqrt3";
                //this.KeySqrtKub.Click += new System.EventHandler(this.KeySqrtKub_Click);
                //this.toolTip1.SetToolTip(KeySqrtKub, "Сubic root operation");
                //this.Controls.Add(this.KeySqrtKub);

                //this.KeyBGFact.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                //this.KeyBGFact.ForeColor = System.Drawing.Color.Blue;
                //this.KeyBGFact.Location = new System.Drawing.Point(60, 340);
                //this.KeyBGFact.Name = "KeyBGFact";
                //this.KeyBGFact.Size = new System.Drawing.Size(200, 40);
                //this.KeyBGFact.TabIndex = 26;
                //this.KeyBGFact.TabStop = false;
                //this.KeyBGFact.Text = "! in background";
                //this.KeyBGFact.Click += new System.EventHandler(this.KeyBGFact_Click);
                //this.toolTip1.SetToolTip(KeySqrtKub, "Calculate factorial in backgoung process");
                //this.Controls.Add(this.KeyBGFact);


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


                //this.Controls.Remove(this.KeyExponet);
                //this.Controls.Remove(this.KeySqrt);
                //this.Controls.Remove(this.KeyInv);
                //this.Controls.Remove(this.KeySquar);
                //this.Controls.Remove(this.KeyFact);
                //this.Controls.Remove(this.KeySqrtKub);
            }
        }



        //
        // End the program.
        //
    }
}
