namespace ERC_accruals
{
    partial class AccrualsTakingForm
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
            this.CVS = new System.Windows.Forms.TextBox();
            this.labelCVS = new System.Windows.Forms.Label();
            this.labelHVS = new System.Windows.Forms.Label();
            this.labelEEDay = new System.Windows.Forms.Label();
            this.labelEENight = new System.Windows.Forms.Label();
            this.HVS = new System.Windows.Forms.TextBox();
            this.EEDay = new System.Windows.Forms.TextBox();
            this.EENight = new System.Windows.Forms.TextBox();
            this.ConfirmSecondForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CVS
            // 
            this.CVS.Enabled = false;
            this.CVS.Location = new System.Drawing.Point(12, 49);
            this.CVS.Name = "CVS";
            this.CVS.Size = new System.Drawing.Size(485, 22);
            this.CVS.TabIndex = 0;
            // 
            // labelCVS
            // 
            this.labelCVS.AutoSize = true;
            this.labelCVS.Location = new System.Drawing.Point(12, 30);
            this.labelCVS.Name = "labelCVS";
            this.labelCVS.Size = new System.Drawing.Size(165, 16);
            this.labelCVS.TabIndex = 1;
            this.labelCVS.Text = "Введите показания ХВС";
            // 
            // labelHVS
            // 
            this.labelHVS.AutoSize = true;
            this.labelHVS.Location = new System.Drawing.Point(9, 84);
            this.labelHVS.Name = "labelHVS";
            this.labelHVS.Size = new System.Drawing.Size(164, 16);
            this.labelHVS.TabIndex = 2;
            this.labelHVS.Text = "Введите показания ГВС";
            // 
            // labelEEDay
            // 
            this.labelEEDay.AutoSize = true;
            this.labelEEDay.Location = new System.Drawing.Point(12, 128);
            this.labelEEDay.Name = "labelEEDay";
            this.labelEEDay.Size = new System.Drawing.Size(239, 16);
            this.labelEEDay.TabIndex = 3;
            this.labelEEDay.Text = "Введите показания Эл.эн. Дневной";
            // 
            // labelEENight
            // 
            this.labelEENight.AutoSize = true;
            this.labelEENight.Location = new System.Drawing.Point(12, 186);
            this.labelEENight.Name = "labelEENight";
            this.labelEENight.Size = new System.Drawing.Size(232, 16);
            this.labelEENight.TabIndex = 4;
            this.labelEENight.Text = "Введите показания Эл.эн. Ночной";
            // 
            // HVS
            // 
            this.HVS.Enabled = false;
            this.HVS.Location = new System.Drawing.Point(12, 104);
            this.HVS.Name = "HVS";
            this.HVS.Size = new System.Drawing.Size(485, 22);
            this.HVS.TabIndex = 5;
            // 
            // EEDay
            // 
            this.EEDay.Enabled = false;
            this.EEDay.Location = new System.Drawing.Point(12, 161);
            this.EEDay.Name = "EEDay";
            this.EEDay.Size = new System.Drawing.Size(485, 22);
            this.EEDay.TabIndex = 6;
            // 
            // EENight
            // 
            this.EENight.Enabled = false;
            this.EENight.Location = new System.Drawing.Point(12, 217);
            this.EENight.Name = "EENight";
            this.EENight.Size = new System.Drawing.Size(485, 22);
            this.EENight.TabIndex = 7;
            // 
            // ConfirmSecondForm
            // 
            this.ConfirmSecondForm.Location = new System.Drawing.Point(12, 262);
            this.ConfirmSecondForm.Name = "ConfirmSecondForm";
            this.ConfirmSecondForm.Size = new System.Drawing.Size(108, 23);
            this.ConfirmSecondForm.TabIndex = 8;
            this.ConfirmSecondForm.Text = "Подтверджаю";
            this.ConfirmSecondForm.UseVisualStyleBackColor = true;
            this.ConfirmSecondForm.Click += new System.EventHandler(this.ConfirmSecondForm_Click);
            // 
            // AccrualsTakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 315);
            this.Controls.Add(this.ConfirmSecondForm);
            this.Controls.Add(this.EENight);
            this.Controls.Add(this.EEDay);
            this.Controls.Add(this.HVS);
            this.Controls.Add(this.labelEENight);
            this.Controls.Add(this.labelEEDay);
            this.Controls.Add(this.labelHVS);
            this.Controls.Add(this.labelCVS);
            this.Controls.Add(this.CVS);
            this.Name = "AccrualsTakingForm";
            this.Text = "Снятие показаний";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCVS;
        private System.Windows.Forms.Label labelHVS;
        private System.Windows.Forms.Label labelEEDay;
        private System.Windows.Forms.Label labelEENight;
        private System.Windows.Forms.Button ConfirmSecondForm;
        public System.Windows.Forms.TextBox CVS;
        public System.Windows.Forms.TextBox HVS;
        public System.Windows.Forms.TextBox EEDay;
        public System.Windows.Forms.TextBox EENight;
    }
}