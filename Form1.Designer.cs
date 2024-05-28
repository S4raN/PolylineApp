namespace GraphPlotter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ListBox listBoxGraphs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.NumericUpDown numericUpDownX0;
        private System.Windows.Forms.NumericUpDown numericUpDownY0;
        private System.Windows.Forms.Label labelX0;
        private System.Windows.Forms.Label labelY0;

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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxGraphs = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.numericUpDownX0 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY0 = new System.Windows.Forms.NumericUpDown();
            this.labelX0 = new System.Windows.Forms.Label();
            this.labelY0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY0)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(776, 426);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // listBoxGraphs
            // 
            this.listBoxGraphs.FormattingEnabled = true;
            this.listBoxGraphs.Location = new System.Drawing.Point(12, 444);
            this.listBoxGraphs.Name = "listBoxGraphs";
            this.listBoxGraphs.Size = new System.Drawing.Size(200, 95);
            this.listBoxGraphs.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 444);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 444);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 20);
            this.textBox3.TabIndex = 4;
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(416, 444);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 5;
            this.btnPlot.Text = "build";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // numericUpDownX0
            // 
            this.numericUpDownX0.Location = new System.Drawing.Point(218, 483);
            this.numericUpDownX0.Name = "numericUpDownX0";
            this.numericUpDownX0.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownX0.TabIndex = 6;
            this.numericUpDownX0.ValueChanged += new System.EventHandler(this.numericUpDownX0_ValueChanged);
            // 
            // numericUpDownY0
            // 
            this.numericUpDownY0.Location = new System.Drawing.Point(324, 483);
            this.numericUpDownY0.Name = "numericUpDownY0";
            this.numericUpDownY0.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownY0.TabIndex = 7;
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Location = new System.Drawing.Point(218, 467);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(74, 13);
            this.labelX0.TabIndex = 8;
            this.labelX0.Text = "Начало X (x0)";
            // 
            // labelY0
            // 
            this.labelY0.AutoSize = true;
            this.labelY0.Location = new System.Drawing.Point(321, 467);
            this.labelY0.Name = "labelY0";
            this.labelY0.Size = new System.Drawing.Size(74, 13);
            this.labelY0.TabIndex = 9;
            this.labelY0.Text = "Начало Y (y0)";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.labelY0);
            this.Controls.Add(this.labelX0);
            this.Controls.Add(this.numericUpDownY0);
            this.Controls.Add(this.numericUpDownX0);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxGraphs);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
