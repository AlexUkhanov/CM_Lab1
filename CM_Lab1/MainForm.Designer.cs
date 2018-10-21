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
            this.rbChebyshev = new System.Windows.Forms.RadioButton();
            this.rbEven = new System.Windows.Forms.RadioButton();
            this.nudLeft = new System.Windows.Forms.NumericUpDown();
            this.nudRight = new System.Windows.Forms.NumericUpDown();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblPow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(305, 384);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 7;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPow);
            this.Controls.Add(this.numericUpDown2);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblPow;
    }
}

