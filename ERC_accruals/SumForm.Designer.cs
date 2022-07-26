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
            this.HVSResult = new System.Windows.Forms.TextBox();
            this.CommonResult = new System.Windows.Forms.TextBox();
            this.CommonResultLable = new System.Windows.Forms.Label();
            this.EELable = new System.Windows.Forms.Label();
            this.EEResult = new System.Windows.Forms.TextBox();
            this.TurnAgainButton = new System.Windows.Forms.Button();
            this.ChangeAccurals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HVSResultEnergy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _CVSResult
            // 
            this.CVSResult.Enabled = false;
            this.CVSResult.Location = new System.Drawing.Point(271, 34);
            this.CVSResult.Name = "_CVSResult";
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
            this.HVSLable.Size = new System.Drawing.Size(186, 16);
            this.HVSLable.TabIndex = 2;
            this.HVSLable.Text = "Начислено за ГВС (подача)";
            // 
            // HVSResult
            // 
            this.HVSResult.Enabled = false;
            this.HVSResult.Location = new System.Drawing.Point(271, 67);
            this.HVSResult.Name = "HVSResult";
            this.HVSResult.Size = new System.Drawing.Size(100, 22);
            this.HVSResult.TabIndex = 5;
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
            this.EELable.Location = new System.Drawing.Point(28, 143);
            this.EELable.Name = "EELable";
            this.EELable.Size = new System.Drawing.Size(122, 16);
            this.EELable.TabIndex = 11;
            this.EELable.Text = "Начислено за ЭЭ";
            this.EELable.Visible = false;
            // 
            // EEResult
            // 
            this.EEResult.Enabled = false;
            this.EEResult.Location = new System.Drawing.Point(271, 137);
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
            // ChangeAccurals
            // 
            this.ChangeAccurals.Location = new System.Drawing.Point(220, 234);
            this.ChangeAccurals.Name = "ChangeAccurals";
            this.ChangeAccurals.Size = new System.Drawing.Size(172, 42);
            this.ChangeAccurals.TabIndex = 13;
            this.ChangeAccurals.Text = "Изменить текущие показатели";
            this.ChangeAccurals.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Начислено за ГВС (нагрев)";
            // 
            // HVSResultEnergy
            // 
            this.HVSResultEnergy.Enabled = false;
            this.HVSResultEnergy.Location = new System.Drawing.Point(271, 102);
            this.HVSResultEnergy.Name = "HVSResultEnergy";
            this.HVSResultEnergy.Size = new System.Drawing.Size(100, 22);
            this.HVSResultEnergy.TabIndex = 15;
            // 
            // SumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 297);
            this.Controls.Add(this.HVSResultEnergy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeAccurals);
            this.Controls.Add(this.TurnAgainButton);
            this.Controls.Add(this.EELable);
            this.Controls.Add(this.EEResult);
            this.Controls.Add(this.CommonResultLable);
            this.Controls.Add(this.CommonResult);
            this.Controls.Add(this.HVSResult);
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
        private System.Windows.Forms.TextBox HVSResult;
        private System.Windows.Forms.TextBox CommonResult;
        private System.Windows.Forms.Label CommonResultLable;
        private System.Windows.Forms.Label EELable;
        private System.Windows.Forms.TextBox EEResult;
        private System.Windows.Forms.Button TurnAgainButton;
        private System.Windows.Forms.Button ChangeAccurals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HVSResultEnergy;
    }
}