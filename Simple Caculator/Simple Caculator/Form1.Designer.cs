namespace Simple_Caculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Previous_Operand = new System.Windows.Forms.TextBox();
            this.Current_Operand = new System.Windows.Forms.TextBox();
            this.Close_Bracket_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Open_Bracket_Button = new System.Windows.Forms.Button();
            this.Multiplication_Button = new System.Windows.Forms.Button();
            this.Nine_Button = new System.Windows.Forms.Button();
            this.Eight_Button = new System.Windows.Forms.Button();
            this.Seven_Button = new System.Windows.Forms.Button();
            this.Addition_Button = new System.Windows.Forms.Button();
            this.Six_Button = new System.Windows.Forms.Button();
            this.Five_Button = new System.Windows.Forms.Button();
            this.Four_Button = new System.Windows.Forms.Button();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.Three_Button = new System.Windows.Forms.Button();
            this.Two_Button = new System.Windows.Forms.Button();
            this.One_Button = new System.Windows.Forms.Button();
            this.Equals_Button = new System.Windows.Forms.Button();
            this.PI_Button = new System.Windows.Forms.Button();
            this.Zero_Button = new System.Windows.Forms.Button();
            this.Decimal_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Division_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.Previous_Operand);
            this.groupBox1.Controls.Add(this.Current_Operand);
            this.groupBox1.Location = new System.Drawing.Point(-6, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Previous_Operand
            // 
            this.Previous_Operand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Previous_Operand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Previous_Operand.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Previous_Operand.ForeColor = System.Drawing.Color.White;
            this.Previous_Operand.Location = new System.Drawing.Point(11, 14);
            this.Previous_Operand.Name = "Previous_Operand";
            this.Previous_Operand.ReadOnly = true;
            this.Previous_Operand.Size = new System.Drawing.Size(278, 22);
            this.Previous_Operand.TabIndex = 1;
            // 
            // Current_Operand
            // 
            this.Current_Operand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Current_Operand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Current_Operand.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Current_Operand.ForeColor = System.Drawing.Color.White;
            this.Current_Operand.Location = new System.Drawing.Point(6, 76);
            this.Current_Operand.Name = "Current_Operand";
            this.Current_Operand.ReadOnly = true;
            this.Current_Operand.Size = new System.Drawing.Size(283, 37);
            this.Current_Operand.TabIndex = 0;
            this.Current_Operand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Close_Bracket_Button
            // 
            this.Close_Bracket_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Close_Bracket_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Bracket_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Bracket_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close_Bracket_Button.ForeColor = System.Drawing.Color.White;
            this.Close_Bracket_Button.Location = new System.Drawing.Point(176, 121);
            this.Close_Bracket_Button.Name = "Close_Bracket_Button";
            this.Close_Bracket_Button.Size = new System.Drawing.Size(50, 45);
            this.Close_Bracket_Button.TabIndex = 1;
            this.Close_Bracket_Button.Text = ")";
            this.Close_Bracket_Button.UseVisualStyleBackColor = false;
            this.Close_Bracket_Button.Click += new System.EventHandler(this.Close_Bracket_Button_Click);
            this.Close_Bracket_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Close_Bracket_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Clear_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_Button.Location = new System.Drawing.Point(5, 121);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(50, 45);
            this.Clear_Button.TabIndex = 2;
            this.Clear_Button.Text = "C";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            this.Clear_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Clear_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(62, 121);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(50, 45);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Del";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            this.Delete_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Delete_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Open_Bracket_Button
            // 
            this.Open_Bracket_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Open_Bracket_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open_Bracket_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_Bracket_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Open_Bracket_Button.ForeColor = System.Drawing.Color.White;
            this.Open_Bracket_Button.Location = new System.Drawing.Point(119, 121);
            this.Open_Bracket_Button.Name = "Open_Bracket_Button";
            this.Open_Bracket_Button.Size = new System.Drawing.Size(50, 45);
            this.Open_Bracket_Button.TabIndex = 4;
            this.Open_Bracket_Button.Text = "(";
            this.Open_Bracket_Button.UseVisualStyleBackColor = false;
            this.Open_Bracket_Button.Click += new System.EventHandler(this.Open_Bracket_Button_Click);
            this.Open_Bracket_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Open_Bracket_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Multiplication_Button
            // 
            this.Multiplication_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Multiplication_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multiplication_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplication_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiplication_Button.ForeColor = System.Drawing.Color.White;
            this.Multiplication_Button.Location = new System.Drawing.Point(176, 174);
            this.Multiplication_Button.Name = "Multiplication_Button";
            this.Multiplication_Button.Size = new System.Drawing.Size(50, 45);
            this.Multiplication_Button.TabIndex = 8;
            this.Multiplication_Button.Text = "x";
            this.Multiplication_Button.UseVisualStyleBackColor = false;
            this.Multiplication_Button.Click += new System.EventHandler(this.Multiplication_Button_Click);
            this.Multiplication_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Multiplication_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Nine_Button
            // 
            this.Nine_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Nine_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nine_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nine_Button.ForeColor = System.Drawing.Color.White;
            this.Nine_Button.Location = new System.Drawing.Point(119, 174);
            this.Nine_Button.Name = "Nine_Button";
            this.Nine_Button.Size = new System.Drawing.Size(50, 45);
            this.Nine_Button.TabIndex = 7;
            this.Nine_Button.Text = "9";
            this.Nine_Button.UseVisualStyleBackColor = false;
            this.Nine_Button.Click += new System.EventHandler(this.Nine_Button_Click);
            this.Nine_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Nine_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Eight_Button
            // 
            this.Eight_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Eight_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eight_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eight_Button.ForeColor = System.Drawing.Color.White;
            this.Eight_Button.Location = new System.Drawing.Point(62, 174);
            this.Eight_Button.Name = "Eight_Button";
            this.Eight_Button.Size = new System.Drawing.Size(50, 45);
            this.Eight_Button.TabIndex = 6;
            this.Eight_Button.Text = "8";
            this.Eight_Button.UseVisualStyleBackColor = false;
            this.Eight_Button.Click += new System.EventHandler(this.Eight_Button_Click);
            this.Eight_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Eight_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Seven_Button
            // 
            this.Seven_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Seven_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seven_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Seven_Button.ForeColor = System.Drawing.Color.White;
            this.Seven_Button.Location = new System.Drawing.Point(5, 174);
            this.Seven_Button.Name = "Seven_Button";
            this.Seven_Button.Size = new System.Drawing.Size(50, 45);
            this.Seven_Button.TabIndex = 5;
            this.Seven_Button.Text = "7";
            this.Seven_Button.UseVisualStyleBackColor = false;
            this.Seven_Button.Click += new System.EventHandler(this.Seven_Button_Click);
            this.Seven_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Seven_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Addition_Button
            // 
            this.Addition_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Addition_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addition_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addition_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addition_Button.ForeColor = System.Drawing.Color.White;
            this.Addition_Button.Location = new System.Drawing.Point(176, 227);
            this.Addition_Button.Name = "Addition_Button";
            this.Addition_Button.Size = new System.Drawing.Size(50, 45);
            this.Addition_Button.TabIndex = 12;
            this.Addition_Button.Text = "+";
            this.Addition_Button.UseVisualStyleBackColor = false;
            this.Addition_Button.Click += new System.EventHandler(this.Addition_Button_Click);
            this.Addition_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Addition_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Six_Button
            // 
            this.Six_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Six_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Six_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Six_Button.ForeColor = System.Drawing.Color.White;
            this.Six_Button.Location = new System.Drawing.Point(119, 227);
            this.Six_Button.Name = "Six_Button";
            this.Six_Button.Size = new System.Drawing.Size(50, 45);
            this.Six_Button.TabIndex = 11;
            this.Six_Button.Text = "6";
            this.Six_Button.UseVisualStyleBackColor = false;
            this.Six_Button.Click += new System.EventHandler(this.Six_Button_Click);
            this.Six_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Six_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Five_Button
            // 
            this.Five_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Five_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Five_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Five_Button.ForeColor = System.Drawing.Color.White;
            this.Five_Button.Location = new System.Drawing.Point(62, 227);
            this.Five_Button.Name = "Five_Button";
            this.Five_Button.Size = new System.Drawing.Size(50, 45);
            this.Five_Button.TabIndex = 10;
            this.Five_Button.Text = "5";
            this.Five_Button.UseVisualStyleBackColor = false;
            this.Five_Button.Click += new System.EventHandler(this.Five_Button_Click);
            this.Five_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Five_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Four_Button
            // 
            this.Four_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Four_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Four_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Four_Button.ForeColor = System.Drawing.Color.White;
            this.Four_Button.Location = new System.Drawing.Point(5, 227);
            this.Four_Button.Name = "Four_Button";
            this.Four_Button.Size = new System.Drawing.Size(50, 45);
            this.Four_Button.TabIndex = 9;
            this.Four_Button.Text = "4";
            this.Four_Button.UseVisualStyleBackColor = false;
            this.Four_Button.Click += new System.EventHandler(this.Four_Button_Click);
            this.Four_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Four_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Minus_Button
            // 
            this.Minus_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Minus_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minus_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minus_Button.ForeColor = System.Drawing.Color.White;
            this.Minus_Button.Location = new System.Drawing.Point(176, 279);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(50, 45);
            this.Minus_Button.TabIndex = 16;
            this.Minus_Button.Text = "-";
            this.Minus_Button.UseVisualStyleBackColor = false;
            this.Minus_Button.Click += new System.EventHandler(this.Minus_Button_Click);
            this.Minus_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Minus_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Three_Button
            // 
            this.Three_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Three_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Three_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Three_Button.ForeColor = System.Drawing.Color.White;
            this.Three_Button.Location = new System.Drawing.Point(119, 279);
            this.Three_Button.Name = "Three_Button";
            this.Three_Button.Size = new System.Drawing.Size(50, 45);
            this.Three_Button.TabIndex = 15;
            this.Three_Button.Text = "3";
            this.Three_Button.UseVisualStyleBackColor = false;
            this.Three_Button.Click += new System.EventHandler(this.Three_Button_Click);
            this.Three_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Three_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Two_Button
            // 
            this.Two_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Two_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Two_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Two_Button.ForeColor = System.Drawing.Color.White;
            this.Two_Button.Location = new System.Drawing.Point(62, 279);
            this.Two_Button.Name = "Two_Button";
            this.Two_Button.Size = new System.Drawing.Size(50, 45);
            this.Two_Button.TabIndex = 14;
            this.Two_Button.Text = "2";
            this.Two_Button.UseVisualStyleBackColor = false;
            this.Two_Button.Click += new System.EventHandler(this.Two_Button_Click);
            this.Two_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Two_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // One_Button
            // 
            this.One_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.One_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.One_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.One_Button.ForeColor = System.Drawing.Color.White;
            this.One_Button.Location = new System.Drawing.Point(5, 279);
            this.One_Button.Name = "One_Button";
            this.One_Button.Size = new System.Drawing.Size(50, 45);
            this.One_Button.TabIndex = 13;
            this.One_Button.Text = "1";
            this.One_Button.UseVisualStyleBackColor = false;
            this.One_Button.Click += new System.EventHandler(this.One_Button_Click);
            this.One_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.One_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Equals_Button
            // 
            this.Equals_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Equals_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Equals_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equals_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equals_Button.ForeColor = System.Drawing.Color.White;
            this.Equals_Button.Location = new System.Drawing.Point(176, 331);
            this.Equals_Button.Name = "Equals_Button";
            this.Equals_Button.Size = new System.Drawing.Size(107, 45);
            this.Equals_Button.TabIndex = 20;
            this.Equals_Button.Text = "=";
            this.Equals_Button.UseVisualStyleBackColor = false;
            this.Equals_Button.Click += new System.EventHandler(this.Equals_Button_Click);
            this.Equals_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Equals_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // PI_Button
            // 
            this.PI_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.PI_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PI_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PI_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PI_Button.ForeColor = System.Drawing.Color.White;
            this.PI_Button.Location = new System.Drawing.Point(119, 331);
            this.PI_Button.Name = "PI_Button";
            this.PI_Button.Size = new System.Drawing.Size(50, 45);
            this.PI_Button.TabIndex = 19;
            this.PI_Button.Text = "𝝅";
            this.PI_Button.UseVisualStyleBackColor = false;
            this.PI_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.PI_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Zero_Button
            // 
            this.Zero_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Zero_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zero_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Zero_Button.ForeColor = System.Drawing.Color.White;
            this.Zero_Button.Location = new System.Drawing.Point(62, 331);
            this.Zero_Button.Name = "Zero_Button";
            this.Zero_Button.Size = new System.Drawing.Size(50, 45);
            this.Zero_Button.TabIndex = 18;
            this.Zero_Button.Text = "0";
            this.Zero_Button.UseVisualStyleBackColor = false;
            this.Zero_Button.Click += new System.EventHandler(this.Zero_Button_Click);
            this.Zero_Button.MouseEnter += new System.EventHandler(this.Numeric_Buttons_MouseHover);
            this.Zero_Button.MouseLeave += new System.EventHandler(this.Numeric_Buttons_MouseLeave);
            // 
            // Decimal_Button
            // 
            this.Decimal_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Decimal_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decimal_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decimal_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Decimal_Button.ForeColor = System.Drawing.Color.White;
            this.Decimal_Button.Location = new System.Drawing.Point(5, 331);
            this.Decimal_Button.Name = "Decimal_Button";
            this.Decimal_Button.Size = new System.Drawing.Size(50, 45);
            this.Decimal_Button.TabIndex = 17;
            this.Decimal_Button.Text = ".";
            this.Decimal_Button.UseVisualStyleBackColor = false;
            this.Decimal_Button.Click += new System.EventHandler(this.Decimal_Button_Click);
            this.Decimal_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Decimal_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(233, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "√";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.button1.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(233, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 45);
            this.button2.TabIndex = 23;
            this.button2.Text = "x2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.button2.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(233, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 45);
            this.button3.TabIndex = 22;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.button3.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Division_Button
            // 
            this.Division_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.Division_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Division_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Division_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Division_Button.ForeColor = System.Drawing.Color.White;
            this.Division_Button.Location = new System.Drawing.Point(233, 121);
            this.Division_Button.Name = "Division_Button";
            this.Division_Button.Size = new System.Drawing.Size(50, 45);
            this.Division_Button.TabIndex = 21;
            this.Division_Button.Text = "/";
            this.Division_Button.UseVisualStyleBackColor = false;
            this.Division_Button.Click += new System.EventHandler(this.Division_Button_Click);
            this.Division_Button.MouseEnter += new System.EventHandler(this.Operation_Buttons_MouseHover);
            this.Division_Button.MouseLeave += new System.EventHandler(this.Operation_Buttons_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(289, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Division_Button);
            this.Controls.Add(this.Equals_Button);
            this.Controls.Add(this.PI_Button);
            this.Controls.Add(this.Zero_Button);
            this.Controls.Add(this.Decimal_Button);
            this.Controls.Add(this.Minus_Button);
            this.Controls.Add(this.Three_Button);
            this.Controls.Add(this.Two_Button);
            this.Controls.Add(this.One_Button);
            this.Controls.Add(this.Addition_Button);
            this.Controls.Add(this.Six_Button);
            this.Controls.Add(this.Five_Button);
            this.Controls.Add(this.Four_Button);
            this.Controls.Add(this.Multiplication_Button);
            this.Controls.Add(this.Nine_Button);
            this.Controls.Add(this.Eight_Button);
            this.Controls.Add(this.Seven_Button);
            this.Controls.Add(this.Open_Bracket_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Close_Bracket_Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Current_Operand;
        private TextBox Previous_Operand;
        private Button Close_Bracket_Button;
        private Button Clear_Button;
        private Button Delete_Button;
        private Button Open_Bracket_Button;
        private Button Multiplication_Button;
        private Button Nine_Button;
        private Button Eight_Button;
        private Button Seven_Button;
        private Button Addition_Button;
        private Button Six_Button;
        private Button Five_Button;
        private Button Four_Button;
        private Button Minus_Button;
        private Button Three_Button;
        private Button Two_Button;
        private Button One_Button;
        private Button Equals_Button;
        private Button PI_Button;
        private Button Zero_Button;
        private Button Decimal_Button;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Division_Button;
    }
}