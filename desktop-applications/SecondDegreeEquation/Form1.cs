using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondDegreeEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void TurningOffTheVisibility(TextBox txtBox)
        {
            if (txtBox.Visible == true)
            {
                txtBox.Visible = false;
            }
        }

        public void TurningOnTheVisibility(TextBox txtBox)
        {
            if (txtBox.Visible == false)
            {
                txtBox.Visible = true;
            }
        }

        public void ChangingTheTextOfTheTextBox(TextBox txtBox, string strText)
        {
            txtBox.Text = strText;
        }

        public void ShowingTheDiscriminantCalculation(int intSquareOfB, int[] intValores, int intDiscriminant)
        {
            MessageBox.Show($"Discriminant = b² - 4 . a . c \nDiscriminant = {intSquareOfB}  - 4 x {intValores[0]} x {intValores[2]} \nDiscriminant = {intSquareOfB}  - 4 x {intValores[0] * intValores[2]} \nDiscriminant = {intSquareOfB}  - {4 * intValores[0] * intValores[2]} \nDiscriminant = {intDiscriminant}", $"B = {intValores[1]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int CalculatingTheSquareOfB(int bValue)
        {
            int intSquareOfB = bValue * bValue;
            return intSquareOfB;
        }

        public int CalculatingTheDiscriminat(int intSquareOfB, int aValue, int cValue) 
        {
            int intDiscriminant = intSquareOfB - (4 * aValue * cValue);
            return intDiscriminant;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtTheEquationDescribedWas.Text = "The equation described was:";
            //Turning off the visibility of certains textboxes
            TurningOffTheVisibility(txtTheEquationDescribedWas);
            TurningOffTheVisibility(txtTheEquation);
            TurningOffTheVisibility(txtTheTypeIs);
            TurningOffTheVisibility(txtTheType);
            TurningOffTheVisibility(txtTheDiscriminantIs);
            TurningOffTheVisibility(txtTheDiscriminant);
            TurningOffTheVisibility(txtResultDescription);
            TurningOffTheVisibility(txtX);
            TurningOffTheVisibility(txtValueOfX);
            TurningOffTheVisibility(txtX1);
            TurningOffTheVisibility(txtValueOfX1);
            TurningOffTheVisibility(txtX2);
            TurningOffTheVisibility(txtValueOfX2);

            int [] intValues = new int[3] {Convert.ToInt16(nudValueOfA.Value), Convert.ToInt16(nudValueOfB.Value), Convert.ToInt16(nudValueOfC.Value) };
            
            if (intValues[0] == 0)
            {
                MessageBox.Show("That's not a second degree equation", "Absence of quadratic term", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //If B and C are empty.
                if (intValues[1] == 0 && intValues[2] == 0)
                {
                    MessageBox.Show("Please introduce at least more 1 term", "Absence of any other term", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    string strValueOfB;
                    string strValueOfC;

                    //String value of B
                    if (intValues[1] < 0)
                    {
                        strValueOfB = $" - {intValues[1]}x ";
                    }
                    else if (intValues[1] > 0)
                    {
                        strValueOfB = $" + {intValues[1]}x ";
                    }
                    else
                    {
                        strValueOfB = " ";
                    }

                    //String value of C
                    if (intValues[2] < 0)
                    {
                        strValueOfC = $" - {intValues[2]} ";
                    }
                    else if (intValues[2] > 0)
                    {
                        strValueOfC = $" + {intValues[2]} ";
                    }
                    else
                    {
                        strValueOfC = " ";
                    }

                    //Calculating
                    int intSquareOfB = CalculatingTheSquareOfB(intValues[1]);
                    int intDiscriminant = CalculatingTheDiscriminat(intSquareOfB, intValues[0], intValues[2]);

                    ShowingTheDiscriminantCalculation(intSquareOfB, intValues, intDiscriminant);

                    if (intDiscriminant < 0)
                    {
                        MessageBox.Show("A negative discriminant indicates that neither of the solutions are real numbers.", "The discriminant is negative", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (intDiscriminant > 0)
                    {
                        MessageBox.Show("A positive discriminant indicates that the quadratic has two distinct real number solutions.", "The discriminant is positive", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("A discriminant of zero indicates that the quadratic has a repeated real number solution.", "The discriminant is zero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ChangingTheTextOfTheTextBox(txtTheDiscriminant, $"{intDiscriminant}");

                    if ((intValues[1] == 0))
                    {
                        //Changing the texts
                        ChangingTheTextOfTheTextBox(txtTheEquation, intValues[0] < 0 ? $"-{intValues[0]}x²{strValueOfC}= 0" : $"{intValues[0]}x²{strValueOfC}= 0");
                        ChangingTheTextOfTheTextBox(txtTheType, $"ax² + c = 0");
                    }
                    else if (intValues[2] == 0)
                    {
                        //Changing the texts
                        ChangingTheTextOfTheTextBox(txtTheEquation, intValues[0] < 0 ? $"-{intValues[0]}x²{strValueOfB}= 0" : $"{intValues[0]}x²{strValueOfB}= 0");
                        ChangingTheTextOfTheTextBox(txtTheType, $"ax² + bx = 0");
                        
                    }
                    else
                    {
                        //Changing the texts
                        ChangingTheTextOfTheTextBox(txtTheEquation, intValues[0] < 0 ? $"-{intValues[0]}x²{strValueOfB[1]}{strValueOfB[2]}= 0" : $"{intValues[0]}x²{strValueOfB}{strValueOfC}= 0");
                        ChangingTheTextOfTheTextBox(txtTheType, $"ax² + bx + c = 0");
                    }

                    //Turning on the visibility of certains textboxes
                    TurningOnTheVisibility(txtTheEquationDescribedWas);
                    TurningOnTheVisibility(txtTheEquation);
                    TurningOnTheVisibility(txtTheTypeIs);
                    TurningOnTheVisibility(txtTheType);
                    TurningOnTheVisibility(txtTheDiscriminantIs);
                    TurningOnTheVisibility(txtTheDiscriminant);
                    TurningOnTheVisibility(txtResultDescription);
                }
            }
        }
    }
}
