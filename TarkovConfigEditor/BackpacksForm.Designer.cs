namespace TarkovConfigEditor
{
    partial class BackpacksForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlotsHigh = new System.Windows.Forms.TextBox();
            this.txtSlotsWide = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxBackpacksList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Backpack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(12, 244);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slots High";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Slots Wide";
            // 
            // txtSlotsHigh
            // 
            this.txtSlotsHigh.Location = new System.Drawing.Point(12, 190);
            this.txtSlotsHigh.Name = "txtSlotsHigh";
            this.txtSlotsHigh.Size = new System.Drawing.Size(100, 20);
            this.txtSlotsHigh.TabIndex = 3;
            // 
            // txtSlotsWide
            // 
            this.txtSlotsWide.Location = new System.Drawing.Point(13, 136);
            this.txtSlotsWide.Name = "txtSlotsWide";
            this.txtSlotsWide.Size = new System.Drawing.Size(100, 20);
            this.txtSlotsWide.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(12, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(490, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxBackpacksList
            // 
            this.cbxBackpacksList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBackpacksList.FormattingEnabled = true;
            this.cbxBackpacksList.Location = new System.Drawing.Point(13, 33);
            this.cbxBackpacksList.Name = "cbxBackpacksList";
            this.cbxBackpacksList.Size = new System.Drawing.Size(489, 22);
            this.cbxBackpacksList.TabIndex = 0;
            this.cbxBackpacksList.SelectedIndexChanged += new System.EventHandler(this.cbxBackpacksList_SelectedIndexChanged);
            // 
            // BackpacksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSlotsHigh);
            this.Controls.Add(this.txtSlotsWide);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxBackpacksList);
            this.Name = "BackpacksForm";
            this.Text = "Backpacks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxBackpacksList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSlotsWide;
        private System.Windows.Forms.TextBox txtSlotsHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label4;
    }
}