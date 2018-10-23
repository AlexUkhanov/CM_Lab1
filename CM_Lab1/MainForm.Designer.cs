namespace CM_Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.rbChebyshev = new System.Windows.Forms.RadioButton();
            this.rbEven = new System.Windows.Forms.RadioButton();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.nudPower = new System.Windows.Forms.NumericUpDown();
            this.lblPow = new System.Windows.Forms.Label();
            this.btRun = new System.Windows.Forms.Button();
            this.chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartError = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nudLeft = new System.Windows.Forms.NumericUpDown();
            this.nudRight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).BeginInit();
            this.SuspendLayout();
            // 
            // rbChebyshev
            // 
            this.rbChebyshev.AutoSize = true;
            this.rbChebyshev.Location = new System.Drawing.Point(65, 421);
            this.rbChebyshev.Name = "rbChebyshev";
            this.rbChebyshev.Size = new System.Drawing.Size(131, 17);
            this.rbChebyshev.TabIndex = 0;
            this.rbChebyshev.TabStop = true;
            this.rbChebyshev.Text = "Chebyshev distribution";
            this.rbChebyshev.UseVisualStyleBackColor = true;
            // 
            // rbEven
            // 
            this.rbEven.AutoSize = true;
            this.rbEven.Location = new System.Drawing.Point(258, 421);
            this.rbEven.Name = "rbEven";
            this.rbEven.Size = new System.Drawing.Size(103, 17);
            this.rbEven.TabIndex = 1;
            this.rbEven.TabStop = true;
            this.rbEven.Text = "Even distribution";
            this.rbEven.UseVisualStyleBackColor = true;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(24, 365);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(58, 13);
            this.lblLeft.TabIndex = 4;
            this.lblLeft.Text = "Left border";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(163, 365);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(65, 13);
            this.lblRight.TabIndex = 5;
            this.lblRight.Text = "Right border";
            // 
            // nudPower
            // 
            this.nudPower.Location = new System.Drawing.Point(305, 384);
            this.nudPower.Name = "nudPower";
            this.nudPower.Size = new System.Drawing.Size(120, 20);
            this.nudPower.TabIndex = 7;
            this.nudPower.ValueChanged += new System.EventHandler(this.ChangeEvent);
            // 
            // lblPow
            // 
            this.lblPow.AutoSize = true;
            this.lblPow.Location = new System.Drawing.Point(302, 365);
            this.lblPow.Name = "lblPow";
            this.lblPow.Size = new System.Drawing.Size(37, 13);
            this.lblPow.TabIndex = 8;
            this.lblPow.Text = "Power";
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(673, 415);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 23);
            this.btRun.TabIndex = 11;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // chartFunctions
            // 
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.Interval = 0.05D;
            chartArea3.Name = "main";
            this.chartFunctions.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunctions.Legends.Add(legend3);
            this.chartFunctions.Location = new System.Drawing.Point(27, 12);
            this.chartFunctions.Name = "chartFunctions";
            this.chartFunctions.Size = new System.Drawing.Size(398, 332);
            this.chartFunctions.TabIndex = 12;
            this.chartFunctions.Text = "chart1";
            // 
            // chartError
            // 
            this.chartError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "main";
            this.chartError.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartError.Legends.Add(legend4);
            this.chartError.Location = new System.Drawing.Point(461, 12);
            this.chartError.Name = "chartError";
            this.chartError.Size = new System.Drawing.Size(287, 332);
            this.chartError.TabIndex = 13;
            this.chartError.Text = "chart1";
            // 
            // nudLeft
            // 
            this.nudLeft.DecimalPlaces = 1;
            this.nudLeft.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLeft.Location = new System.Drawing.Point(27, 384);
            this.nudLeft.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLeft.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nudLeft.Name = "nudLeft";
            this.nudLeft.Size = new System.Drawing.Size(120, 20);
            this.nudLeft.TabIndex = 14;
            this.nudLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudRight
            // 
            this.nudRight.DecimalPlaces = 1;
            this.nudRight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRight.Location = new System.Drawing.Point(166, 384);
            this.nudRight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRight.Minimum = new decimal(new int[] {
            59,
            0,
            0,
            -2147483648});
            this.nudRight.Name = "nudRight";
            this.nudRight.Size = new System.Drawing.Size(120, 20);
            this.nudRight.TabIndex = 15;
            this.nudRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.nudRight);
            this.Controls.Add(this.nudLeft);
            this.Controls.Add(this.chartError);
            this.Controls.Add(this.chartFunctions);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.lblPow);
            this.Controls.Add(this.nudPower);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.rbEven);
            this.Controls.Add(this.rbChebyshev);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbChebyshev;
        private System.Windows.Forms.RadioButton rbEven;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.NumericUpDown nudPower;
        private System.Windows.Forms.Label lblPow;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartError;
        private System.Windows.Forms.NumericUpDown nudLeft;
        private System.Windows.Forms.NumericUpDown nudRight;
    }
}

