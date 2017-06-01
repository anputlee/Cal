namespace 计算器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mmin = new System.Windows.Forms.Button();
            this.mplus = new System.Windows.Forms.Button();
            this.mic = new System.Windows.Forms.Button();
            this.mView = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input.Location = new System.Drawing.Point(12, 31);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(24, 28);
            this.input.TabIndex = 0;
            this.input.Text = "0";
            this.input.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.output.Location = new System.Drawing.Point(12, 59);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(31, 35);
            this.output.TabIndex = 1;
            this.output.Text = "0";
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(17, 143);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(32, 32);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(55, 143);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(32, 32);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(93, 143);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(32, 32);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(17, 181);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(32, 32);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(55, 181);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(32, 32);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(93, 181);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(32, 32);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(17, 219);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(32, 32);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(55, 219);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(32, 32);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(93, 219);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(32, 32);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(55, 257);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(32, 32);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(17, 257);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(32, 32);
            this.dot.TabIndex = 13;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(131, 143);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(32, 32);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(131, 219);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(32, 32);
            this.multi.TabIndex = 15;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(131, 181);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(32, 32);
            this.min.TabIndex = 16;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(131, 257);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(32, 32);
            this.div.TabIndex = 17;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mmin
            // 
            this.mmin.Location = new System.Drawing.Point(55, 105);
            this.mmin.Name = "mmin";
            this.mmin.Size = new System.Drawing.Size(32, 32);
            this.mmin.TabIndex = 19;
            this.mmin.Text = "M-";
            this.mmin.UseVisualStyleBackColor = true;
            this.mmin.Click += new System.EventHandler(this.mmin_Click);
            // 
            // mplus
            // 
            this.mplus.Location = new System.Drawing.Point(17, 105);
            this.mplus.Name = "mplus";
            this.mplus.Size = new System.Drawing.Size(32, 32);
            this.mplus.TabIndex = 20;
            this.mplus.Text = "M+";
            this.mplus.UseVisualStyleBackColor = true;
            this.mplus.Click += new System.EventHandler(this.mplus_Click);
            // 
            // mic
            // 
            this.mic.Location = new System.Drawing.Point(93, 105);
            this.mic.Name = "mic";
            this.mic.Size = new System.Drawing.Size(32, 32);
            this.mic.TabIndex = 18;
            this.mic.Text = "MRC";
            this.mic.UseVisualStyleBackColor = true;
            this.mic.Click += new System.EventHandler(this.mic_Click);
            // 
            // mView
            // 
            this.mView.AutoSize = true;
            this.mView.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mView.Location = new System.Drawing.Point(14, 9);
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(52, 20);
            this.mView.TabIndex = 22;
            this.mView.Text = "M = 0";
            this.mView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(93, 257);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(32, 32);
            this.equal.TabIndex = 11;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(131, 105);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(32, 32);
            this.del.TabIndex = 21;
            this.del.Text = "←";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 304);
            this.Controls.Add(this.mView);
            this.Controls.Add(this.del);
            this.Controls.Add(this.mplus);
            this.Controls.Add(this.mmin);
            this.Controls.Add(this.mic);
            this.Controls.Add(this.div);
            this.Controls.Add(this.min);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mic;
        private System.Windows.Forms.Button mmin;
        private System.Windows.Forms.Button mplus;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label mView;
    }
}



