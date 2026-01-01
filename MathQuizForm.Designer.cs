namespace MathQuiz
{
    partial class MathQuizForm
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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusRightLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            minusLeftLabel = new Label();
            timesLeftLabel = new Label();
            dividedLeftLabel = new Label();
            minusRightLabel = new Label();
            timesRightLabel = new Label();
            dividedRightLabel = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            difference = new NumericUpDown();
            product = new NumericUpDown();
            quotient = new NumericUpDown();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(272, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(167, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(50, 61);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(182, 61);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(248, 61);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 4;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(116, 61);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 5;
            label4.Text = "+";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(314, 68);
            sum.MinimumSize = new Size(100, 0);
            sum.Name = "sum";
            sum.Size = new Size(120, 39);
            sum.TabIndex = 1;
            sum.Click += answer_Enter;
            sum.Enter += answer_Enter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F);
            minusLeftLabel.Location = new Point(50, 111);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(50, 161);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 8;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(50, 211);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 9;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F);
            minusRightLabel.Location = new Point(182, 111);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 10;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(182, 157);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 11;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F);
            dividedRightLabel.Location = new Point(182, 211);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 12;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(116, 111);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 13;
            label10.Text = "-";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(116, 161);
            label11.Name = "label11";
            label11.Size = new Size(60, 50);
            label11.TabIndex = 14;
            label11.Text = "×";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(116, 211);
            label12.Name = "label12";
            label12.Size = new Size(60, 50);
            label12.TabIndex = 15;
            label12.Text = "÷";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 18F);
            label13.Location = new Point(248, 107);
            label13.Name = "label13";
            label13.Size = new Size(60, 50);
            label13.TabIndex = 16;
            label13.Text = "=";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 18F);
            label14.Location = new Point(248, 157);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 17;
            label14.Text = "=";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 18F);
            label15.Location = new Point(248, 207);
            label15.Name = "label15";
            label15.Size = new Size(60, 50);
            label15.TabIndex = 18;
            label15.Text = "=";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F);
            difference.Location = new Point(314, 114);
            difference.MinimumSize = new Size(100, 0);
            difference.Name = "difference";
            difference.Size = new Size(120, 39);
            difference.TabIndex = 2;
            difference.Click += answer_Enter;
            difference.Enter += answer_Enter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F);
            product.Location = new Point(314, 164);
            product.MinimumSize = new Size(100, 0);
            product.Name = "product";
            product.Size = new Size(120, 39);
            product.TabIndex = 3;
            product.Click += answer_Enter;
            product.Enter += answer_Enter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F);
            quotient.Location = new Point(314, 214);
            quotient.MinimumSize = new Size(100, 0);
            quotient.Name = "quotient";
            quotient.Size = new Size(120, 39);
            quotient.TabIndex = 4;
            quotient.Click += answer_Enter;
            quotient.Enter += answer_Enter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(167, 292);
            startButton.Name = "startButton";
            startButton.Size = new Size(133, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(product);
            Controls.Add(difference);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dividedRightLabel);
            Controls.Add(timesRightLabel);
            Controls.Add(minusRightLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusRightLabel;
        private Label label3;
        private Label label4;
        private NumericUpDown sum;
        private Label minusLeftLabel;
        private Label timesLeftLabel;
        private Label dividedLeftLabel;
        private Label minusRightLabel;
        private Label timesRightLabel;
        private Label dividedRightLabel;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private NumericUpDown difference;
        private NumericUpDown product;
        private NumericUpDown quotient;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}
