namespace Russian_roulate_askaran
{
    partial class MainForm
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
            this.Load_btn = new System.Windows.Forms.Button();
            this.Spin_btn = new System.Windows.Forms.Button();
            this.Shoot_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_btn
            // 
            this.Load_btn.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_btn.Location = new System.Drawing.Point(112, 326);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(98, 42);
            this.Load_btn.TabIndex = 0;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // Spin_btn
            // 
            this.Spin_btn.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin_btn.Location = new System.Drawing.Point(307, 326);
            this.Spin_btn.Name = "Spin_btn";
            this.Spin_btn.Size = new System.Drawing.Size(114, 42);
            this.Spin_btn.TabIndex = 1;
            this.Spin_btn.Text = "Spin";
            this.Spin_btn.UseVisualStyleBackColor = true;
            this.Spin_btn.Click += new System.EventHandler(this.button_spin);
            // 
            // Shoot_btn
            // 
            this.Shoot_btn.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot_btn.Location = new System.Drawing.Point(497, 326);
            this.Shoot_btn.Name = "Shoot_btn";
            this.Shoot_btn.Size = new System.Drawing.Size(96, 42);
            this.Shoot_btn.TabIndex = 2;
            this.Shoot_btn.Text = "Shoot";
            this.Shoot_btn.UseVisualStyleBackColor = true;
            this.Shoot_btn.Click += new System.EventHandler(this.button_shoot);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Russian Roulete";
            // 
            // pictureBox1
            // 
            this.pictureBox_main.Location = new System.Drawing.Point(242, 118);
            this.pictureBox_main.Name = "pictureBox1";
            this.pictureBox_main.Size = new System.Drawing.Size(245, 146);
            this.pictureBox_main.TabIndex = 4;
            this.pictureBox_main.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_playagain);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_roulate_askaran.Properties.Resources._725bf2a393eea8e90e6bb86acf023974906882f9;
            this.ClientSize = new System.Drawing.Size(749, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Shoot_btn);
            this.Controls.Add(this.Spin_btn);
            this.Controls.Add(this.Load_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Button Spin_btn;
        private System.Windows.Forms.Button Shoot_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Button button1;
    }
}