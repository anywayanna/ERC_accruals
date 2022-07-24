namespace ERC_accruals
{
    partial class SumForm
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
            this.CVSResult = new System.Windows.Forms.TextBox();
            this.CVSLable = new System.Windows.Forms.Label();
            this.HVSLable = new System.Windows.Forms.Label();
            this.EEDayLable = new System.Windows.Forms.Label();
            this.EENightLable = new System.Windows.Forms.Label();
            this.HVSResult = new System.Windows.Forms.TextBox();
            this.EEDayResult = new System.Windows.Forms.TextBox();
            this.EENightResult = new System.Windows.Forms.TextBox();
            this.CommonResult = new System.Windows.Forms.TextBox();
            this.CommonResultLable = new System.Windows.Forms.Label();
            this.EELable = new System.Windows.Forms.Label();
            this.EEResult = new System.Windows.Forms.TextBox();
            this.TurnAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CVSResult
            // 
            this.CVSResult.Enabled = false;
            this.CVSResult.Location = new System.Drawing.Point(271, 34);
            this.CVSResult.Name = "CVSResult";
            this.CVSResult.Size = new System.Drawing.Size(100, 22);
            this.CVSResult.TabIndex = 0;
            // 
            // CVSLable
            // 
            this.CVSLable.AutoSize = true;
            this.CVSLable.Location = new System.Drawing.Point(27, 37);
            this.CVSLable.Name = "CVSLable";
            this.CVSLable.Size = new System.Drawing.Size(128, 16);
            this.CVSLable.TabIndex = 1;
            this.CVSLable.Text = "Начислено за ХВС";
            // 
            // HVSLable
            // 
            this.HVSLable.AutoSize = true;
            this.HVSLable.Location = new System.Drawing.Point(28, 73);
            this.HVSLable.Name = "HVSLable";
            this.HVSLable.Size = new System.Drawing.Size(127, 16);
            this.HVSLable.TabIndex = 2;
            this.HVSLable.Text = "Начислено за ГВС";
            // 
            // EEDayLable
            // 
            this.EEDayLable.AutoSize = true;
            this.EEDayLable.Location = new System.Drawing.Point(28, 105);
            this.EEDayLable.Name = "EEDayLable";
            this.EEDayLable.Size = new System.Drawing.Size(156, 16);
            this.EEDayLable.TabIndex = 3;
            this.EEDayLable.Text = "Начислено за ЭЭ день";
            // 
            // EENightLable
            // 
            this.EENightLable.AutoSize = true;
            this.EENightLable.Location = new System.Drawing.Point(28, 138);
            this.EENightLable.Name = "EENightLable";
            this.EENightLable.Size = new System.Drawing.Size(156, 16);
            this.EENightLable.TabIndex = 4;
            this.EENightLable.Text = "Начислено за ЭЭ ночь";
            // 
            // HVSResult
            // 
            this.HVSResult.Enabled = false;
            this.HVSResult.Location = new System.Drawing.Point(271, 67);
            this.HVSResult.Name = "HVSResult";
            this.HVSResult.Size = new System.Drawing.Size(100, 22);
            this.HVSResult.TabIndex = 5;
            // 
            // EEDayResult
            // 
            this.EEDayResult.Enabled = false;
            this.EEDayResult.Location = new System.Drawing.Point(271, 105);
            this.EEDayResult.Name = "EEDayResult";
            this.EEDayResult.Size = new System.Drawing.Size(100, 22);
            this.EEDayResult.TabIndex = 6;
            // 
            // EENightResult
            // 
            this.EENightResult.Enabled = false;
            this.EENightResult.Location = new System.Drawing.Point(271, 135);
            this.EENightResult.Name = "EENightResult";
            this.EENightResult.Size = new System.Drawing.Size(100, 22);
            this.EENightResult.TabIndex = 7;
            // 
            // CommonResult
            // 
            this.CommonResult.Enabled = false;
            this.CommonResult.Location = new System.Drawing.Point(271, 202);
            this.CommonResult.Name = "CommonResult";
            this.CommonResult.Size = new System.Drawing.Size(100, 22);
            this.CommonResult.TabIndex = 8;
            // 
            // CommonResultLable
            // 
            this.CommonResultLable.AutoSize = true;
            this.CommonResultLable.Location = new System.Drawing.Point(164, 202);
            this.CommonResultLable.Name = "CommonResultLable";
            this.CommonResultLable.Size = new System.Drawing.Size(82, 16);
            this.CommonResultLable.TabIndex = 9;
            this.CommonResultLable.Text = "Общий итог";
            // 
            // EELable
            // 
            this.EELable.AutoSize = true;
            this.EELable.Location = new System.Drawing.Point(28, 163);
            this.EELable.Name = "EELable";
            this.EELable.Size = new System.Drawing.Size(122, 16);
            this.EELable.TabIndex = 11;
            this.EELable.Text = "Начислено за ЭЭ";
            this.EELable.Visible = false;
            // 
            // EEResult
            // 
            this.EEResult.Enabled = false;
            this.EEResult.Location = new System.Drawing.Point(271, 163);
            this.EEResult.Name = "EEResult";
            this.EEResult.Size = new System.Drawing.Size(100, 22);
            this.EEResult.TabIndex = 10;
            this.EEResult.Visible = false;
            // 
            // TurnAgainButton
            // 
            this.TurnAgainButton.Location = new System.Drawing.Point(31, 234);
            this.TurnAgainButton.Name = "TurnAgainButton";
            this.TurnAgainButton.Size = new System.Drawing.Size(172, 42);
            this.TurnAgainButton.TabIndex = 12;
            this.TurnAgainButton.Text = "Передать следующие показания";
            this.TurnAgainButton.UseVisualStyleBackColor = true;
            this.TurnAgainButton.Click += new System.EventHandler(this.TurnAgainButton_Click);
            // 
            // SumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 297);
            this.Controls.Add(this.TurnAgainButton);
            this.Controls.Add(this.EELable);
            this.Controls.Add(this.EEResult);
            this.Controls.Add(this.CommonResultLable);
            this.Controls.Add(this.CommonResult);
            this.Controls.Add(this.EENightResult);
            this.Controls.Add(this.EEDayResult);
            this.Controls.Add(this.HVSResult);
            this.Controls.Add(this.EENightLable);
            this.Controls.Add(this.EEDayLable);
            this.Controls.Add(this.HVSLable);
            this.Controls.Add(this.CVSLable);
            this.Controls.Add(this.CVSResult);
            this.Name = "SumForm";
            this.Text = "SumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CVSResult;
        private System.Windows.Forms.Label CVSLable;
        private System.Windows.Forms.Label HVSLable;
        private System.Windows.Forms.Label EEDayLable;
        private System.Windows.Forms.Label EENightLable;
        private System.Windows.Forms.TextBox HVSResult;
        private System.Windows.Forms.TextBox EEDayResult;
        private System.Windows.Forms.TextBox EENightResult;
        private System.Windows.Forms.TextBox CommonResult;
        private System.Windows.Forms.Label CommonResultLable;
        private System.Windows.Forms.Label EELable;
        private System.Windows.Forms.TextBox EEResult;
        private System.Windows.Forms.Button TurnAgainButton;
    }
}