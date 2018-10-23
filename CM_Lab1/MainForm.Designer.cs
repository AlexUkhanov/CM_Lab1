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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rbChebyshev = new System.Windows.Forms.RadioButton();
            this.rbEven = new System.Windows.Forms.RadioButton();
            this.nudLeft = new System.Windows.Forms.NumericUpDown();
            this.nudRight = new System.Windows.Forms.NumericUpDown();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.nudPower = new System.Windows.Forms.NumericUpDown();
            this.lblPow = new System.Windows.Forms.Label();
            this.chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartError = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartError)).BeginInit();
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
            // nudLeft
            // 
            this.nudLeft.Location = new System.Drawing.Point(27, 384);
            this.nudLeft.Name = "nudLeft";
            this.nudLeft.Size = new System.Drawing.Size(120, 20);
            this.nudLeft.TabIndex = 2;
            // 
            // nudRight
            // 
            this.nudRight.Location = new System.Drawing.Point(166, 384);
            this.nudRight.Name = "nudRight";
            this.nudRight.Size = new System.Drawing.Size(120, 20);
            this.nudRight.TabIndex = 3;
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
            // chartFunctions
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunctions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunctions.Legends.Add(legend1);
            this.chartFunctions.Location = new System.Drawing.Point(27, 12);
            this.chartFunctions.Name = "chartFunctions";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunctions.Series.Add(series1);
            this.chartFunctions.Size = new System.Drawing.Size(398, 300);
            this.chartFunctions.TabIndex = 9;
            this.chartFunctions.Text = "chart1";
            // 
            // chartError
            // 
            chartArea2.Name = "ChartArea1";
            this.chartError.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartError.Legends.Add(legend2);
            this.chartError.Location = new System.Drawing.Point(465, 12);
            this.chartError.Name = "chartError";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartError.Series.Add(series2);
            this.chartError.Size = new System.Drawing.Size(323, 300);
            this.chartError.TabIndex = 10;
            this.chartError.Text = "chart2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartError);
            this.Controls.Add(this.chartFunctions);
            this.Controls.Add(this.lblPow);
            this.Controls.Add(this.nudPower);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.nudRight);
            this.Controls.Add(this.nudLeft);
            this.Controls.Add(this.rbEven);
            this.Controls.Add(this.rbChebyshev);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbChebyshev;
        private System.Windows.Forms.RadioButton rbEven;
        private System.Windows.Forms.NumericUpDown nudLeft;
        private System.Windows.Forms.NumericUpDown nudRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.NumericUpDown nudPower;
        private System.Windows.Forms.Label lblPow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartError;
    }
}

