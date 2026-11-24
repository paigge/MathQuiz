namespace MathQuiz;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        timeLabel = new Label();
        label1 = new Label();
        plusLeftLabel = new Label();
        label2 = new Label();
        plusRightLabel = new Label();
        label4 = new Label();
        sum = new NumericUpDown();
        minusLeftLabel = new Label();
        label3 = new Label();
        minusRightLabel = new Label();
        label5 = new Label();
        difference = new NumericUpDown();
        timesLeftLabel = new Label();
        label6 = new Label();
        timesRightLabel = new Label();
        label7 = new Label();
        product = new NumericUpDown();
        dividedLeftLabel = new Label();
        label8 = new Label();
        dividedRightLabel = new Label();
        label9 = new Label();
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
        timeLabel.AutoSize = false;
        timeLabel.BorderStyle = BorderStyle.FixedSingle;
        timeLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        timeLabel.Location = new Point(250, 18);
        timeLabel.Name = "timeLabel";
        timeLabel.Size = new Size(200, 30);
        timeLabel.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(130, 20);
        label1.Name = "label1";
        label1.Size = new Size(104, 25);
        label1.TabIndex = 1;
        label1.Text = "Time Left";
        // 
        // plusLeftLabel
        // 
        plusLeftLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        plusLeftLabel.Location = new Point(50, 75);
        plusLeftLabel.Name = "plusLeftLabel";
        plusLeftLabel.Size = new Size(60, 50);
        plusLeftLabel.TabIndex = 2;
        plusLeftLabel.Text = "?";
        plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
        plusLeftLabel.AutoSize = false;
        // 
        // label2
        // 
        label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(116, 75);
        label2.Name = "label2";
        label2.Size = new Size(40, 50);
        label2.TabIndex = 3;
        label2.Text = "+";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        label2.AutoSize = false;
        // 
        // plusRightLabel
        // 
        plusRightLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        plusRightLabel.Location = new Point(162, 75);
        plusRightLabel.Name = "plusRightLabel";
        plusRightLabel.Size = new Size(60, 50);
        plusRightLabel.TabIndex = 4;
        plusRightLabel.Text = "?";
        plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
        plusRightLabel.AutoSize = false;
        // 
        // label4
        // 
        label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(228, 75);
        label4.Name = "label4";
        label4.Size = new Size(40, 50);
        label4.TabIndex = 5;
        label4.Text = "=";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        label4.AutoSize = false;
        // 
        // sum
        // 
        sum.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        sum.Location = new Point(280, 85);
        sum.MaximumSize = new Size(100, 0);
        sum.Name = "sum";
        sum.Size = new Size(100, 35);
        sum.TabIndex = 1;
        sum.Enter += answer_Enter;
        sum.ValueChanged += answer_ValueChanged;
        // 
        // minusLeftLabel
        // 
        minusLeftLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        minusLeftLabel.Location = new Point(50, 130);
        minusLeftLabel.Name = "minusLeftLabel";
        minusLeftLabel.Size = new Size(60, 50);
        minusLeftLabel.TabIndex = 7;
        minusLeftLabel.Text = "?";
        minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
        minusLeftLabel.AutoSize = false;
        // 
        // label3
        // 
        label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(116, 130);
        label3.Name = "label3";
        label3.Size = new Size(40, 50);
        label3.TabIndex = 8;
        label3.Text = "-";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        label3.AutoSize = false;
        // 
        // minusRightLabel
        // 
        minusRightLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        minusRightLabel.Location = new Point(162, 130);
        minusRightLabel.Name = "minusRightLabel";
        minusRightLabel.Size = new Size(60, 50);
        minusRightLabel.TabIndex = 9;
        minusRightLabel.Text = "?";
        minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
        minusRightLabel.AutoSize = false;
        // 
        // label5
        // 
        label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(228, 130);
        label5.Name = "label5";
        label5.Size = new Size(40, 50);
        label5.TabIndex = 10;
        label5.Text = "=";
        label5.TextAlign = ContentAlignment.MiddleCenter;
        label5.AutoSize = false;
        // 
        // difference
        // 
        difference.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        difference.Location = new Point(280, 140);
        difference.MaximumSize = new Size(100, 0);
        difference.Name = "difference";
        difference.Size = new Size(100, 35);
        difference.TabIndex = 2;
        difference.Enter += answer_Enter;
        difference.ValueChanged += answer_ValueChanged;
        // 
        // timesLeftLabel
        // 
        timesLeftLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        timesLeftLabel.Location = new Point(50, 185);
        timesLeftLabel.Name = "timesLeftLabel";
        timesLeftLabel.Size = new Size(60, 50);
        timesLeftLabel.TabIndex = 12;
        timesLeftLabel.Text = "?";
        timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
        timesLeftLabel.AutoSize = false;
        // 
        // label6
        // 
        label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label6.Location = new Point(116, 185);
        label6.Name = "label6";
        label6.Size = new Size(40, 50);
        label6.TabIndex = 13;
        label6.Text = "×";
        label6.TextAlign = ContentAlignment.MiddleCenter;
        label6.AutoSize = false;
        // 
        // timesRightLabel
        // 
        timesRightLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        timesRightLabel.Location = new Point(162, 185);
        timesRightLabel.Name = "timesRightLabel";
        timesRightLabel.Size = new Size(60, 50);
        timesRightLabel.TabIndex = 14;
        timesRightLabel.Text = "?";
        timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
        timesRightLabel.AutoSize = false;
        // 
        // label7
        // 
        label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(228, 185);
        label7.Name = "label7";
        label7.Size = new Size(40, 50);
        label7.TabIndex = 15;
        label7.Text = "=";
        label7.TextAlign = ContentAlignment.MiddleCenter;
        label7.AutoSize = false;
        // 
        // product
        // 
        product.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        product.Location = new Point(280, 195);
        product.MaximumSize = new Size(100, 0);
        product.Name = "product";
        product.Size = new Size(100, 35);
        product.TabIndex = 3;
        product.Enter += answer_Enter;
        product.ValueChanged += answer_ValueChanged;
        // 
        // dividedLeftLabel
        // 
        dividedLeftLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        dividedLeftLabel.Location = new Point(50, 240);
        dividedLeftLabel.Name = "dividedLeftLabel";
        dividedLeftLabel.Size = new Size(60, 50);
        dividedLeftLabel.TabIndex = 17;
        dividedLeftLabel.Text = "?";
        dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
        dividedLeftLabel.AutoSize = false;
        // 
        // label8
        // 
        label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label8.Location = new Point(116, 240);
        label8.Name = "label8";
        label8.Size = new Size(40, 50);
        label8.TabIndex = 18;
        label8.Text = "÷";
        label8.TextAlign = ContentAlignment.MiddleCenter;
        label8.AutoSize = false;
        // 
        // dividedRightLabel
        // 
        dividedRightLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        dividedRightLabel.Location = new Point(162, 240);
        dividedRightLabel.Name = "dividedRightLabel";
        dividedRightLabel.Size = new Size(60, 50);
        dividedRightLabel.TabIndex = 19;
        dividedRightLabel.Text = "?";
        dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
        dividedRightLabel.AutoSize = false;
        // 
        // label9
        // 
        label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label9.Location = new Point(228, 240);
        label9.Name = "label9";
        label9.Size = new Size(40, 50);
        label9.TabIndex = 20;
        label9.Text = "=";
        label9.TextAlign = ContentAlignment.MiddleCenter;
        label9.AutoSize = false;
        // 
        // quotient
        // 
        quotient.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
        quotient.Location = new Point(280, 250);
        quotient.MaximumSize = new Size(100, 0);
        quotient.Name = "quotient";
        quotient.Size = new Size(100, 35);
        quotient.TabIndex = 4;
        quotient.Enter += answer_Enter;
        quotient.ValueChanged += answer_ValueChanged;
        // 
        // startButton
        // 
        startButton.AutoSize = true;
        startButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
        startButton.Location = new Point(170, 320);
        startButton.Name = "startButton";
        startButton.Size = new Size(148, 34);
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
        ClientSize = new Size(484, 381);
        Controls.Add(startButton);
        Controls.Add(quotient);
        Controls.Add(label9);
        Controls.Add(dividedRightLabel);
        Controls.Add(label8);
        Controls.Add(dividedLeftLabel);
        Controls.Add(product);
        Controls.Add(label7);
        Controls.Add(timesRightLabel);
        Controls.Add(label6);
        Controls.Add(timesLeftLabel);
        Controls.Add(difference);
        Controls.Add(label5);
        Controls.Add(minusRightLabel);
        Controls.Add(label3);
        Controls.Add(minusLeftLabel);
        Controls.Add(sum);
        Controls.Add(label4);
        Controls.Add(plusRightLabel);
        Controls.Add(label2);
        Controls.Add(plusLeftLabel);
        Controls.Add(label1);
        Controls.Add(timeLabel);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        MaximizeBox = false;
        Name = "Form1";
        Text = "Math Quiz";
        ((System.ComponentModel.ISupportInitialize)sum).EndInit();
        ((System.ComponentModel.ISupportInitialize)difference).EndInit();
        ((System.ComponentModel.ISupportInitialize)product).EndInit();
        ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label timeLabel;
    private Label label1;
    private Label plusLeftLabel;
    private Label label2;
    private Label plusRightLabel;
    private Label label4;
    private NumericUpDown sum;
    private Label minusLeftLabel;
    private Label label3;
    private Label minusRightLabel;
    private Label label5;
    private NumericUpDown difference;
    private Label timesLeftLabel;
    private Label label6;
    private Label timesRightLabel;
    private Label label7;
    private NumericUpDown product;
    private Label dividedLeftLabel;
    private Label label8;
    private Label dividedRightLabel;
    private Label label9;
    private NumericUpDown quotient;
    private Button startButton;
    private System.Windows.Forms.Timer timer1;
}
