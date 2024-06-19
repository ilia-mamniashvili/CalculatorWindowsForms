using System.Data;

namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

    public void Calculate(object sender, EventArgs e)
        {
            //string input = label1.Text;
            //int temp = int.Parse(input);
            if (label1.Text.Length == 0 || "+-/*.".Contains(label1.Text[^1]))
            {
                return;
            }
            DataTable table = new DataTable();
            if (label1.Text.Contains(","))
            {
                label1.Text = label1.Text.Replace(",", ".");
            }
            object result = table.Compute(label1.Text, "");            
            label1.Text = result.ToString();
        }
        private void MyButton_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 34)
            {
                return;
            }
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            if ("+-/*".Contains(buttonText) && label1.Text.Length > 0 
                && "+-/*".Contains(label1.Text[^1].ToString())) 
            {
                return;
            }
           
            if((sender == Plus || sender == Minus || sender == Divide 
                || sender == Multiply) && label1.Text.Length == 0)
            {
                return;
            }
            label1.Text += clickedButton.Text;
        }
        private void Delete(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
        }
        private void DeleteAll(object sender, EventArgs e)
        {
            label1.Text = " ";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {

            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            button11 = new Button();
            button12 = new Button();
            Plus = new Button();
            Minus = new Button();
            Divide = new Button();
            Multiply = new Button();
            Del = new Button();
            DelAll = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(61, 37);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += MyButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 85);
            button2.Name = "button2";
            button2.Size = new Size(61, 37);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += MyButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(187, 85);
            button3.Name = "button3";
            button3.Size = new Size(61, 37);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += MyButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 141);
            button4.Name = "button4";
            button4.Size = new Size(61, 37);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += MyButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(100, 141);
            button5.Name = "button5";
            button5.Size = new Size(61, 37);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += MyButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(187, 141);
            button6.Name = "button6";
            button6.Size = new Size(61, 37);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += MyButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 196);
            button7.Name = "button7";
            button7.Size = new Size(61, 37);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += MyButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(100, 196);
            button8.Name = "button8";
            button8.Size = new Size(61, 37);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += MyButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(187, 196);
            button9.Name = "button9";
            button9.Size = new Size(61, 37);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += MyButton_Click;
            // 
            // button10
            // 
            button10.Location = new Point(100, 252);
            button10.Name = "button10";
            button10.Size = new Size(61, 37);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += MyButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.IBeam;
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(12, 9);
            label1.MaximumSize = new Size(110, 0);
            label1.MinimumSize = new Size(236, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 20, 10, 20);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(236, 57);
            label1.TabIndex = 10;
            label1.Tag = "";
            // 
            // button11
            // 
            button11.Location = new Point(12, 252);
            button11.Name = "button11";
            button11.Size = new Size(61, 37);
            button11.TabIndex = 11;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += MyButton_Click;
            // 
            // button12
            // 
            button12.Location = new Point(187, 252);
            button12.Name = "button12";
            button12.Size = new Size(61, 37);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Calculate;
            // 
            // Plus
            // 
            Plus.Location = new Point(272, 85);
            Plus.Name = "Plus";
            Plus.Size = new Size(49, 37);
            Plus.TabIndex = 13;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += MyButton_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(272, 141);
            Minus.Name = "Minus";
            Minus.Size = new Size(49, 37);
            Minus.TabIndex = 14;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += MyButton_Click;
            // 
            // Divide
            // 
            Divide.Location = new Point(272, 196);
            Divide.Name = "Divide";
            Divide.Size = new Size(49, 37);
            Divide.TabIndex = 15;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += MyButton_Click;
            // 
            // Multiply
            // 
            Multiply.Location = new Point(272, 252);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(49, 37);
            Multiply.TabIndex = 16;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += MyButton_Click;
            // 
            // Del
            // 
            Del.Location = new Point(272, 12);
            Del.Name = "Del";
            Del.Size = new Size(49, 26);
            Del.TabIndex = 17;
            Del.Text = "<--";
            Del.UseVisualStyleBackColor = true;
            Del.Click += Delete;
            // 
            // DelAll
            // 
            DelAll.Location = new Point(272, 44);
            DelAll.Name = "DelAll";
            DelAll.Size = new Size(49, 26);
            DelAll.TabIndex = 18;
            DelAll.Text = "C";
            DelAll.UseVisualStyleBackColor = true;
            DelAll.Click += DeleteAll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(341, 309);
            Controls.Add(DelAll);
            Controls.Add(Del);
            Controls.Add(Multiply);
            Controls.Add(Divide);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Button button11;
        private Button button12;
        private Button Plus;

        private Button Minus;
        private Button Divide;
        private Button Multiply;
        private Button Del;
        private Button DelAll;
    }
}
