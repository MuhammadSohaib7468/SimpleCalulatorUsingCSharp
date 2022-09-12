using System.Data;

namespace Simple_Caculator
{
    public partial class Form1 : Form
    {
        private String Text_Current_Operand = "";
        private String Text_Previous_Operand;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }


        //
        // NUMERIC BUTTONS
        //
        private void Zero_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "0";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void One_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "1";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Two_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "2";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Three_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "3";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Four_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "4";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Five_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "5";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Six_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "6";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Seven_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "7";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Eight_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "8";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Nine_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "9";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Decimal_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + ".";
            Current_Operand.Text = Text_Current_Operand;
        }


        //
        // ARITHMETIC OPERATION
        //
        private void Addition_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + " + ";
            Current_Operand.Text = Text_Current_Operand;
        }

        
        private void Minus_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + " - ";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Multiplication_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + " * ";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Division_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + " / ";
            Current_Operand.Text = Text_Current_Operand;
        }

        //
        // OPEN CLOSE BRACKETS BUTTON
        //
        private void Open_Bracket_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + "(";
            Current_Operand.Text = Text_Current_Operand;
        }

        private void Close_Bracket_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = Text_Current_Operand + ")";
            Current_Operand.Text = Text_Current_Operand;
        }

        
        //
        // CLEAR BUTTON
        //
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Text_Current_Operand = "";
            Text_Previous_Operand = "";
            Current_Operand.Text = Text_Current_Operand;
            Previous_Operand.Text = Text_Previous_Operand;
        }

        //
        // EQUAL BUTTON
        //
        private void Equals_Button_Click(object sender, EventArgs e)
        {
            Previous_Operand.Text = Text_Current_Operand + " = ";
            var v = dt.Compute(Text_Current_Operand, "");
            Current_Operand.Text = Convert.ToString(v);
        }


        //
        // NUMERIC BUTTONS STYLING
        //
        private void Numeric_Buttons_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Cyan;
        }
        private void Numeric_Buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(51, 51, 51);
        }


        //
        // OPERATION BUTTONS STYLING
        //
        private void Operation_Buttons_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Cyan;
        }

        private void Operation_Buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(26, 63, 75);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (Current_Operand.Text != string.Empty)
            {
                int txtlength = Current_Operand.Text.Length;
                if (txtlength != 0)
                {
                    Current_Operand.Text = Current_Operand.Text.Remove(txtlength - 1);
                    Text_Current_Operand = Text_Current_Operand.Remove(txtlength - 1);

                }
                else
                {
                    Current_Operand.Text = 0.ToString();
                    Text_Current_Operand = 0.ToString();
                }
            }
        }
    }
}