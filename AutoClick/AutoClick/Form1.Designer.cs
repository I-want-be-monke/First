namespace AutoClick
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CollapseApp = new System.Windows.Forms.PictureBox();
            this.CloseApp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSEC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CollapseApp);
            this.panel1.Controls.Add(this.CloseApp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "AutoCliker(For Casino)";
            // 
            // CollapseApp
            // 
            this.CollapseApp.Image = global::AutoClick.Properties.Resources.кнопка_сворачивания;
            this.CollapseApp.Location = new System.Drawing.Point(385, 0);
            this.CollapseApp.Name = "CollapseApp";
            this.CollapseApp.Size = new System.Drawing.Size(27, 27);
            this.CollapseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CollapseApp.TabIndex = 1;
            this.CollapseApp.TabStop = false;
            this.CollapseApp.Click += new System.EventHandler(this.CollapseApp_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.Image = global::AutoClick.Properties.Resources.кнопка_закрытия;
            this.CloseApp.Location = new System.Drawing.Point(418, 0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(32, 30);
            this.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseApp.TabIndex = 0;
            this.CloseApp.TabStop = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click interval";
            // 
            // textBoxMIN
            // 
            this.textBoxMIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMIN.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMIN.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxMIN.Location = new System.Drawing.Point(8, 73);
            this.textBoxMIN.Name = "textBoxMIN";
            this.textBoxMIN.Size = new System.Drawing.Size(98, 42);
            this.textBoxMIN.TabIndex = 4;
            this.textBoxMIN.Text = "0";
            this.textBoxMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMIN_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(112, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "MIN";
            // 
            // textBoxSEC
            // 
            this.textBoxSEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSEC.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSEC.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxSEC.Location = new System.Drawing.Point(197, 75);
            this.textBoxSEC.Name = "textBoxSEC";
            this.textBoxSEC.Size = new System.Drawing.Size(98, 42);
            this.textBoxSEC.TabIndex = 6;
            this.textBoxSEC.Text = "0";
            this.textBoxSEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSEC_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(301, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "SEC";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Red;
            this.Start.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(8, 241);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(201, 47);
            this.Start.TabIndex = 8;
            this.Start.Text = "Start(F2)";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.Location = new System.Drawing.Point(239, 241);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(199, 47);
            this.Stop.TabIndex = 9;
            this.Stop.Text = "Stop(F12)";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.Color.Red;
            this.Location.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location.Location = new System.Drawing.Point(237, 188);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(201, 47);
            this.Location.TabIndex = 10;
            this.Location.Text = "Location(F3)";
            this.Location.UseVisualStyleBackColor = false;
            this.Location.Click += new System.EventHandler(this.Location_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxX.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.ForeColor = System.Drawing.Color.White;
            this.textBoxX.Location = new System.Drawing.Point(29, 193);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(62, 42);
            this.textBoxX.TabIndex = 11;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxY.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.ForeColor = System.Drawing.Color.White;
            this.textBoxY.Location = new System.Drawing.Point(130, 193);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(62, 42);
            this.textBoxY.TabIndex = 12;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(48, 160);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(28, 30);
            this.X.TabIndex = 13;
            this.X.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(150, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.X);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSEC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseApp;
        private System.Windows.Forms.PictureBox CollapseApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSEC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Location;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label6;
    }
}

