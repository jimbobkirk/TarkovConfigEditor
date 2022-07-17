namespace TarkovConfigEditor
{
    partial class TradingForm
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
            this.btnSave = new TarkovConfigEditor.BaseButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarketPlaceMultiplier = new System.Windows.Forms.TextBox();
            this.txtRepairMultiplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsuranceMultiplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBuyFoundInRaid = new System.Windows.Forms.CheckBox();
            this.txtInsureReturnChance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(14, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(400, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marketplace Price Multiplier (0.2 for example means everything is 20% usual cost)" +
    "";
            // 
            // txtMarketPlaceMultiplier
            // 
            this.txtMarketPlaceMultiplier.Location = new System.Drawing.Point(13, 27);
            this.txtMarketPlaceMultiplier.Name = "txtMarketPlaceMultiplier";
            this.txtMarketPlaceMultiplier.Size = new System.Drawing.Size(166, 20);
            this.txtMarketPlaceMultiplier.TabIndex = 2;
            // 
            // txtRepairMultiplier
            // 
            this.txtRepairMultiplier.Location = new System.Drawing.Point(13, 73);
            this.txtRepairMultiplier.Name = "txtRepairMultiplier";
            this.txtRepairMultiplier.Size = new System.Drawing.Size(166, 20);
            this.txtRepairMultiplier.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repair Multiplier";
            // 
            // txtInsuranceMultiplier
            // 
            this.txtInsuranceMultiplier.Location = new System.Drawing.Point(12, 120);
            this.txtInsuranceMultiplier.Name = "txtInsuranceMultiplier";
            this.txtInsuranceMultiplier.Size = new System.Drawing.Size(166, 20);
            this.txtInsuranceMultiplier.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insure Multiplier";
            // 
            // chkBuyFoundInRaid
            // 
            this.chkBuyFoundInRaid.AutoSize = true;
            this.chkBuyFoundInRaid.Location = new System.Drawing.Point(15, 212);
            this.chkBuyFoundInRaid.Name = "chkBuyFoundInRaid";
            this.chkBuyFoundInRaid.Size = new System.Drawing.Size(174, 18);
            this.chkBuyFoundInRaid.TabIndex = 7;
            this.chkBuyFoundInRaid.Text = "Buy items marked found in raid";
            this.chkBuyFoundInRaid.UseVisualStyleBackColor = true;
            // 
            // txtInsureReturnChance
            // 
            this.txtInsureReturnChance.Location = new System.Drawing.Point(12, 163);
            this.txtInsureReturnChance.Name = "txtInsureReturnChance";
            this.txtInsureReturnChance.Size = new System.Drawing.Size(166, 20);
            this.txtInsureReturnChance.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Insure Return Chance";
            // 
            // TradingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 319);
            this.Controls.Add(this.txtInsureReturnChance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBuyFoundInRaid);
            this.Controls.Add(this.txtInsuranceMultiplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRepairMultiplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarketPlaceMultiplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "TradingForm";
            this.Text = "Traders/Marketplace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarketPlaceMultiplier;
        private System.Windows.Forms.TextBox txtRepairMultiplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsuranceMultiplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBuyFoundInRaid;
        private System.Windows.Forms.TextBox txtInsureReturnChance;
        private System.Windows.Forms.Label label4;
    }
}