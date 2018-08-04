namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.kglb = new System.Windows.Forms.Button();
            this.lbkg = new System.Windows.Forms.Button();
            this.incm = new System.Windows.Forms.Button();
            this.cmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 215);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(45, 45);
            this.four.TabIndex = 0;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(63, 215);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(45, 45);
            this.five.TabIndex = 1;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(114, 215);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(45, 45);
            this.six.TabIndex = 2;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // times
            // 
            this.times.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.Location = new System.Drawing.Point(165, 215);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(45, 45);
            this.times.TabIndex = 3;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.operator_click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(216, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(216, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 9;
            this.button6.Text = "CE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(165, 164);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(45, 45);
            this.div.TabIndex = 8;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operator_click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(114, 164);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(45, 45);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(63, 164);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(45, 45);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 164);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 45);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(165, 266);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(45, 45);
            this.sub.TabIndex = 13;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.operator_click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(114, 266);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(45, 45);
            this.three.TabIndex = 12;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(63, 266);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(45, 45);
            this.two.TabIndex = 11;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 266);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 45);
            this.one.TabIndex = 10;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(114, 317);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(45, 45);
            this.dec.TabIndex = 14;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.button_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(165, 317);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 45);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(216, 266);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(45, 96);
            this.equal.TabIndex = 16;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.button17_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 317);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(96, 45);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result.Location = new System.Drawing.Point(13, 14);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(248, 40);
            this.result.TabIndex = 18;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.equation.Location = new System.Drawing.Point(21, 27);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 15);
            this.equation.TabIndex = 19;
            // 
            // kglb
            // 
            this.kglb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kglb.Location = new System.Drawing.Point(13, 60);
            this.kglb.Name = "kglb";
            this.kglb.Size = new System.Drawing.Size(122, 45);
            this.kglb.TabIndex = 20;
            this.kglb.Text = "Kg to Lb";
            this.kglb.UseVisualStyleBackColor = true;
            this.kglb.Click += new System.EventHandler(this.convert_click);
            // 
            // lbkg
            // 
            this.lbkg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkg.Location = new System.Drawing.Point(141, 60);
            this.lbkg.Name = "lbkg";
            this.lbkg.Size = new System.Drawing.Size(120, 45);
            this.lbkg.TabIndex = 21;
            this.lbkg.Text = "Lb to Kg";
            this.lbkg.UseVisualStyleBackColor = true;
            this.lbkg.Click += new System.EventHandler(this.convert_click);
            // 
            // incm
            // 
            this.incm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incm.Location = new System.Drawing.Point(12, 111);
            this.incm.Name = "incm";
            this.incm.Size = new System.Drawing.Size(122, 45);
            this.incm.TabIndex = 22;
            this.incm.Text = "In to Cm";
            this.incm.UseVisualStyleBackColor = true;
            this.incm.MouseCaptureChanged += new System.EventHandler(this.convert_click);
            // 
            // cmin
            // 
            this.cmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmin.Location = new System.Drawing.Point(139, 111);
            this.cmin.Name = "cmin";
            this.cmin.Size = new System.Drawing.Size(122, 45);
            this.cmin.TabIndex = 23;
            this.cmin.Text = "Cm to In";
            this.cmin.UseVisualStyleBackColor = true;
            this.cmin.MouseCaptureChanged += new System.EventHandler(this.convert_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 368);
            this.Controls.Add(this.cmin);
            this.Controls.Add(this.incm);
            this.Controls.Add(this.lbkg);
            this.Controls.Add(this.kglb);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.div);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.times);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 415);
            this.MinimumSize = new System.Drawing.Size(300, 415);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Button kglb;
        private System.Windows.Forms.Button lbkg;
        private System.Windows.Forms.Button incm;
        private System.Windows.Forms.Button cmin;
    }
}

