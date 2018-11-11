namespace Task1
{
    partial class Form1
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
            this.SelectDate_btn = new System.Windows.Forms.Button();
            this.PrintDay_btn = new System.Windows.Forms.Button();
            this.CalculateDays_btn = new System.Windows.Forms.Button();
            this.CalculateMonths_btn = new System.Windows.Forms.Button();
            this.ChooseDay1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseYear1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReadDays_box = new System.Windows.Forms.TextBox();
            this.ReadMonths_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseDay2 = new System.Windows.Forms.NumericUpDown();
            this.chooseYear2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dayOfTheWeek_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chooseMonth1 = new System.Windows.Forms.NumericUpDown();
            this.chooseMonth2 = new System.Windows.Forms.NumericUpDown();
            this.err_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseDay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseYear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseDay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseYear2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseMonth2)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDate_btn
            // 
            this.SelectDate_btn.Location = new System.Drawing.Point(671, 29);
            this.SelectDate_btn.Name = "SelectDate_btn";
            this.SelectDate_btn.Size = new System.Drawing.Size(137, 61);
            this.SelectDate_btn.TabIndex = 0;
            this.SelectDate_btn.Text = "Задать дату";
            this.SelectDate_btn.UseVisualStyleBackColor = true;
            this.SelectDate_btn.Click += new System.EventHandler(this.SelectDate_btn_Click);
            // 
            // PrintDay_btn
            // 
            this.PrintDay_btn.Location = new System.Drawing.Point(671, 123);
            this.PrintDay_btn.Name = "PrintDay_btn";
            this.PrintDay_btn.Size = new System.Drawing.Size(137, 61);
            this.PrintDay_btn.TabIndex = 1;
            this.PrintDay_btn.Text = "Вывести день по заданной дате";
            this.PrintDay_btn.UseVisualStyleBackColor = true;
            this.PrintDay_btn.Click += new System.EventHandler(this.PrintDay_btn_Click);
            // 
            // CalculateDays_btn
            // 
            this.CalculateDays_btn.Location = new System.Drawing.Point(671, 211);
            this.CalculateDays_btn.Name = "CalculateDays_btn";
            this.CalculateDays_btn.Size = new System.Drawing.Size(137, 61);
            this.CalculateDays_btn.TabIndex = 2;
            this.CalculateDays_btn.Text = "Рассчитать кол-во дней в промежутке";
            this.CalculateDays_btn.UseVisualStyleBackColor = true;
            this.CalculateDays_btn.Click += new System.EventHandler(this.CalculateDays_btn_Click);
            // 
            // CalculateMonths_btn
            // 
            this.CalculateMonths_btn.Location = new System.Drawing.Point(671, 303);
            this.CalculateMonths_btn.Name = "CalculateMonths_btn";
            this.CalculateMonths_btn.Size = new System.Drawing.Size(137, 61);
            this.CalculateMonths_btn.TabIndex = 3;
            this.CalculateMonths_btn.Text = "Расчитать кол-во месяцев в промежутке";
            this.CalculateMonths_btn.UseVisualStyleBackColor = true;
            this.CalculateMonths_btn.Click += new System.EventHandler(this.CalculateMonths_btn_Click);
            // 
            // ChooseDay1
            // 
            this.ChooseDay1.Location = new System.Drawing.Point(186, 143);
            this.ChooseDay1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ChooseDay1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChooseDay1.Name = "ChooseDay1";
            this.ChooseDay1.Size = new System.Drawing.Size(50, 22);
            this.ChooseDay1.TabIndex = 4;
            this.ChooseDay1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите дату:";
            // 
            // chooseYear1
            // 
            this.chooseYear1.Location = new System.Drawing.Point(266, 143);
            this.chooseYear1.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.chooseYear1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chooseYear1.Name = "chooseYear1";
            this.chooseYear1.Size = new System.Drawing.Size(90, 22);
            this.chooseYear1.TabIndex = 7;
            this.chooseYear1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "День";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(286, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Год";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Месяц";
            // 
            // ReadDays_box
            // 
            this.ReadDays_box.Location = new System.Drawing.Point(510, 250);
            this.ReadDays_box.Name = "ReadDays_box";
            this.ReadDays_box.Size = new System.Drawing.Size(131, 22);
            this.ReadDays_box.TabIndex = 11;
            // 
            // ReadMonths_box
            // 
            this.ReadMonths_box.Location = new System.Drawing.Point(510, 342);
            this.ReadMonths_box.Name = "ReadMonths_box";
            this.ReadMonths_box.Size = new System.Drawing.Size(131, 22);
            this.ReadMonths_box.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Выберите вторую дату для рассчета";
            // 
            // chooseDay2
            // 
            this.chooseDay2.Location = new System.Drawing.Point(186, 417);
            this.chooseDay2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.chooseDay2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chooseDay2.Name = "chooseDay2";
            this.chooseDay2.Size = new System.Drawing.Size(50, 22);
            this.chooseDay2.TabIndex = 15;
            this.chooseDay2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chooseYear2
            // 
            this.chooseYear2.Location = new System.Drawing.Point(266, 417);
            this.chooseYear2.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.chooseYear2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chooseYear2.Name = "chooseYear2";
            this.chooseYear2.Size = new System.Drawing.Size(90, 22);
            this.chooseYear2.TabIndex = 16;
            this.chooseYear2.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(54, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Месяц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(188, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "День";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(286, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Год";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(520, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Кол-во дней";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(507, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Кол-во месяцев";
            // 
            // dayOfTheWeek_box
            // 
            this.dayOfTheWeek_box.Location = new System.Drawing.Point(510, 162);
            this.dayOfTheWeek_box.Name = "dayOfTheWeek_box";
            this.dayOfTheWeek_box.Size = new System.Drawing.Size(131, 22);
            this.dayOfTheWeek_box.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(491, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "День недели по дате";
            // 
            // chooseMonth1
            // 
            this.chooseMonth1.Location = new System.Drawing.Point(57, 143);
            this.chooseMonth1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.chooseMonth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chooseMonth1.Name = "chooseMonth1";
            this.chooseMonth1.Size = new System.Drawing.Size(50, 22);
            this.chooseMonth1.TabIndex = 24;
            this.chooseMonth1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chooseMonth2
            // 
            this.chooseMonth2.Location = new System.Drawing.Point(57, 417);
            this.chooseMonth2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.chooseMonth2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chooseMonth2.Name = "chooseMonth2";
            this.chooseMonth2.Size = new System.Drawing.Size(50, 22);
            this.chooseMonth2.TabIndex = 25;
            this.chooseMonth2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // err_lbl
            // 
            this.err_lbl.AutoSize = true;
            this.err_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.err_lbl.Location = new System.Drawing.Point(301, 29);
            this.err_lbl.Name = "err_lbl";
            this.err_lbl.Size = new System.Drawing.Size(0, 29);
            this.err_lbl.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 531);
            this.Controls.Add(this.err_lbl);
            this.Controls.Add(this.chooseMonth2);
            this.Controls.Add(this.chooseMonth1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dayOfTheWeek_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chooseYear2);
            this.Controls.Add(this.chooseDay2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReadMonths_box);
            this.Controls.Add(this.ReadDays_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseYear1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseDay1);
            this.Controls.Add(this.CalculateMonths_btn);
            this.Controls.Add(this.CalculateDays_btn);
            this.Controls.Add(this.PrintDay_btn);
            this.Controls.Add(this.SelectDate_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChooseDay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseYear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseDay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseYear2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseMonth2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectDate_btn;
        private System.Windows.Forms.Button PrintDay_btn;
        private System.Windows.Forms.Button CalculateDays_btn;
        private System.Windows.Forms.Button CalculateMonths_btn;
        private System.Windows.Forms.NumericUpDown ChooseDay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown chooseYear1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReadDays_box;
        private System.Windows.Forms.TextBox ReadMonths_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown chooseDay2;
        private System.Windows.Forms.NumericUpDown chooseYear2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dayOfTheWeek_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown chooseMonth1;
        private System.Windows.Forms.NumericUpDown chooseMonth2;
        private System.Windows.Forms.Label err_lbl;
    }
}

