using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double value = 0;
        private string operation = "";
        private bool operationPressed = false;
       

    //    private string input = string.Empty;
    //    private string operand1 = string.Empty;
    //    private string operand2 = string.Empty;
    //    private char operation;
    //    private double result = 0.0;
    //    private void btn1_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn1.Text;
      
    //    }

        private void countMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountingMoneyUI aUi = new CountingMoneyUI();
            aUi.Show();
            this.Hide();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((txtdisplay.Text == "0")||(operationPressed))
            {
                txtdisplay.Clear();
            }

            txtdisplay.Text = txtdisplay.Text + "0"; //2nd system to insert from buttom
            

        }

    //    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    //    {
    //        Application.Exit();
    //    }

    //    private void btnC_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = string.Empty;
    //    }

    //    private void btn2_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn2.Text;
            
    //    }

        

        private void btn3_Click_1(object sender, EventArgs e)
        {
            if ((txtdisplay.Text == "0") || (operationPressed))
            {
                txtdisplay.Clear();
            }
            txtdisplay.Text = txtdisplay.Text + btn3.Text;  //1st system to insert from buttom
            
        }

    //    private void btnAdd_Click(object sender, EventArgs e)
    //    {
    //        //txtdisplay.Text = txtdisplay.Text + btnAdd.Text;
    //        operand1 = input;
    //        operation = '+';
    //        input = string.Empty;
    //    }


        private void btn4_Click_1(object sender, EventArgs e)
        {
            if ((txtdisplay.Text == "0") || (operationPressed))
            {
                txtdisplay.Clear();
            }
            txtdisplay.Text = txtdisplay.Text + btn4.Text; //1st system to insert from buttom
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtdisplay.Text == "0") || (operationPressed))
            {
                txtdisplay.Clear();
            }
            txtdisplay.Text = txtdisplay.Text + "1"; //2nd system to insert from buttom
            
        }

        private void btn_Click(object sender, EventArgs e)  //3nd system to insert from buttom
        {
            if ((txtdisplay.Text == "0") || (operationPressed))
            {
                txtdisplay.Clear();
            }
            Button b = (Button) sender;   //now call them in other button
            txtdisplay.Text = txtdisplay.Text + b.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            operation = b.Text;
            value = double.Parse(txtdisplay.Text);
            operationPressed = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtdisplay.Text = (value + double.Parse(txtdisplay.Text)).ToString();
                    break;
                case "-":
                    txtdisplay.Text = (value - double.Parse(txtdisplay.Text)).ToString();
                    break;
                case "*":
                    txtdisplay.Text = (value * double.Parse(txtdisplay.Text)).ToString();
                    break;
                case "/":
                    txtdisplay.Text = (value / double.Parse(txtdisplay.Text)).ToString();
                    break;
                //case "%":
                //    txtdisplay.Text = (value  double.Parse(txtdisplay.Text)).ToString();
                //    break;
                default:
                    break;
            }
            operationPressed = false;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            if ((txtdisplay.Text == "0") || (operationPressed))
            {
                txtdisplay.Clear();
            }
            txtdisplay.Text = txtdisplay.Text + "1"; //2nd system to insert from buttom
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

    //    private void btn5_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn5.Text;
    //    }

    //    private void btn6_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn6.Text;
    //    }

    //    private void btn7_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn7.Text;
    //    }

    //    private void btn8_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn8.Text;
    //    }

    //    private void btn9_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn9.Text;
    //    }

    //    private void btn0_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn0.Text;
    //    }

    //    private void btn00_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btn00.Text;
            
    //    }

    //    private void btnDot_Click(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = txtdisplay.Text + btnDot.Text;
    //    }

    //    private void btnDev_Click(object sender, EventArgs e)
    //    {
    //        //txtdisplay.Text = txtdisplay.Text + btnDev.Text;
    //        operand1 = input;
    //        operation = '/';
    //        input = string.Empty;


    //    }

    //    private void btnMul_Click(object sender, EventArgs e)
    //    {
    //        //txtdisplay.Text = txtdisplay.Text + btnMul.Text;
    //        operand1 = input;
    //        operation = '*';
    //        input = string.Empty;
    //    }

    //    private void btnSub_Click(object sender, EventArgs e)
    //    {
    //        //txtdisplay.Text = txtdisplay.Text + btnSub.Text;
    //        operand1 = input;
    //        operation = '-';
    //        input = string.Empty;
    //    }

    //    private void btnEqual_Click(object sender, EventArgs e)
    //    {
    //        operand2 = input;
    //        double num1, num2;
    //        double.TryParse(operand1, out num1 );
    //        double.TryParse(operand2, out num2);
    //        if(operation=='+')
    //        {
    //            result = num1 + num2;
    //            txtdisplay.Text = result.ToString();
    //        }
    //        else if(operation=='-')
    //        {
    //            result = num1 - num2;
    //            txtdisplay.Text = result.ToString();
    //        }
    //        else if(operation=='*')
    //        {
    //            result = num1*num2;
    //            txtdisplay.Text = result.ToString();
    //        }
    //        else if(operation=='/')
    //        {
    //            if(num2!=0)
    //            {
    //                result = num1/num2;
    //                txtdisplay.Text = result.ToString();
    //            }
    //            else
    //            {
    //                return;
    //            }
    //        }
    //    }

    //    private void Form1_Load(object sender, EventArgs e)
    //    {
    //        txtdisplay.Text = "0";
    //    }
    }
}
