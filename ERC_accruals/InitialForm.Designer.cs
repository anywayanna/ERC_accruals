namespace ERC_accruals
{
    partial class InitialForm
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
            this.checkBoxCVS = new System.Windows.Forms.CheckBox();
            this.checkBoxHVS = new System.Windows.Forms.CheckBox();
            this.checkBoxEE = new System.Windows.Forms.CheckBox();
            this.peopleCount = new System.Windows.Forms.NumericUpDown();
            this.labelCountPeople = new System.Windows.Forms.Label();
            this.ConfirmFirstForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peopleCount)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxCVS
            // 
            this.checkBoxCVS.AutoSize = true;
            this.checkBoxCVS.Location = new System.Drawing.Point(63, 105);
            this.checkBoxCVS.Name = "checkBoxCVS";
            this.checkBoxCVS.Size = new System.Drawing.Size(293, 20);
            this.checkBoxCVS.TabIndex = 0;
            this.checkBoxCVS.Text = "Имеется ли прибор учета по услуге ХВС";
            this.checkBoxCVS.UseVisualStyleBackColor = true;
            // 
            // checkBoxHVS
            // 
            this.checkBoxHVS.AutoSize = true;
            this.checkBoxHVS.Location = new System.Drawing.Point(63, 142);
            this.checkBoxHVS.Name = "checkBoxHVS";
            this.checkBoxHVS.Size = new System.Drawing.Size(292, 20);
            this.checkBoxHVS.TabIndex = 1;
            this.checkBoxHVS.Text = "Имеется ли прибор учета по услуге ГВС";
            this.checkBoxHVS.UseVisualStyleBackColor = true;
            // 
            // checkBoxEE
            // 
            this.checkBoxEE.AutoSize = true;
            this.checkBoxEE.Location = new System.Drawing.Point(63, 177);
            this.checkBoxEE.Name = "checkBoxEE";
            this.checkBoxEE.Size = new System.Drawing.Size(287, 20);
            this.checkBoxEE.TabIndex = 2;
            this.checkBoxEE.Text = "Имеется ли прибор учета по услуге ЭЭ";
            this.checkBoxEE.UseVisualStyleBackColor = true;
            // 
            // peopleCount
            // 
            this.peopleCount.Location = new System.Drawing.Point(63, 51);
            this.peopleCount.Name = "peopleCount";
            this.peopleCount.Size = new System.Drawing.Size(44, 22);
            this.peopleCount.TabIndex = 3;
            this.peopleCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCountPeople
            // 
            this.labelCountPeople.AutoSize = true;
            this.labelCountPeople.Location = new System.Drawing.Point(60, 32);
            this.labelCountPeople.Name = "labelCountPeople";
            this.labelCountPeople.Size = new System.Drawing.Size(266, 16);
            this.labelCountPeople.TabIndex = 4;
            this.labelCountPeople.Text = "Количество проживающих в помещении";
            // 
            // ConfirmFirstForm
            // 
            this.ConfirmFirstForm.Location = new System.Drawing.Point(249, 218);
            this.ConfirmFirstForm.Name = "ConfirmFirstForm";
            this.ConfirmFirstForm.Size = new System.Drawing.Size(107, 23);
            this.ConfirmFirstForm.TabIndex = 5;
            this.ConfirmFirstForm.Text = "Подтверджаю";
            this.ConfirmFirstForm.UseVisualStyleBackColor = true;
            this.ConfirmFirstForm.Click += new System.EventHandler(this.ConfirmFirstForm_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 253);
            this.Controls.Add(this.ConfirmFirstForm);
            this.Controls.Add(this.labelCountPeople);
            this.Controls.Add(this.peopleCount);
            this.Controls.Add(this.checkBoxEE);
            this.Controls.Add(this.checkBoxHVS);
            this.Controls.Add(this.checkBoxCVS);
            this.Name = "InitialForm";
            this.Text = "Наличие приборов учета";
            ((System.ComponentModel.ISupportInitialize)(this.peopleCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown peopleCount;
        private System.Windows.Forms.Label labelCountPeople;
        private System.Windows.Forms.Button ConfirmFirstForm;
        public System.Windows.Forms.CheckBox checkBoxHVS;
        public System.Windows.Forms.CheckBox checkBoxEE;
        public System.Windows.Forms.CheckBox checkBoxCVS;
    }
}

