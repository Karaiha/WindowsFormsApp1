
namespace WindowsFormsApp1
{
    partial class FormCalculations
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
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.checkBoxReg = new System.Windows.Forms.CheckBox();
            this.buttonCleanCB = new System.Windows.Forms.Button();
            this.buttonAddCB = new System.Windows.Forms.Button();
            this.buttonOutCB = new System.Windows.Forms.Button();
            this.buttonDate = new System.Windows.Forms.Button();
            this.pictureBoxSex = new System.Windows.Forms.PictureBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.textBoxCB = new System.Windows.Forms.TextBox();
            this.comboBoxTown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSex)).BeginInit();
            this.groupBoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(12, 56);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(155, 20);
            this.dateTimePickerBirth.TabIndex = 4;
            this.dateTimePickerBirth.ValueChanged += new System.EventHandler(this.dateTimePickerBirth_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(173, 62);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "label1";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(270, 252);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 23);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(270, 223);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(110, 23);
            this.buttonYes.TabIndex = 22;
            this.buttonYes.Text = "Подтвердить";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // checkBoxReg
            // 
            this.checkBoxReg.AutoSize = true;
            this.checkBoxReg.Location = new System.Drawing.Point(214, 200);
            this.checkBoxReg.Name = "checkBoxReg";
            this.checkBoxReg.Size = new System.Drawing.Size(218, 17);
            this.checkBoxReg.TabIndex = 21;
            this.checkBoxReg.Text = "Я согласен с условиями регистрации";
            this.checkBoxReg.UseVisualStyleBackColor = true;
            // 
            // buttonCleanCB
            // 
            this.buttonCleanCB.Location = new System.Drawing.Point(377, 129);
            this.buttonCleanCB.Name = "buttonCleanCB";
            this.buttonCleanCB.Size = new System.Drawing.Size(141, 23);
            this.buttonCleanCB.TabIndex = 18;
            this.buttonCleanCB.Text = "Очитстить список";
            this.buttonCleanCB.UseVisualStyleBackColor = true;
            this.buttonCleanCB.Click += new System.EventHandler(this.buttonCleanCB_Click);
            // 
            // buttonAddCB
            // 
            this.buttonAddCB.Location = new System.Drawing.Point(377, 100);
            this.buttonAddCB.Name = "buttonAddCB";
            this.buttonAddCB.Size = new System.Drawing.Size(141, 23);
            this.buttonAddCB.TabIndex = 17;
            this.buttonAddCB.Text = "Добавить в ComboBox";
            this.buttonAddCB.UseVisualStyleBackColor = true;
            this.buttonAddCB.Click += new System.EventHandler(this.buttonAddCB_Click);
            // 
            // buttonOutCB
            // 
            this.buttonOutCB.Location = new System.Drawing.Point(200, 100);
            this.buttonOutCB.Name = "buttonOutCB";
            this.buttonOutCB.Size = new System.Drawing.Size(142, 23);
            this.buttonOutCB.TabIndex = 16;
            this.buttonOutCB.Text = "Вывести из ComboBox";
            this.buttonOutCB.UseVisualStyleBackColor = true;
            this.buttonOutCB.Click += new System.EventHandler(this.buttonOutCB_Click);
            // 
            // buttonDate
            // 
            this.buttonDate.Location = new System.Drawing.Point(12, 100);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(155, 23);
            this.buttonDate.TabIndex = 14;
            this.buttonDate.Text = "Вывести дату";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // pictureBoxSex
            // 
            this.pictureBoxSex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSex.Image = global::WindowsFormsApp1.Properties.Resources.FemaleCrab;
            this.pictureBoxSex.Location = new System.Drawing.Point(84, 19);
            this.pictureBoxSex.Name = "pictureBoxSex";
            this.pictureBoxSex.Size = new System.Drawing.Size(89, 98);
            this.pictureBoxSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSex.TabIndex = 2;
            this.pictureBoxSex.TabStop = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Checked = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(6, 71);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(72, 17);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.Click += new System.EventHandler(this.radioButtonFemale_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 39);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.Click += new System.EventHandler(this.radioButtonMale_Click);
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.pictureBoxSex);
            this.groupBoxSex.Controls.Add(this.radioButtonFemale);
            this.groupBoxSex.Controls.Add(this.radioButtonMale);
            this.groupBoxSex.Location = new System.Drawing.Point(3, 129);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(182, 146);
            this.groupBoxSex.TabIndex = 20;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Пол";
            // 
            // textBoxCB
            // 
            this.textBoxCB.Location = new System.Drawing.Point(418, 55);
            this.textBoxCB.Name = "textBoxCB";
            this.textBoxCB.Size = new System.Drawing.Size(100, 20);
            this.textBoxCB.TabIndex = 19;
            // 
            // comboBoxTown
            // 
            this.comboBoxTown.FormattingEnabled = true;
            this.comboBoxTown.Location = new System.Drawing.Point(291, 55);
            this.comboBoxTown.Name = "comboBoxTown";
            this.comboBoxTown.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTown.TabIndex = 15;
            // 
            // FormCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 338);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.checkBoxReg);
            this.Controls.Add(this.buttonCleanCB);
            this.Controls.Add(this.buttonAddCB);
            this.Controls.Add(this.buttonOutCB);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.textBoxCB);
            this.Controls.Add(this.comboBoxTown);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Name = "FormCalculations";
            this.Text = "FormCalculations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculations_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculations_Load);
            this.Controls.SetChildIndex(this.dateTimePickerBirth, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.comboBoxTown, 0);
            this.Controls.SetChildIndex(this.textBoxCB, 0);
            this.Controls.SetChildIndex(this.groupBoxSex, 0);
            this.Controls.SetChildIndex(this.buttonDate, 0);
            this.Controls.SetChildIndex(this.buttonOutCB, 0);
            this.Controls.SetChildIndex(this.buttonAddCB, 0);
            this.Controls.SetChildIndex(this.buttonCleanCB, 0);
            this.Controls.SetChildIndex(this.checkBoxReg, 0);
            this.Controls.SetChildIndex(this.buttonYes, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSex)).EndInit();
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.CheckBox checkBoxReg;
        private System.Windows.Forms.Button buttonCleanCB;
        private System.Windows.Forms.Button buttonAddCB;
        private System.Windows.Forms.Button buttonOutCB;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.PictureBox pictureBoxSex;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.TextBox textBoxCB;
        private System.Windows.Forms.ComboBox comboBoxTown;
    }
}