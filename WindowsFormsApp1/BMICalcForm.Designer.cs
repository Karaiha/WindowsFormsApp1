
namespace WindowsFormsApp1
{
    partial class BMICalcForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelSm = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelKg = new System.Windows.Forms.Label();
            this.labelBMIresultText = new System.Windows.Forms.Label();
            this.labelBMIresultNum = new System.Windows.Forms.Label();
            this.trackBarIndex = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 56);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "BMI Калькулятор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(715, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "BMI обозначает индекс массы тела. Он используется, чтобы дать вам представление о" +
    " том, является ли Ваш вес избыточным или идеальным для вашего роста.";
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.labelMale.Location = new System.Drawing.Point(61, 274);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(53, 14);
            this.labelMale.TabIndex = 5;
            this.labelMale.Text = "Мужской";
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.labelFemale.Location = new System.Drawing.Point(170, 274);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(49, 14);
            this.labelFemale.TabIndex = 6;
            this.labelFemale.Text = "Женский";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.labelHeight.Location = new System.Drawing.Point(59, 309);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(34, 14);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Рост";
            // 
            // labelSm
            // 
            this.labelSm.AutoSize = true;
            this.labelSm.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelSm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.labelSm.Location = new System.Drawing.Point(183, 309);
            this.labelSm.Name = "labelSm";
            this.labelSm.Size = new System.Drawing.Size(23, 14);
            this.labelSm.TabIndex = 8;
            this.labelSm.Text = "см.";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.labelWeight.Location = new System.Drawing.Point(69, 343);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(24, 14);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Вес";
            // 
            // labelKg
            // 
            this.labelKg.AutoSize = true;
            this.labelKg.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelKg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.labelKg.Location = new System.Drawing.Point(183, 343);
            this.labelKg.Name = "labelKg";
            this.labelKg.Size = new System.Drawing.Size(20, 14);
            this.labelKg.TabIndex = 10;
            this.labelKg.Text = "кг.";
            // 
            // labelBMIresultText
            // 
            this.labelBMIresultText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelBMIresultText.ForeColor = System.Drawing.Color.Black;
            this.labelBMIresultText.Location = new System.Drawing.Point(271, 279);
            this.labelBMIresultText.Name = "labelBMIresultText";
            this.labelBMIresultText.Size = new System.Drawing.Size(456, 24);
            this.labelBMIresultText.TabIndex = 11;
            this.labelBMIresultText.Text = "Недостаточный";
            this.labelBMIresultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBMIresultNum
            // 
            this.labelBMIresultNum.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelBMIresultNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.labelBMIresultNum.Location = new System.Drawing.Point(268, 309);
            this.labelBMIresultNum.Name = "labelBMIresultNum";
            this.labelBMIresultNum.Size = new System.Drawing.Size(459, 17);
            this.labelBMIresultNum.TabIndex = 12;
            this.labelBMIresultNum.Text = "0";
            this.labelBMIresultNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarIndex
            // 
            this.trackBarIndex.Location = new System.Drawing.Point(268, 329);
            this.trackBarIndex.Maximum = 50;
            this.trackBarIndex.Name = "trackBarIndex";
            this.trackBarIndex.Size = new System.Drawing.Size(459, 45);
            this.trackBarIndex.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(40, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.woman;
            this.pictureBox2.Location = new System.Drawing.Point(152, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Image = global::WindowsFormsApp1.Properties.Resources.small;
            this.pictureBoxResult.Location = new System.Drawing.Point(383, 134);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(233, 137);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 16;
            this.pictureBoxResult.TabStop = false;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(99, 306);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(78, 20);
            this.textBoxHeight.TabIndex = 17;
            this.textBoxHeight.Text = "0";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(99, 340);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(78, 20);
            this.textBoxWeight.TabIndex = 18;
            this.textBoxWeight.Text = "0";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(40, 366);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(90, 23);
            this.buttonResult.TabIndex = 19;
            this.buttonResult.Text = "Расчитать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(152, 366);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // BMICalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBarIndex);
            this.Controls.Add(this.labelBMIresultNum);
            this.Controls.Add(this.labelBMIresultText);
            this.Controls.Add(this.labelKg);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelSm);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelFemale);
            this.Controls.Add(this.labelMale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "BMICalcForm";
            this.Text = "BMICalc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalcForm_FormClosing);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.labelMale, 0);
            this.Controls.SetChildIndex(this.labelFemale, 0);
            this.Controls.SetChildIndex(this.labelHeight, 0);
            this.Controls.SetChildIndex(this.labelSm, 0);
            this.Controls.SetChildIndex(this.labelWeight, 0);
            this.Controls.SetChildIndex(this.labelKg, 0);
            this.Controls.SetChildIndex(this.labelBMIresultText, 0);
            this.Controls.SetChildIndex(this.labelBMIresultNum, 0);
            this.Controls.SetChildIndex(this.trackBarIndex, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBoxResult, 0);
            this.Controls.SetChildIndex(this.textBoxHeight, 0);
            this.Controls.SetChildIndex(this.textBoxWeight, 0);
            this.Controls.SetChildIndex(this.buttonResult, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelSm;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelKg;
        private System.Windows.Forms.Label labelBMIresultText;
        private System.Windows.Forms.Label labelBMIresultNum;
        private System.Windows.Forms.TrackBar trackBarIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonCancel;
    }
}