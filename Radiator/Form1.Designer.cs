namespace Radiator
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.numRthcj = new System.Windows.Forms.NumericUpDown();
            this.numRthcs = new System.Windows.Forms.NumericUpDown();
            this.numRthja = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numU = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numTa = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRthcj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRthcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRthja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dane Tranzystora";
            // 
            // numR
            // 
            this.numR.DecimalPlaces = 2;
            this.numR.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numR.Location = new System.Drawing.Point(12, 29);
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(120, 20);
            this.numR.TabIndex = 1;
            this.numR.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numRthcj
            // 
            this.numRthcj.DecimalPlaces = 2;
            this.numRthcj.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numRthcj.Location = new System.Drawing.Point(12, 55);
            this.numRthcj.Name = "numRthcj";
            this.numRthcj.Size = new System.Drawing.Size(120, 20);
            this.numRthcj.TabIndex = 1;
            this.numRthcj.Value = new decimal(new int[] {
            45,
            0,
            0,
            131072});
            // 
            // numRthcs
            // 
            this.numRthcs.DecimalPlaces = 2;
            this.numRthcs.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numRthcs.Location = new System.Drawing.Point(12, 81);
            this.numRthcs.Name = "numRthcs";
            this.numRthcs.Size = new System.Drawing.Size(120, 20);
            this.numRthcs.TabIndex = 1;
            this.numRthcs.Value = new decimal(new int[] {
            14,
            0,
            0,
            65536});
            // 
            // numRthja
            // 
            this.numRthja.DecimalPlaces = 2;
            this.numRthja.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numRthja.Location = new System.Drawing.Point(12, 107);
            this.numRthja.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRthja.Name = "numRthja";
            this.numRthja.Size = new System.Drawing.Size(120, 20);
            this.numRthja.TabIndex = 1;
            this.numRthja.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "R - Rezystancja Tranzystora [Ω]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rthcj - Rezystancja termiczna złącze do obudowy [°C/W]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rthcs - Rezystancja termiczna obudowa do radiatora [°C/W]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rthja - Rezystancja termiczna złącze do otoczenia [°C/W]";
            // 
            // numU
            // 
            this.numU.DecimalPlaces = 2;
            this.numU.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numU.Location = new System.Drawing.Point(12, 133);
            this.numU.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numU.Name = "numU";
            this.numU.Size = new System.Drawing.Size(120, 20);
            this.numU.TabIndex = 1;
            this.numU.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "U - Maksymalne napięcie na wykresie [V]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rysuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Napięcie [V]";
            chartArea1.AxisY.Title = "Temperatura [°C]";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 188);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(798, 343);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "f(U)=T";
            this.chart1.Titles.Add(title1);
            // 
            // numTa
            // 
            this.numTa.Location = new System.Drawing.Point(469, 24);
            this.numTa.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTa.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numTa.Name = "numTa";
            this.numTa.Size = new System.Drawing.Size(120, 20);
            this.numTa.TabIndex = 1;
            this.numTa.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Temperatura Otoczenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 543);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numTa);
            this.Controls.Add(this.numU);
            this.Controls.Add(this.numRthja);
            this.Controls.Add(this.numRthcs);
            this.Controls.Add(this.numRthcj);
            this.Controls.Add(this.numR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XD";
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRthcj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRthcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRthja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numRthcj;
        private System.Windows.Forms.NumericUpDown numRthcs;
        private System.Windows.Forms.NumericUpDown numRthja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numTa;
        private System.Windows.Forms.Label label7;
    }
}

