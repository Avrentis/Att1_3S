namespace Task2WInForm
{
    partial class MobileOperatorForm
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.enginePower_lbl = new System.Windows.Forms.Label();
            this.seatsCount_lbl = new System.Windows.Forms.Label();
            this.yearMade_lbl = new System.Windows.Forms.Label();
            this.Check_btn = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.enginePower_box = new System.Windows.Forms.TextBox();
            this.seatsCount_box = new System.Windows.Forms.TextBox();
            this.radio_class1 = new System.Windows.Forms.RadioButton();
            this.radio_class2 = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Choose_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.yearMade_box = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(12, 22);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(108, 17);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Марка машины";
            // 
            // enginePower_lbl
            // 
            this.enginePower_lbl.AutoSize = true;
            this.enginePower_lbl.Location = new System.Drawing.Point(12, 67);
            this.enginePower_lbl.Name = "enginePower_lbl";
            this.enginePower_lbl.Size = new System.Drawing.Size(146, 17);
            this.enginePower_lbl.TabIndex = 1;
            this.enginePower_lbl.Text = "Мощность двигателя";
            // 
            // seatsCount_lbl
            // 
            this.seatsCount_lbl.AutoSize = true;
            this.seatsCount_lbl.Location = new System.Drawing.Point(12, 112);
            this.seatsCount_lbl.Name = "seatsCount_lbl";
            this.seatsCount_lbl.Size = new System.Drawing.Size(84, 17);
            this.seatsCount_lbl.TabIndex = 2;
            this.seatsCount_lbl.Text = "Число мест";
            // 
            // yearMade_lbl
            // 
            this.yearMade_lbl.AutoSize = true;
            this.yearMade_lbl.Location = new System.Drawing.Point(12, 161);
            this.yearMade_lbl.Name = "yearMade_lbl";
            this.yearMade_lbl.Size = new System.Drawing.Size(126, 17);
            this.yearMade_lbl.TabIndex = 3;
            this.yearMade_lbl.Text = "Год изготовления";
            // 
            // Check_btn
            // 
            this.Check_btn.Location = new System.Drawing.Point(823, 323);
            this.Check_btn.Name = "Check_btn";
            this.Check_btn.Size = new System.Drawing.Size(294, 247);
            this.Check_btn.TabIndex = 4;
            this.Check_btn.Text = "Подтвердить";
            this.Check_btn.UseVisualStyleBackColor = true;
            this.Check_btn.Click += new System.EventHandler(this.Check_btn_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(269, 17);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(256, 22);
            this.name_box.TabIndex = 9;
            // 
            // enginePower_box
            // 
            this.enginePower_box.Location = new System.Drawing.Point(269, 67);
            this.enginePower_box.Name = "enginePower_box";
            this.enginePower_box.Size = new System.Drawing.Size(256, 22);
            this.enginePower_box.TabIndex = 10;
            this.enginePower_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // seatsCount_box
            // 
            this.seatsCount_box.Location = new System.Drawing.Point(269, 107);
            this.seatsCount_box.Name = "seatsCount_box";
            this.seatsCount_box.Size = new System.Drawing.Size(256, 22);
            this.seatsCount_box.TabIndex = 11;
            this.seatsCount_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // radio_class1
            // 
            this.radio_class1.AutoSize = true;
            this.radio_class1.Location = new System.Drawing.Point(51, 37);
            this.radio_class1.Name = "radio_class1";
            this.radio_class1.Size = new System.Drawing.Size(223, 21);
            this.radio_class1.TabIndex = 15;
            this.radio_class1.TabStop = true;
            this.radio_class1.Text = "Автомобиль типа 1-го уровня";
            this.radio_class1.UseVisualStyleBackColor = true;
            // 
            // radio_class2
            // 
            this.radio_class2.AutoSize = true;
            this.radio_class2.BackColor = System.Drawing.SystemColors.Control;
            this.radio_class2.Location = new System.Drawing.Point(51, 90);
            this.radio_class2.Name = "radio_class2";
            this.radio_class2.Size = new System.Drawing.Size(223, 21);
            this.radio_class2.TabIndex = 16;
            this.radio_class2.TabStop = true;
            this.radio_class2.Text = "Автомобиль типа 2-го уровня";
            this.radio_class2.UseVisualStyleBackColor = false;
            this.radio_class2.CheckedChanged += new System.EventHandler(this.Radio_class_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.radio_class1);
            this.groupBox.Controls.Add(this.radio_class2);
            this.groupBox.Location = new System.Drawing.Point(716, 6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(401, 143);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 17;
            // 
            // Choose_btn
            // 
            this.Choose_btn.Location = new System.Drawing.Point(805, 232);
            this.Choose_btn.Name = "Choose_btn";
            this.Choose_btn.Size = new System.Drawing.Size(312, 72);
            this.Choose_btn.TabIndex = 17;
            this.Choose_btn.Text = "Создать";
            this.Choose_btn.UseVisualStyleBackColor = true;
            this.Choose_btn.Click += new System.EventHandler(this.Choose_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Результат";
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(185, 257);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(286, 22);
            this.resBox.TabIndex = 19;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(32, 323);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(767, 247);
            this.dataGridView.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Марка машины";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Мощность двигателя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Число мест";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Год изготовления";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Результат подсчета";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(575, 240);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(178, 57);
            this.Clear_btn.TabIndex = 21;
            this.Clear_btn.Text = "Очистить список";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // yearMade_box
            // 
            this.yearMade_box.Location = new System.Drawing.Point(269, 161);
            this.yearMade_box.Name = "yearMade_box";
            this.yearMade_box.Size = new System.Drawing.Size(256, 22);
            this.yearMade_box.TabIndex = 22;
            // 
            // MobileOperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 582);
            this.Controls.Add(this.yearMade_box);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Choose_btn);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.seatsCount_box);
            this.Controls.Add(this.enginePower_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.Check_btn);
            this.Controls.Add(this.yearMade_lbl);
            this.Controls.Add(this.seatsCount_lbl);
            this.Controls.Add(this.enginePower_lbl);
            this.Controls.Add(this.name_lbl);
            this.Name = "MobileOperatorForm";
            this.Text = "Автомобильная база данных";
            this.Load += new System.EventHandler(this.MobileOperatorForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label enginePower_lbl;
        private System.Windows.Forms.Label seatsCount_lbl;
        private System.Windows.Forms.Label yearMade_lbl;
        private System.Windows.Forms.Button Check_btn;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox enginePower_box;
        private System.Windows.Forms.TextBox seatsCount_box;
        private System.Windows.Forms.RadioButton radio_class1;
        private System.Windows.Forms.RadioButton radio_class2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Choose_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox yearMade_box;
    }
}

