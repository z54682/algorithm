namespace algorithm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labResult = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.btnPrime = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnBigAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(12, 37);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(48, 12);
            this.labResult.TabIndex = 0;
            this.labResult.Text = "labResult";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(12, 12);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 22);
            this.txtNumber1.TabIndex = 1;
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(12, 123);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(75, 23);
            this.btnFibonacci.TabIndex = 3;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // btnPrime
            // 
            this.btnPrime.Location = new System.Drawing.Point(12, 152);
            this.btnPrime.Name = "btnPrime";
            this.btnPrime.Size = new System.Drawing.Size(75, 23);
            this.btnPrime.TabIndex = 4;
            this.btnPrime.Text = "Prime";
            this.btnPrime.UseVisualStyleBackColor = true;
            this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(12, 181);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(75, 23);
            this.btnFactorial.TabIndex = 5;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(118, 12);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 22);
            this.txtNumber2.TabIndex = 2;
            // 
            // btnBigAdd
            // 
            this.btnBigAdd.Location = new System.Drawing.Point(12, 65);
            this.btnBigAdd.Name = "btnBigAdd";
            this.btnBigAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBigAdd.TabIndex = 6;
            this.btnBigAdd.Text = "BigAdd";
            this.btnBigAdd.UseVisualStyleBackColor = true;
            this.btnBigAdd.Click += new System.EventHandler(this.btnBigAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 212);
            this.Controls.Add(this.btnBigAdd);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnPrime);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.labResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Button btnPrime;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnBigAdd;
    }
}

