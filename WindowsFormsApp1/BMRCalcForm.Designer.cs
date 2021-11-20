
namespace WindowsFormsApp1
{
    partial class BMRCalcForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelYourBMR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInactive = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelLowActivity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAverageActivity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelHighActivity = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelMaximumActivity = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.pictureBoxMale = new System.Windows.Forms.PictureBox();
            this.pictureBoxFemale = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFemale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(291, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "BMR-калькулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(554, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваш BMR";
            // 
            // labelYourBMR
            // 
            this.labelYourBMR.AutoSize = true;
            this.labelYourBMR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.labelYourBMR.ForeColor = System.Drawing.Color.Black;
            this.labelYourBMR.Location = new System.Drawing.Point(571, 186);
            this.labelYourBMR.Name = "labelYourBMR";
            this.labelYourBMR.Size = new System.Drawing.Size(37, 19);
            this.labelYourBMR.TabIndex = 4;
            this.labelYourBMR.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(482, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ежедневно тратится калорий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(482, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Сидячий:";
            // 
            // labelInactive
            // 
            this.labelInactive.AutoSize = true;
            this.labelInactive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.labelInactive.ForeColor = System.Drawing.Color.Black;
            this.labelInactive.Location = new System.Drawing.Point(687, 247);
            this.labelInactive.Name = "labelInactive";
            this.labelInactive.Size = new System.Drawing.Size(45, 19);
            this.labelInactive.TabIndex = 7;
            this.labelInactive.Text = "0.000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(482, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Малая активность:";
            // 
            // labelLowActivity
            // 
            this.labelLowActivity.AutoSize = true;
            this.labelLowActivity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.labelLowActivity.ForeColor = System.Drawing.Color.Black;
            this.labelLowActivity.Location = new System.Drawing.Point(687, 266);
            this.labelLowActivity.Name = "labelLowActivity";
            this.labelLowActivity.Size = new System.Drawing.Size(45, 19);
            this.labelLowActivity.TabIndex = 9;
            this.labelLowActivity.Text = "0.000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(482, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Средняя активность:";
            // 
            // labelAverageActivity
            // 
            this.labelAverageActivity.AutoSize = true;
            this.labelAverageActivity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.labelAverageActivity.ForeColor = System.Drawing.Color.Black;
            this.labelAverageActivity.Location = new System.Drawing.Point(687, 285);
            this.labelAverageActivity.Name = "labelAverageActivity";
            this.labelAverageActivity.Size = new System.Drawing.Size(45, 19);
            this.labelAverageActivity.TabIndex = 11;
            this.labelAverageActivity.Text = "0.000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(482, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Высокая активность:";
            // 
            // labelHighActivity
            // 
            this.labelHighActivity.AutoSize = true;
            this.labelHighActivity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.labelHighActivity.ForeColor = System.Drawing.Color.Black;
            this.labelHighActivity.Location = new System.Drawing.Point(687, 304);
            this.labelHighActivity.Name = "labelHighActivity";
            this.labelHighActivity.Size = new System.Drawing.Size(45, 19);
            this.labelHighActivity.TabIndex = 13;
            this.labelHighActivity.Text = "0.000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(482, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Максимальная активность:";
            // 
            // labelMaximumActivity
            // 
            this.labelMaximumActivity.AutoSize = true;
            this.labelMaximumActivity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.labelMaximumActivity.ForeColor = System.Drawing.Color.Black;
            this.labelMaximumActivity.Location = new System.Drawing.Point(687, 323);
            this.labelMaximumActivity.Name = "labelMaximumActivity";
            this.labelMaximumActivity.Size = new System.Drawing.Size(45, 19);
            this.labelMaximumActivity.TabIndex = 15;
            this.labelMaximumActivity.Text = "0.000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.label15.Location = new System.Drawing.Point(89, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 19);
            this.label15.TabIndex = 16;
            this.label15.Text = "Рост:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.label16.Location = new System.Drawing.Point(251, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 19);
            this.label16.TabIndex = 17;
            this.label16.Text = "см.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.label17.Location = new System.Drawing.Point(102, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 19);
            this.label17.TabIndex = 18;
            this.label17.Text = "Вес:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.label18.Location = new System.Drawing.Point(251, 297);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 19);
            this.label18.TabIndex = 19;
            this.label18.Text = "кг.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.label19.Location = new System.Drawing.Point(67, 323);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 19);
            this.label19.TabIndex = 20;
            this.label19.Text = "Возраст:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.label20.Location = new System.Drawing.Point(251, 323);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 19);
            this.label20.TabIndex = 21;
            this.label20.Text = "лет.";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(145, 272);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 22;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(145, 298);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 23;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(145, 324);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 24;
            // 
            // pictureBoxMale
            // 
            this.pictureBoxMale.Image = global::WindowsFormsApp1.Properties.Resources.man;
            this.pictureBoxMale.Location = new System.Drawing.Point(42, 121);
            this.pictureBoxMale.Name = "pictureBoxMale";
            this.pictureBoxMale.Size = new System.Drawing.Size(150, 145);
            this.pictureBoxMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMale.TabIndex = 25;
            this.pictureBoxMale.TabStop = false;
            this.pictureBoxMale.Click += new System.EventHandler(this.pictureBoxMale_Click);
            // 
            // pictureBoxFemale
            // 
            this.pictureBoxFemale.Image = global::WindowsFormsApp1.Properties.Resources.woman;
            this.pictureBoxFemale.Location = new System.Drawing.Point(198, 121);
            this.pictureBoxFemale.Name = "pictureBoxFemale";
            this.pictureBoxFemale.Size = new System.Drawing.Size(150, 145);
            this.pictureBoxFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFemale.TabIndex = 26;
            this.pictureBoxFemale.TabStop = false;
            this.pictureBoxFemale.Click += new System.EventHandler(this.pictureBoxFemale_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 56);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(12, 361);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(396, 23);
            this.buttonResult.TabIndex = 28;
            this.buttonResult.Text = "Расчитать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(414, 361);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(374, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // BMRCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxFemale);
            this.Controls.Add(this.pictureBoxMale);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelMaximumActivity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelHighActivity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelAverageActivity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelLowActivity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelInactive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelYourBMR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BMRCalcForm";
            this.Text = "BMR-калькулятор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMRCalcForm_FormClosing);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.labelYourBMR, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.labelInactive, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.labelLowActivity, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.labelAverageActivity, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.labelHighActivity, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.labelMaximumActivity, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.textBoxHeight, 0);
            this.Controls.SetChildIndex(this.textBoxWeight, 0);
            this.Controls.SetChildIndex(this.textBoxAge, 0);
            this.Controls.SetChildIndex(this.pictureBoxMale, 0);
            this.Controls.SetChildIndex(this.pictureBoxFemale, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.buttonResult, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFemale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelYourBMR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInactive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLowActivity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAverageActivity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelHighActivity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelMaximumActivity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.PictureBox pictureBoxMale;
        private System.Windows.Forms.PictureBox pictureBoxFemale;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonCancel;
    }
}