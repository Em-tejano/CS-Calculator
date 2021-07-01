
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
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Standard");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Scientific");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Graphing");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Programmer");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Date Calculation");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Currency");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Volume");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Length");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Weight and Mass");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Temperature");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Energy");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Area");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Speed");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Time");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Power");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Data");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Pressure");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Angle");
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
            this.MenuBtn = new System.Windows.Forms.Button();
            this.MenuPane = new System.Windows.Forms.TreeView();
            this.ModeName = new System.Windows.Forms.RichTextBox();
            this.History = new System.Windows.Forms.Button();
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clrSecondNumLine
            // 
            this.clrSecondNumLine.BackColor = System.Drawing.SystemColors.Window;
            this.clrSecondNumLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrSecondNumLine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrSecondNumLine.ForeColor = System.Drawing.Color.Black;
            this.clrSecondNumLine.Location = new System.Drawing.Point(106, 151);
            this.clrSecondNumLine.Name = "clrSecondNumLine";
            this.clrSecondNumLine.Size = new System.Drawing.Size(88, 36);
            this.clrSecondNumLine.TabIndex = 1;
            this.clrSecondNumLine.Text = "CE";
            this.clrSecondNumLine.UseVisualStyleBackColor = false;
            this.clrSecondNumLine.Click += new System.EventHandler(this.clrSecondNumLine_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.Window;
            this.minus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.minus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.Color.Black;
            this.minus.Location = new System.Drawing.Point(294, 277);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(88, 36);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.OperationClick);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.Window;
            this.plus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.plus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.Black;
            this.plus.Location = new System.Drawing.Point(294, 319);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(88, 36);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.OperationClick);
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.SystemColors.Window;
            this.times.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.times.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.ForeColor = System.Drawing.Color.Black;
            this.times.Location = new System.Drawing.Point(295, 235);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(88, 36);
            this.times.TabIndex = 4;
            this.times.Text = "x";
            this.times.UseVisualStyleBackColor = false;
            this.times.Click += new System.EventHandler(this.OperationClick);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Window;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(294, 151);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 36);
            this.back.TabIndex = 6;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.Window;
            this.equals.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.equals.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.ForeColor = System.Drawing.Color.Black;
            this.equals.Location = new System.Drawing.Point(294, 361);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(88, 36);
            this.equals.TabIndex = 7;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // dec
            // 
            this.dec.BackColor = System.Drawing.SystemColors.Window;
            this.dec.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.dec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.ForeColor = System.Drawing.Color.Black;
            this.dec.Location = new System.Drawing.Point(200, 361);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(88, 36);
            this.dec.TabIndex = 8;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = false;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.Window;
            this.three.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.three.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.Color.Black;
            this.three.Location = new System.Drawing.Point(200, 319);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(88, 36);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.Window;
            this.six.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.six.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.Color.Black;
            this.six.Location = new System.Drawing.Point(200, 277);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(88, 36);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.Window;
            this.nine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.nine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.Color.Black;
            this.nine.Location = new System.Drawing.Point(201, 235);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(88, 36);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // debayd
            // 
            this.debayd.BackColor = System.Drawing.SystemColors.Window;
            this.debayd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.debayd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debayd.ForeColor = System.Drawing.Color.Black;
            this.debayd.Location = new System.Drawing.Point(294, 193);
            this.debayd.Name = "debayd";
            this.debayd.Size = new System.Drawing.Size(88, 36);
            this.debayd.TabIndex = 13;
            this.debayd.Text = "÷";
            this.debayd.UseVisualStyleBackColor = false;
            this.debayd.Click += new System.EventHandler(this.OperationClick);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.Window;
            this.zero.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.zero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.Color.Black;
            this.zero.Location = new System.Drawing.Point(106, 361);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(88, 36);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.Window;
            this.two.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.two.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.Color.Black;
            this.two.Location = new System.Drawing.Point(106, 319);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(88, 36);
            this.two.TabIndex = 15;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.Window;
            this.five.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.five.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.Color.Black;
            this.five.Location = new System.Drawing.Point(106, 277);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(88, 36);
            this.five.TabIndex = 16;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.Window;
            this.eight.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.eight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.Color.Black;
            this.eight.Location = new System.Drawing.Point(107, 235);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(88, 36);
            this.eight.TabIndex = 17;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // clrALL
            // 
            this.clrALL.BackColor = System.Drawing.SystemColors.Window;
            this.clrALL.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.clrALL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrALL.ForeColor = System.Drawing.Color.Black;
            this.clrALL.Location = new System.Drawing.Point(200, 151);
            this.clrALL.Name = "clrALL";
            this.clrALL.Size = new System.Drawing.Size(88, 36);
            this.clrALL.TabIndex = 18;
            this.clrALL.Text = "C";
            this.clrALL.UseVisualStyleBackColor = false;
            this.clrALL.Click += new System.EventHandler(this.clrALL_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.Window;
            this.one.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.one.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.Color.Black;
            this.one.Location = new System.Drawing.Point(12, 319);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(88, 36);
            this.one.TabIndex = 21;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.Window;
            this.four.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.four.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.Color.Black;
            this.four.Location = new System.Drawing.Point(12, 277);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(88, 36);
            this.four.TabIndex = 22;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.Window;
            this.seven.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.seven.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.Color.Black;
            this.seven.Location = new System.Drawing.Point(12, 235);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(88, 36);
            this.seven.TabIndex = 23;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.Window;
            this.sign.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.sign.ForeColor = System.Drawing.Color.Black;
            this.sign.Location = new System.Drawing.Point(12, 362);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(88, 36);
            this.sign.TabIndex = 25;
            this.sign.Text = "-/+";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.ForeColor = System.Drawing.SystemColors.Control;
            this.OutputBox.Location = new System.Drawing.Point(12, 47);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(370, 55);
            this.OutputBox.TabIndex = 26;
            this.OutputBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // OneOver
            // 
            this.OneOver.BackColor = System.Drawing.SystemColors.Window;
            this.OneOver.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.OneOver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneOver.ForeColor = System.Drawing.Color.Black;
            this.OneOver.Location = new System.Drawing.Point(12, 193);
            this.OneOver.Name = "OneOver";
            this.OneOver.Size = new System.Drawing.Size(88, 36);
            this.OneOver.TabIndex = 30;
            this.OneOver.Text = "1/x";
            this.OneOver.UseVisualStyleBackColor = false;
            this.OneOver.Click += new System.EventHandler(this.OneOver_Click);
            // 
            // SqrRt
            // 
            this.SqrRt.BackColor = System.Drawing.SystemColors.Window;
            this.SqrRt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.SqrRt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqrRt.ForeColor = System.Drawing.Color.Black;
            this.SqrRt.Location = new System.Drawing.Point(200, 193);
            this.SqrRt.Name = "SqrRt";
            this.SqrRt.Size = new System.Drawing.Size(88, 36);
            this.SqrRt.TabIndex = 28;
            this.SqrRt.Text = "√x";
            this.SqrRt.UseVisualStyleBackColor = false;
            this.SqrRt.Click += new System.EventHandler(this.SqrRt_Click);
            // 
            // Sqr
            // 
            this.Sqr.BackColor = System.Drawing.SystemColors.Window;
            this.Sqr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sqr.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.Sqr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sqr.ForeColor = System.Drawing.Color.Black;
            this.Sqr.Location = new System.Drawing.Point(106, 193);
            this.Sqr.Name = "Sqr";
            this.Sqr.Size = new System.Drawing.Size(88, 36);
            this.Sqr.TabIndex = 29;
            this.Sqr.Text = "X²";
            this.Sqr.UseVisualStyleBackColor = false;
            this.Sqr.Click += new System.EventHandler(this.Sqr_Click);
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.SystemColors.Window;
            this.Percent.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.Percent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.ForeColor = System.Drawing.Color.Black;
            this.Percent.Location = new System.Drawing.Point(12, 151);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(88, 36);
            this.Percent.TabIndex = 31;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // MemorySubtract
            // 
            this.MemorySubtract.BackColor = System.Drawing.SystemColors.Window;
            this.MemorySubtract.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.MemorySubtract.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySubtract.ForeColor = System.Drawing.Color.Black;
            this.MemorySubtract.Location = new System.Drawing.Point(199, 109);
            this.MemorySubtract.Name = "MemorySubtract";
            this.MemorySubtract.Size = new System.Drawing.Size(57, 36);
            this.MemorySubtract.TabIndex = 32;
            this.MemorySubtract.Text = "M-";
            this.MemorySubtract.UseVisualStyleBackColor = false;
            this.MemorySubtract.Click += new System.EventHandler(this.MemoryAddSub_Click);
            // 
            // MemoryAdd
            // 
            this.MemoryAdd.BackColor = System.Drawing.SystemColors.Window;
            this.MemoryAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.MemoryAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryAdd.ForeColor = System.Drawing.Color.Black;
            this.MemoryAdd.Location = new System.Drawing.Point(136, 109);
            this.MemoryAdd.Name = "MemoryAdd";
            this.MemoryAdd.Size = new System.Drawing.Size(57, 36);
            this.MemoryAdd.TabIndex = 33;
            this.MemoryAdd.Text = "M+";
            this.MemoryAdd.UseVisualStyleBackColor = false;
            this.MemoryAdd.Click += new System.EventHandler(this.MemoryAddSub_Click);
            // 
            // MemoryRecall
            // 
            this.MemoryRecall.BackColor = System.Drawing.SystemColors.Window;
            this.MemoryRecall.Enabled = false;
            this.MemoryRecall.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.MemoryRecall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryRecall.ForeColor = System.Drawing.Color.Black;
            this.MemoryRecall.Location = new System.Drawing.Point(74, 109);
            this.MemoryRecall.Name = "MemoryRecall";
            this.MemoryRecall.Size = new System.Drawing.Size(56, 36);
            this.MemoryRecall.TabIndex = 34;
            this.MemoryRecall.Text = "MR";
            this.MemoryRecall.UseVisualStyleBackColor = false;
            this.MemoryRecall.Click += new System.EventHandler(this.MemoryRecall_Click);
            // 
            // MemoryClear
            // 
            this.MemoryClear.BackColor = System.Drawing.SystemColors.Window;
            this.MemoryClear.Enabled = false;
            this.MemoryClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.MemoryClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryClear.ForeColor = System.Drawing.Color.Black;
            this.MemoryClear.Location = new System.Drawing.Point(12, 109);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(56, 36);
            this.MemoryClear.TabIndex = 35;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = false;
            this.MemoryClear.Click += new System.EventHandler(this.MemoryClear_Click);
            // 
            // MemoryLister
            // 
            this.MemoryLister.BackColor = System.Drawing.SystemColors.Window;
            this.MemoryLister.Enabled = false;
            this.MemoryLister.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.MemoryLister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLister.ForeColor = System.Drawing.Color.Black;
            this.MemoryLister.Location = new System.Drawing.Point(325, 109);
            this.MemoryLister.Name = "MemoryLister";
            this.MemoryLister.Size = new System.Drawing.Size(57, 36);
            this.MemoryLister.TabIndex = 36;
            this.MemoryLister.Text = "M";
            this.MemoryLister.UseVisualStyleBackColor = false;
            this.MemoryLister.Click += new System.EventHandler(this.MemoryLister_Click);
            // 
            // MemorySave
            // 
            this.MemorySave.BackColor = System.Drawing.SystemColors.Window;
            this.MemorySave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.MemorySave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySave.ForeColor = System.Drawing.Color.Black;
            this.MemorySave.Location = new System.Drawing.Point(262, 109);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(57, 36);
            this.MemorySave.TabIndex = 37;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = false;
            this.MemorySave.Click += new System.EventHandler(this.MemorySave_Click);
            // 
            // MemoryList
            // 
            this.MemoryList.Font = new System.Drawing.Font("Arial", 13.5F);
            this.MemoryList.FormattingEnabled = true;
            this.MemoryList.ItemHeight = 21;
            this.MemoryList.Location = new System.Drawing.Point(262, 151);
            this.MemoryList.Name = "MemoryList";
            this.MemoryList.Size = new System.Drawing.Size(120, 88);
            this.MemoryList.TabIndex = 38;
            this.MemoryList.Visible = false;
            this.MemoryList.DoubleClick += new System.EventHandler(this.MemCall_DoubleClick);
            this.MemoryList.MouseLeave += new System.EventHandler(this.MemoryList_MouseLeave);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.SystemColors.Window;
            this.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtn.Image")));
            this.MenuBtn.Location = new System.Drawing.Point(12, 8);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(39, 36);
            this.MenuBtn.TabIndex = 39;
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // MenuPane
            // 
            this.MenuPane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuPane.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.MenuPane.Indent = 15;
            this.MenuPane.ItemHeight = 30;
            this.MenuPane.Location = new System.Drawing.Point(12, 47);
            this.MenuPane.Name = "MenuPane";
            treeNode55.Name = "Standard";
            treeNode55.Text = "Standard";
            treeNode56.Name = "Scientific";
            treeNode56.Text = "Scientific";
            treeNode57.Name = "Graphing";
            treeNode57.Text = "Graphing";
            treeNode58.Name = "Programmer";
            treeNode58.Text = "Programmer";
            treeNode59.Name = "Date Calculation";
            treeNode59.Text = "Date Calculation";
            treeNode60.Name = "Currency";
            treeNode60.Text = "Currency";
            treeNode61.Name = "Volume";
            treeNode61.Text = "Volume";
            treeNode62.Name = "Length";
            treeNode62.Text = "Length";
            treeNode63.Name = "Weight and Mass";
            treeNode63.Text = "Weight and Mass";
            treeNode64.Name = "Temperature";
            treeNode64.Text = "Temperature";
            treeNode65.Name = "Energy";
            treeNode65.Text = "Energy";
            treeNode66.Name = "Area";
            treeNode66.Text = "Area";
            treeNode67.Name = "Speed";
            treeNode67.Text = "Speed";
            treeNode68.Name = "Time";
            treeNode68.Text = "Time";
            treeNode69.Name = "Power";
            treeNode69.Text = "Power";
            treeNode70.Name = "Data";
            treeNode70.Text = "Data";
            treeNode71.Name = "Pressure";
            treeNode71.Text = "Pressure";
            treeNode72.Name = "Angle";
            treeNode72.Text = "Angle";
            this.MenuPane.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67,
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72});
            this.MenuPane.ShowLines = false;
            this.MenuPane.ShowPlusMinus = false;
            this.MenuPane.ShowRootLines = false;
            this.MenuPane.Size = new System.Drawing.Size(183, 350);
            this.MenuPane.TabIndex = 40;
            this.MenuPane.Visible = false;
            this.MenuPane.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MenuPane_AfterSelect);
            // 
            // ModeName
            // 
            this.ModeName.BackColor = System.Drawing.SystemColors.MenuText;
            this.ModeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeName.ForeColor = System.Drawing.SystemColors.Menu;
            this.ModeName.Location = new System.Drawing.Point(57, 8);
            this.ModeName.Name = "ModeName";
            this.ModeName.Size = new System.Drawing.Size(262, 36);
            this.ModeName.TabIndex = 41;
            this.ModeName.Text = "Standard";
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.Window;
            this.History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.History.Image = ((System.Drawing.Image)(resources.GetObject("History.Image")));
            this.History.Location = new System.Drawing.Point(343, 8);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(39, 36);
            this.History.TabIndex = 42;
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // HistoryBox
            // 
            this.HistoryBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HistoryBox.Font = new System.Drawing.Font("Arial", 13.5F);
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.ItemHeight = 21;
            this.HistoryBox.Location = new System.Drawing.Point(0, 49);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(394, 361);
            this.HistoryBox.TabIndex = 43;
            this.HistoryBox.Visible = false;
            this.HistoryBox.DoubleClick += new System.EventHandler(this.Hist_DoubleClick);
            this.HistoryBox.MouseLeave += new System.EventHandler(this.HistoryBox_MouseLeave);
            // 
            // Calculatr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(394, 410);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.History);
            this.Controls.Add(this.ModeName);
            this.Controls.Add(this.MenuPane);
            this.Controls.Add(this.MenuBtn);
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
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.RichTextBox ModeName;
        private System.Windows.Forms.TreeView MenuPane;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.ListBox HistoryBox;
    }
}

