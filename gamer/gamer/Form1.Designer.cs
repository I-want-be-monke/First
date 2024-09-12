namespace gamer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.PictureBox();
            this.background1 = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RedCar = new System.Windows.Forms.PictureBox();
            this.RedCar1 = new System.Windows.Forms.PictureBox();
            this.LableLose = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.LableCountCoin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(840, 650);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // background1
            // 
            this.background1.Image = ((System.Drawing.Image)(resources.GetObject("background1.Image")));
            this.background1.Location = new System.Drawing.Point(0, -650);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(840, 650);
            this.background1.TabIndex = 1;
            this.background1.TabStop = false;
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Transparent;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(423, 507);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(123, 122);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 2;
            this.Car.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RedCar
            // 
            this.RedCar.BackColor = System.Drawing.Color.Transparent;
            this.RedCar.Image = ((System.Drawing.Image)(resources.GetObject("RedCar.Image")));
            this.RedCar.Location = new System.Drawing.Point(306, -130);
            this.RedCar.Name = "RedCar";
            this.RedCar.Size = new System.Drawing.Size(98, 122);
            this.RedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedCar.TabIndex = 3;
            this.RedCar.TabStop = false;
            // 
            // RedCar1
            // 
            this.RedCar1.BackColor = System.Drawing.Color.Transparent;
            this.RedCar1.Image = ((System.Drawing.Image)(resources.GetObject("RedCar1.Image")));
            this.RedCar1.Location = new System.Drawing.Point(565, -400);
            this.RedCar1.Name = "RedCar1";
            this.RedCar1.Size = new System.Drawing.Size(98, 122);
            this.RedCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedCar1.TabIndex = 4;
            this.RedCar1.TabStop = false;
            // 
            // LableLose
            // 
            this.LableLose.AutoSize = true;
            this.LableLose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LableLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LableLose.Location = new System.Drawing.Point(239, 230);
            this.LableLose.Name = "LableLose";
            this.LableLose.Size = new System.Drawing.Size(349, 55);
            this.LableLose.TabIndex = 5;
            this.LableLose.Text = "Всё проебали";
            this.LableLose.Click += new System.EventHandler(this.label1_Click);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Restart.Location = new System.Drawing.Point(331, 288);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(176, 85);
            this.Restart.TabIndex = 6;
            this.Restart.Text = "Еще пофидить";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Coin
            // 
            this.Coin.BackColor = System.Drawing.Color.Transparent;
            this.Coin.Image = ((System.Drawing.Image)(resources.GetObject("Coin.Image")));
            this.Coin.Location = new System.Drawing.Point(469, -600);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(38, 38);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin.TabIndex = 7;
            this.Coin.TabStop = false;
            // 
            // LableCountCoin
            // 
            this.LableCountCoin.AutoSize = true;
            this.LableCountCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LableCountCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableCountCoin.Location = new System.Drawing.Point(-4, 0);
            this.LableCountCoin.Name = "LableCountCoin";
            this.LableCountCoin.Size = new System.Drawing.Size(81, 20);
            this.LableCountCoin.TabIndex = 8;
            this.LableCountCoin.Text = "Счет = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.LableCountCoin);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.LableLose);
            this.Controls.Add(this.RedCar1);
            this.Controls.Add(this.RedCar);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.background);
            this.Controls.Add(this.background1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox background1;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox RedCar;
        private System.Windows.Forms.PictureBox RedCar1;
        private System.Windows.Forms.Label LableLose;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.Label LableCountCoin;
    }
}

