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

            int [] intValores = new int[3] {Convert.ToInt16(nudValueOfA.Value), Convert.ToInt16(nudValueOfB.Value), Convert.ToInt16(nudValueOfC.Value) };
            
            if (intValores[0] == 0)
            {
                MessageBox.Show("That's not a second degree equation", "Absence of quadratic term", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //If B is empty.
                if (intValores[1] != 0)
                {
                    string[] strValores = new string[3];

                    for (int i = 0; i < intValores.Length; i++)
                    {
                        if (intValores[i] < 0)
                        {
                            strValores[i] = $" - {intValores[i]} ";
                        }
                        else if (intValores[i] > 0)
                        {
                            strValores[i] = $" + {intValores[i]} ";
                        }
                        else
                        {
                            strValores[i] = " ";
                        }
                    }

                    //Starting
                    int intSquareOfB = intValores[1] * intValores[1];
                    int intDiscriminant = intSquareOfB - 4 * intValores[0] * intValores[2];

                    if (intDiscriminant < 0)
                    {
                        ShowingTheDiscriminantCalculation(intSquareOfB, intValores, intDiscriminant);

                        //Changing the texts
                        ChangingTheTextOfTheTextBox(txtTheEquationDescribedWas, intValores[0] < 0 ? $"-{intValores[0]}x²{strValores[1]} " : $"");

                        //Turning on the visibility of certains textboxes
                        TurningOnTheVisibility(txtTheEquationDescribedWas);
                        TurningOnTheVisibility(txtTheEquation);
                        TurningOnTheVisibility(txtTheTypeIs);
                        TurningOnTheVisibility(txtTheType);
                        TurningOnTheVisibility(txtTheDiscriminantIs);
                        TurningOnTheVisibility(txtTheDiscriminant);
                        TurningOnTheVisibility(txtResultDescription);
                    }
                    else if (intDiscriminant > 0)
                    {
                        ShowingTheDiscriminantCalculation(intSquareOfB, intValores, intDiscriminant);
                    }
                    else
                    {
                        ShowingTheDiscriminantCalculation(intSquareOfB, intValores, intDiscriminant);
                    }
                }//If C is empty.
                else if (intValores[2] != 0)
                {
                    string[] strValores = new string[3];

                    for (int i = 0; i < intValores.Length; i++)
                    {
                        if (intValores[i] < 0)
                        {
                            strValores[i] = $" - {intValores[i]} ";
                        }
                        else if (intValores[i] > 0)
                        {
                            strValores[i] = $" + {intValores[i]} ";
                        }
                        else
                        {
                            strValores[i] = " ";
                        }
                    }

                    //Starting
                    int intSquareOfB = intValores[1] * intValores[1];
                    int intDiscriminant = intSquareOfB - 4 * intValores[0] * intValores[2];

                    if (intDiscriminant < 0)
                    {
                        ShowingTheDiscriminantCalculation(intSquareOfB, intValores, intDiscriminant);

                        //Changing the texts
                        ChangingTheTextOfTheTextBox(txtTheEquationDescribedWas, intValores[0] < 0 ? $"-{intValores[0]}x²{strValores[1]} " : $"");

                        //Turning on the visibility of certains textboxes
                        TurningOnTheVisibility(txtTheEquationDescribedWas);
                        TurningOnTheVisibility(txtTheEquation);
                        TurningOnTheVisibility(txtTheTypeIs);
                        TurningOnTheVisibility(txtTheType);
                        TurningOnTheVisibility(txtTheDiscriminantIs);
                        TurningOnTheVisibility(txtTheDiscriminant);
                        TurningOnTheVisibility(txtResultDescription);
                    }
                    else if (intDiscriminant > 0)
                    {
                        ShowingTheDiscriminantCalculation(intSquareOfB, intValores, intDiscriminant);
                    }
                    else
                    {
                        ShowingTheDiscriminantCalculation(intSquareOfB, intValores, intDiscriminant);
                    }
                }
                else
                {
                    MessageBox.Show("Please introduce at least more 1 term", "Absence of any other term", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
