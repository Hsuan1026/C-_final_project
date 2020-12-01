namespace final_project
{
    partial class Form_money
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Back_btn = new System.Windows.Forms.Button();
            this.dateText = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.expense_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.choose_date = new System.Windows.Forms.Button();
            this.expense_item = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_page = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.chart_page.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Back_btn.FlatAppearance.BorderSize = 2;
            this.Back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Back_btn.ForeColor = System.Drawing.Color.Black;
            this.Back_btn.Location = new System.Drawing.Point(12, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(92, 39);
            this.Back_btn.TabIndex = 1;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // dateText
            // 
            this.dateText.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateText.Location = new System.Drawing.Point(84, 72);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(235, 38);
            this.dateText.TabIndex = 2;
            this.dateText.Text = "選擇日期";
            this.dateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(57, 119);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "$128";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // income
            // 
            this.income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.income.BackgroundImage = global::final_project.Properties.Resources.income;
            this.income.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.income.FlatAppearance.BorderSize = 0;
            this.income.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.income.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income.Location = new System.Drawing.Point(165, 612);
            this.income.Margin = new System.Windows.Forms.Padding(0);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(80, 80);
            this.income.TabIndex = 8;
            this.income.UseVisualStyleBackColor = false;
            this.income.Click += new System.EventHandler(this.income_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.BackgroundImage = global::final_project.Properties.Resources.pie_chart;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(308, 612);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // expense_btn
            // 
            this.expense_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.expense_btn.BackgroundImage = global::final_project.Properties.Resources.expense1;
            this.expense_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.expense_btn.FlatAppearance.BorderSize = 0;
            this.expense_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.expense_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.expense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_btn.Location = new System.Drawing.Point(12, 612);
            this.expense_btn.Margin = new System.Windows.Forms.Padding(0);
            this.expense_btn.Name = "expense_btn";
            this.expense_btn.Size = new System.Drawing.Size(80, 80);
            this.expense_btn.TabIndex = 6;
            this.expense_btn.UseVisualStyleBackColor = false;
            this.expense_btn.Click += new System.EventHandler(this.expense_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_btn.BackgroundImage = global::final_project.Properties.Resources.add;
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Location = new System.Drawing.Point(338, 60);
            this.add_btn.Margin = new System.Windows.Forms.Padding(0);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(50, 50);
            this.add_btn.TabIndex = 3;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // choose_date
            // 
            this.choose_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.choose_date.BackgroundImage = global::final_project.Properties.Resources.calendar;
            this.choose_date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.choose_date.FlatAppearance.BorderSize = 0;
            this.choose_date.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.choose_date.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.choose_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_date.Location = new System.Drawing.Point(12, 60);
            this.choose_date.Margin = new System.Windows.Forms.Padding(0);
            this.choose_date.Name = "choose_date";
            this.choose_date.Size = new System.Drawing.Size(50, 50);
            this.choose_date.TabIndex = 0;
            this.choose_date.UseVisualStyleBackColor = false;
            this.choose_date.Click += new System.EventHandler(this.choose_date_Click);
            // 
            // expense_item
            // 
            this.expense_item.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.expense_item.FormattingEnabled = true;
            this.expense_item.HorizontalScrollbar = true;
            this.expense_item.ItemHeight = 34;
            this.expense_item.Location = new System.Drawing.Point(12, 187);
            this.expense_item.Name = "expense_item";
            this.expense_item.ScrollAlwaysVisible = true;
            this.expense_item.Size = new System.Drawing.Size(376, 412);
            this.expense_item.TabIndex = 11;
            this.expense_item.DoubleClick += new System.EventHandler(this.expense_item_DoubleClick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "money_analyse";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(356, 371);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // chart_page
            // 
            this.chart_page.Controls.Add(this.tabPage1);
            this.chart_page.Controls.Add(this.tabPage2);
            this.chart_page.Location = new System.Drawing.Point(12, 187);
            this.chart_page.Name = "chart_page";
            this.chart_page.SelectedIndex = 0;
            this.chart_page.Size = new System.Drawing.Size(376, 412);
            this.chart_page.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "單日收入及支出";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "單月收入及支出";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "money_analyse";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(362, 377);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // Form_money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.ControlBox = false;
            this.Controls.Add(this.chart_page);
            this.Controls.Add(this.expense_item);
            this.Controls.Add(this.income);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.expense_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.choose_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_money";
            this.Load += new System.EventHandler(this.Form_money_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.chart_page.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choose_date;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button expense_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button income;
        private System.Windows.Forms.ListBox expense_item;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl chart_page;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}