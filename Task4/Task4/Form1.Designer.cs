namespace Task4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Backhround_pb = new System.Windows.Forms.PictureBox();
            this.Rocket_pb = new System.Windows.Forms.PictureBox();
            this.Cosmonaut_pb = new System.Windows.Forms.PictureBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Money_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Backhround_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rocket_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cosmonaut_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Money_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Backhround_pb
            // 
            this.Backhround_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backhround_pb.BackgroundImage")));
            this.Backhround_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backhround_pb.Location = new System.Drawing.Point(0, 0);
            this.Backhround_pb.Name = "Backhround_pb";
            this.Backhround_pb.Size = new System.Drawing.Size(1251, 843);
            this.Backhround_pb.TabIndex = 0;
            this.Backhround_pb.TabStop = false;
            // 
            // Rocket_pb
            // 
            this.Rocket_pb.BackColor = System.Drawing.SystemColors.Menu;
            this.Rocket_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rocket_pb.BackgroundImage")));
            this.Rocket_pb.Location = new System.Drawing.Point(412, 285);
            this.Rocket_pb.Name = "Rocket_pb";
            this.Rocket_pb.Size = new System.Drawing.Size(540, 486);
            this.Rocket_pb.TabIndex = 1;
            this.Rocket_pb.TabStop = false;
            // 
            // Cosmonaut_pb
            // 
            this.Cosmonaut_pb.BackColor = System.Drawing.SystemColors.InfoText;
            this.Cosmonaut_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cosmonaut_pb.BackgroundImage")));
            this.Cosmonaut_pb.Location = new System.Drawing.Point(412, 71);
            this.Cosmonaut_pb.Name = "Cosmonaut_pb";
            this.Cosmonaut_pb.Size = new System.Drawing.Size(414, 232);
            this.Cosmonaut_pb.TabIndex = 2;
            this.Cosmonaut_pb.TabStop = false;
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(922, 28);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(91, 39);
            this.Start_btn.TabIndex = 3;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Money_pb
            // 
            this.Money_pb.BackColor = System.Drawing.SystemColors.GrayText;
            this.Money_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Money_pb.BackgroundImage")));
            this.Money_pb.Location = new System.Drawing.Point(273, 73);
            this.Money_pb.Name = "Money_pb";
            this.Money_pb.Size = new System.Drawing.Size(816, 758);
            this.Money_pb.TabIndex = 4;
            this.Money_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 843);
            this.Controls.Add(this.Money_pb);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Cosmonaut_pb);
            this.Controls.Add(this.Rocket_pb);
            this.Controls.Add(this.Backhround_pb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Backhround_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rocket_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cosmonaut_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Money_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Backhround_pb;
        private System.Windows.Forms.PictureBox Rocket_pb;
        private System.Windows.Forms.PictureBox Cosmonaut_pb;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.PictureBox Money_pb;
    }
}

