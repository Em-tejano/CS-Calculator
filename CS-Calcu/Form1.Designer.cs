
namespace WindowsFormsApp1
{
    partial class Calculatr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculatr));
            this.clrSecondNumLine = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.debayd = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.clrALL = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.Label();
            this.OneOver = new System.Windows.Forms.Button();
            this.SqrRt = new System.Windows.Forms.Button();
            this.Sqr = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.MemorySubtract = new System.Windows.Forms.Button();
            this.MemoryAdd = new System.Windows.Forms.Button();
            this.MemoryRecall = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.MemoryLister = new System.Windows.Forms.Button();
            this.MemorySave = new System.Windows.Forms.Button();
            this.MemoryList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clrSecondNumLine
            // 
            this.clrSecondNumLine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrSecondNumLine.Location = new System.Drawing.Point(106, 113);
            this.clrSecondNumLine.Name = "clrSecondNumLine";
            this.clrSecondNumLine.Size = new System.Drawing.Size(88, 36);
            this.clrSecondNumLine.TabIndex = 1;
            this.clrSecondNumLine.Text = "CE";
            this.clrSecondNumLine.UseVisualStyleBackColor = true;
            this.clrSecondNumLine.Click += new System.EventHandler(this.clrSecondNumLine_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(294, 239);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(88, 36);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.OperationClick);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(294, 281);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(88, 36);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.OperationClick);
            // 
            // times
            // 
            this.times.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.Location = new System.Drawing.Point(295, 197);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(88, 36);
            this.times.TabIndex = 4;
            this.times.Text = "x";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.OperationClick);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(294, 113);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 36);
            this.back.TabIndex = 6;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(294, 323);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(88, 36);
            this.equals.TabIndex = 7;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(200, 323);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(88, 36);
            this.dec.TabIndex = 8;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(200, 281);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(88, 36);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(200, 239);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(88, 36);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(201, 197);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(88, 36);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // debayd
            // 
            this.debayd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debayd.Location = new System.Drawing.Point(294, 155);
            this.debayd.Name = "debayd";
            this.debayd.Size = new System.Drawing.Size(88, 36);
            this.debayd.TabIndex = 13;
            this.debayd.Text = "÷";
            this.debayd.UseVisualStyleBackColor = true;
            this.debayd.Click += new System.EventHandler(this.OperationClick);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(106, 323);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(88, 36);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(106, 281);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(88, 36);
            this.two.TabIndex = 15;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(106, 239);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(88, 36);
            this.five.TabIndex = 16;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(107, 197);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(88, 36);
            this.eight.TabIndex = 17;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // clrALL
            // 
            this.clrALL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrALL.Location = new System.Drawing.Point(200, 113);
            this.clrALL.Name = "clrALL";
            this.clrALL.Size = new System.Drawing.Size(88, 36);
            this.clrALL.TabIndex = 18;
            this.clrALL.Text = "C";
            this.clrALL.UseVisualStyleBackColor = true;
            this.clrALL.Click += new System.EventHandler(this.clrALL_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 281);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(88, 36);
            this.one.TabIndex = 21;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 239);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(88, 36);
            this.four.TabIndex = 22;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 197);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(88, 36);
            this.seven.TabIndex = 23;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(12, 324);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(88, 36);
            this.sign.TabIndex = 25;
            this.sign.Text = "-/+";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(12, 9);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(370, 55);
            this.OutputBox.TabIndex = 26;
            this.OutputBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // OneOver
            // 
            this.OneOver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneOver.Location = new System.Drawing.Point(12, 155);
            this.OneOver.Name = "OneOver";
            this.OneOver.Size = new System.Drawing.Size(88, 36);
            this.OneOver.TabIndex = 30;
            this.OneOver.Text = "1/x";
            this.OneOver.UseVisualStyleBackColor = true;
            this.OneOver.Click += new System.EventHandler(this.OneOver_Click);
            // 
            // SqrRt
            // 
            this.SqrRt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqrRt.Location = new System.Drawing.Point(200, 155);
            this.SqrRt.Name = "SqrRt";
            this.SqrRt.Size = new System.Drawing.Size(88, 36);
            this.SqrRt.TabIndex = 28;
            this.SqrRt.Text = "√x";
            this.SqrRt.UseVisualStyleBackColor = true;
            this.SqrRt.Click += new System.EventHandler(this.SqrRt_Click);
            // 
            // Sqr
            // 
            this.Sqr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sqr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sqr.Location = new System.Drawing.Point(106, 155);
            this.Sqr.Name = "Sqr";
            this.Sqr.Size = new System.Drawing.Size(88, 36);
            this.Sqr.TabIndex = 29;
            this.Sqr.Text = "X²";
            this.Sqr.UseVisualStyleBackColor = true;
            this.Sqr.Click += new System.EventHandler(this.Sqr_Click);
            // 
            // Percent
            // 
            this.Percent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(12, 113);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(88, 36);
            this.Percent.TabIndex = 31;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // MemorySubtract
            // 
            this.MemorySubtract.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySubtract.Location = new System.Drawing.Point(199, 71);
            this.MemorySubtract.Name = "MemorySubtract";
            this.MemorySubtract.Size = new System.Drawing.Size(57, 36);
            this.MemorySubtract.TabIndex = 32;
            this.MemorySubtract.Text = "M-";
            this.MemorySubtract.UseVisualStyleBackColor = true;
            this.MemorySubtract.Click += new System.EventHandler(this.MemoryAddSub_Click);
            // 
            // MemoryAdd
            // 
            this.MemoryAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryAdd.Location = new System.Drawing.Point(136, 71);
            this.MemoryAdd.Name = "MemoryAdd";
            this.MemoryAdd.Size = new System.Drawing.Size(57, 36);
            this.MemoryAdd.TabIndex = 33;
            this.MemoryAdd.Text = "M+";
            this.MemoryAdd.UseVisualStyleBackColor = true;
            this.MemoryAdd.Click += new System.EventHandler(this.MemoryAddSub_Click);
            // 
            // MemoryRecall
            // 
            this.MemoryRecall.Enabled = false;
            this.MemoryRecall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryRecall.Location = new System.Drawing.Point(74, 71);
            this.MemoryRecall.Name = "MemoryRecall";
            this.MemoryRecall.Size = new System.Drawing.Size(56, 36);
            this.MemoryRecall.TabIndex = 34;
            this.MemoryRecall.Text = "MR";
            this.MemoryRecall.UseVisualStyleBackColor = true;
            // 
            // MemoryClear
            // 
            this.MemoryClear.Enabled = false;
            this.MemoryClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryClear.Location = new System.Drawing.Point(12, 71);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(56, 36);
            this.MemoryClear.TabIndex = 35;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = true;
            // 
            // MemoryLister
            // 
            this.MemoryLister.Enabled = false;
            this.MemoryLister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLister.Location = new System.Drawing.Point(325, 71);
            this.MemoryLister.Name = "MemoryLister";
            this.MemoryLister.Size = new System.Drawing.Size(57, 36);
            this.MemoryLister.TabIndex = 36;
            this.MemoryLister.Text = "M";
            this.MemoryLister.UseVisualStyleBackColor = true;
            this.MemoryLister.Click += new System.EventHandler(this.MemoryLister_Click);
            // 
            // MemorySave
            // 
            this.MemorySave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySave.Location = new System.Drawing.Point(262, 71);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(57, 36);
            this.MemorySave.TabIndex = 37;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = true;
            this.MemorySave.Click += new System.EventHandler(this.MemorySave_Click);
            // 
            // MemoryList
            // 
            this.MemoryList.FormattingEnabled = true;
            this.MemoryList.Location = new System.Drawing.Point(262, 113);
            this.MemoryList.Name = "MemoryList";
            this.MemoryList.Size = new System.Drawing.Size(120, 95);
            this.MemoryList.TabIndex = 38;
            this.MemoryList.Visible = false;
            this.MemoryList.MouseLeave += new System.EventHandler(this.MemoryList_MouseLeave);
            // 
            // Calculatr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 367);
            this.Controls.Add(this.MemoryList);
            this.Controls.Add(this.MemorySave);
            this.Controls.Add(this.MemoryLister);
            this.Controls.Add(this.MemoryClear);
            this.Controls.Add(this.MemoryRecall);
            this.Controls.Add(this.MemoryAdd);
            this.Controls.Add(this.MemorySubtract);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.OneOver);
            this.Controls.Add(this.Sqr);
            this.Controls.Add(this.SqrRt);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.one);
            this.Controls.Add(this.clrALL);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.five);
            this.Controls.Add(this.two);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.debayd);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.back);
            this.Controls.Add(this.times);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.clrSecondNumLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculatr";
            this.Opacity = 0.85D;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clrSecondNumLine;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button debayd;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button clrALL;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Label OutputBox;
        private System.Windows.Forms.Button OneOver;
        private System.Windows.Forms.Button Sqr;
        private System.Windows.Forms.Button SqrRt;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button MemorySubtract;
        private System.Windows.Forms.Button MemoryAdd;
        private System.Windows.Forms.Button MemoryRecall;
        private System.Windows.Forms.Button MemoryClear;
        private System.Windows.Forms.Button MemoryLister;
        private System.Windows.Forms.Button MemorySave;
        private System.Windows.Forms.ListBox MemoryList;
    }
}

