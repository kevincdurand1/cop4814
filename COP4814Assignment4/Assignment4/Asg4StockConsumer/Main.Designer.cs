namespace Asg4StockConsumer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnAvg = new System.Windows.Forms.Button();
            this.mskDays = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chtDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCompare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Start Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCompare);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.btnAvg);
            this.groupBox1.Controls.Add(this.mskDays);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(124, 21);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(77, 20);
            this.txtStart.TabIndex = 2;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(124, 62);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(77, 20);
            this.txtEnd.TabIndex = 4;
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(450, 59);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(110, 23);
            this.btnAvg.TabIndex = 7;
            this.btnAvg.Text = "Show Moving Avg\r\n";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.allShow_Click);
            // 
            // mskDays
            // 
            this.mskDays.HidePromptOnLeave = true;
            this.mskDays.Location = new System.Drawing.Point(484, 20);
            this.mskDays.Mask = "000";
            this.mskDays.Name = "mskDays";
            this.mskDays.Size = new System.Drawing.Size(39, 20);
            this.mskDays.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Days";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(217, 61);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Close Prices";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.allShow_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select End Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chtDisplay
            // 
            chartArea2.Name = "ChartArea1";
            this.chtDisplay.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtDisplay.Legends.Add(legend2);
            this.chtDisplay.Location = new System.Drawing.Point(12, 106);
            this.chtDisplay.Name = "chtDisplay";
            this.chtDisplay.Size = new System.Drawing.Size(784, 377);
            this.chtDisplay.TabIndex = 3;
            this.chtDisplay.Text = "chart1";
            // 
            // errPro
            // 
            this.errPro.ContainerControl = this;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(653, 59);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(110, 23);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 495);
            this.Controls.Add(this.chtDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Stock Price Display";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDisplay;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.MaskedTextBox mskDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errPro;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnCompare;
    }
}

