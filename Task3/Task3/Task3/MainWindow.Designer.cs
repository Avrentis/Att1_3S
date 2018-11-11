namespace Task3
{
    partial class MainWindow
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
            this.dataGrid_dgv = new System.Windows.Forms.DataGridView();
            this.Heading_lbl = new System.Windows.Forms.Label();
            this.inputQuality_lbl = new System.Windows.Forms.Label();
            this.InputThickness_lbl = new System.Windows.Forms.Label();
            this.InputSheetsNum_lbl = new System.Windows.Forms.Label();
            this.inputQuality_txt = new System.Windows.Forms.TextBox();
            this.inputThickness_txt = new System.Windows.Forms.TextBox();
            this.inputSheetsNum_txt = new System.Windows.Forms.TextBox();
            this.CreateDrawingNotebook_btn = new System.Windows.Forms.Button();
            this.Quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheetsNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputQuality = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OutputType = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OutputThickness = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OutputSheetsNum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OutputCountryManufacturer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_dgv
            // 
            this.dataGrid_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quality,
            this.Thickness,
            this.TypeOfProduct,
            this.SheetsNum,
            this.CountryManufacturer,
            this.OutputQuality,
            this.OutputType,
            this.OutputThickness,
            this.OutputSheetsNum,
            this.OutputCountryManufacturer});
            this.dataGrid_dgv.Location = new System.Drawing.Point(20, 15);
            this.dataGrid_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_dgv.Name = "dataGrid_dgv";
            this.dataGrid_dgv.Size = new System.Drawing.Size(1722, 385);
            this.dataGrid_dgv.TabIndex = 0;
            this.dataGrid_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_dgv_CellContentClick);
            // 
            // Heading_lbl
            // 
            this.Heading_lbl.AutoSize = true;
            this.Heading_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading_lbl.Location = new System.Drawing.Point(42, 404);
            this.Heading_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Heading_lbl.Name = "Heading_lbl";
            this.Heading_lbl.Size = new System.Drawing.Size(250, 21);
            this.Heading_lbl.TabIndex = 1;
            this.Heading_lbl.Text = "Создать тетрадь для рисования: ";
            // 
            // inputQuality_lbl
            // 
            this.inputQuality_lbl.AutoSize = true;
            this.inputQuality_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputQuality_lbl.Location = new System.Drawing.Point(16, 442);
            this.inputQuality_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputQuality_lbl.Name = "inputQuality_lbl";
            this.inputQuality_lbl.Size = new System.Drawing.Size(242, 21);
            this.inputQuality_lbl.TabIndex = 2;
            this.inputQuality_lbl.Text = "Введите качество бумаги(1-10): ";
            // 
            // InputThickness_lbl
            // 
            this.InputThickness_lbl.AutoSize = true;
            this.InputThickness_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputThickness_lbl.Location = new System.Drawing.Point(13, 513);
            this.InputThickness_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputThickness_lbl.Name = "InputThickness_lbl";
            this.InputThickness_lbl.Size = new System.Drawing.Size(279, 21);
            this.InputThickness_lbl.TabIndex = 3;
            this.InputThickness_lbl.Text = "Введите толщину бумаги(0.5 - 2мм): ";
            // 
            // InputSheetsNum_lbl
            // 
            this.InputSheetsNum_lbl.AutoSize = true;
            this.InputSheetsNum_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSheetsNum_lbl.Location = new System.Drawing.Point(16, 574);
            this.InputSheetsNum_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputSheetsNum_lbl.Name = "InputSheetsNum_lbl";
            this.InputSheetsNum_lbl.Size = new System.Drawing.Size(185, 21);
            this.InputSheetsNum_lbl.TabIndex = 4;
            this.InputSheetsNum_lbl.Text = "Введите число страниц: ";
            // 
            // inputQuality_txt
            // 
            this.inputQuality_txt.Location = new System.Drawing.Point(20, 478);
            this.inputQuality_txt.Margin = new System.Windows.Forms.Padding(4);
            this.inputQuality_txt.Name = "inputQuality_txt";
            this.inputQuality_txt.Size = new System.Drawing.Size(255, 22);
            this.inputQuality_txt.TabIndex = 6;
            // 
            // inputThickness_txt
            // 
            this.inputThickness_txt.Location = new System.Drawing.Point(20, 548);
            this.inputThickness_txt.Margin = new System.Windows.Forms.Padding(4);
            this.inputThickness_txt.Name = "inputThickness_txt";
            this.inputThickness_txt.Size = new System.Drawing.Size(255, 22);
            this.inputThickness_txt.TabIndex = 7;
            // 
            // inputSheetsNum_txt
            // 
            this.inputSheetsNum_txt.Location = new System.Drawing.Point(20, 610);
            this.inputSheetsNum_txt.Margin = new System.Windows.Forms.Padding(4);
            this.inputSheetsNum_txt.Name = "inputSheetsNum_txt";
            this.inputSheetsNum_txt.Size = new System.Drawing.Size(255, 22);
            this.inputSheetsNum_txt.TabIndex = 8;
            // 
            // CreateDrawingNotebook_btn
            // 
            this.CreateDrawingNotebook_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDrawingNotebook_btn.Location = new System.Drawing.Point(311, 478);
            this.CreateDrawingNotebook_btn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateDrawingNotebook_btn.Name = "CreateDrawingNotebook_btn";
            this.CreateDrawingNotebook_btn.Size = new System.Drawing.Size(401, 154);
            this.CreateDrawingNotebook_btn.TabIndex = 10;
            this.CreateDrawingNotebook_btn.Text = "Создать тетрадь";
            this.CreateDrawingNotebook_btn.UseVisualStyleBackColor = true;
            this.CreateDrawingNotebook_btn.Click += new System.EventHandler(this.CreateDrawingNotebook_btn_Click);
            // 
            // Quality
            // 
            this.Quality.HeaderText = "Качество бумаги";
            this.Quality.Name = "Quality";
            this.Quality.Width = 75;
            // 
            // Thickness
            // 
            this.Thickness.HeaderText = "Толщина бумаги";
            this.Thickness.Name = "Thickness";
            // 
            // TypeOfProduct
            // 
            this.TypeOfProduct.HeaderText = "Тип изделия";
            this.TypeOfProduct.Name = "TypeOfProduct";
            // 
            // SheetsNum
            // 
            this.SheetsNum.HeaderText = "Кол-во страниц";
            this.SheetsNum.Name = "SheetsNum";
            // 
            // CountryManufacturer
            // 
            this.CountryManufacturer.HeaderText = "Страна-производитель";
            this.CountryManufacturer.Name = "CountryManufacturer";
            this.CountryManufacturer.Width = 125;
            // 
            // OutputQuality
            // 
            this.OutputQuality.HeaderText = "Вывести качество бумаги";
            this.OutputQuality.Name = "OutputQuality";
            this.OutputQuality.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OutputQuality.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OutputQuality.Width = 80;
            // 
            // OutputType
            // 
            this.OutputType.HeaderText = "Вывести тип изделия";
            this.OutputType.Name = "OutputType";
            this.OutputType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OutputType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OutputType.Width = 200;
            // 
            // OutputThickness
            // 
            this.OutputThickness.HeaderText = "Вывести толщину бумаги";
            this.OutputThickness.Name = "OutputThickness";
            this.OutputThickness.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OutputThickness.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OutputSheetsNum
            // 
            this.OutputSheetsNum.HeaderText = "Вывести кол-во страниц";
            this.OutputSheetsNum.Name = "OutputSheetsNum";
            this.OutputSheetsNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OutputSheetsNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OutputCountryManufacturer
            // 
            this.OutputCountryManufacturer.HeaderText = "Вывести страну-производителя";
            this.OutputCountryManufacturer.Name = "OutputCountryManufacturer";
            this.OutputCountryManufacturer.Width = 200;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 726);
            this.Controls.Add(this.CreateDrawingNotebook_btn);
            this.Controls.Add(this.inputSheetsNum_txt);
            this.Controls.Add(this.inputThickness_txt);
            this.Controls.Add(this.inputQuality_txt);
            this.Controls.Add(this.InputSheetsNum_lbl);
            this.Controls.Add(this.InputThickness_lbl);
            this.Controls.Add(this.inputQuality_lbl);
            this.Controls.Add(this.Heading_lbl);
            this.Controls.Add(this.dataGrid_dgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Task3";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_dgv;
        private System.Windows.Forms.Label Heading_lbl;
        private System.Windows.Forms.Label inputQuality_lbl;
        private System.Windows.Forms.Label InputThickness_lbl;
        private System.Windows.Forms.Label InputSheetsNum_lbl;
        private System.Windows.Forms.TextBox inputQuality_txt;
        private System.Windows.Forms.TextBox inputThickness_txt;
        private System.Windows.Forms.TextBox inputSheetsNum_txt;
        private System.Windows.Forms.Button CreateDrawingNotebook_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetsNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryManufacturer;
        private System.Windows.Forms.DataGridViewButtonColumn OutputQuality;
        private System.Windows.Forms.DataGridViewButtonColumn OutputType;
        private System.Windows.Forms.DataGridViewButtonColumn OutputThickness;
        private System.Windows.Forms.DataGridViewButtonColumn OutputSheetsNum;
        private System.Windows.Forms.DataGridViewButtonColumn OutputCountryManufacturer;
    }
}

