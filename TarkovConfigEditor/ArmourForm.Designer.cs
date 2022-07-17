namespace TarkovConfigEditor
{
    partial class ArmourForm
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
            this.cbxArmourList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDurability = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkProtectsRightArm = new System.Windows.Forms.CheckBox();
            this.chkProtectsLeftArm = new System.Windows.Forms.CheckBox();
            this.chkProtectsChest = new System.Windows.Forms.CheckBox();
            this.chkProtectsStomach = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Armour";
            // 
            // cbxArmourList
            // 
            this.cbxArmourList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArmourList.FormattingEnabled = true;
            this.cbxArmourList.Location = new System.Drawing.Point(12, 25);
            this.cbxArmourList.Name = "cbxArmourList";
            this.cbxArmourList.Size = new System.Drawing.Size(251, 22);
            this.cbxArmourList.TabIndex = 9;
            this.cbxArmourList.SelectedIndexChanged += new System.EventHandler(this.cbxArmourList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(12, 191);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Durability";
            // 
            // txtDurability
            // 
            this.txtDurability.Location = new System.Drawing.Point(12, 82);
            this.txtDurability.Name = "txtDurability";
            this.txtDurability.Size = new System.Drawing.Size(100, 20);
            this.txtDurability.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Class";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(12, 132);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(61, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 55);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkProtectsRightArm
            // 
            this.chkProtectsRightArm.AutoSize = true;
            this.chkProtectsRightArm.Location = new System.Drawing.Point(244, 85);
            this.chkProtectsRightArm.Name = "chkProtectsRightArm";
            this.chkProtectsRightArm.Size = new System.Drawing.Size(110, 18);
            this.chkProtectsRightArm.TabIndex = 18;
            this.chkProtectsRightArm.Text = "Protects Left Arm";
            this.chkProtectsRightArm.UseVisualStyleBackColor = true;
            this.chkProtectsRightArm.CheckedChanged += new System.EventHandler(this.chkProtectsArea_CheckedChanged);
            // 
            // chkProtectsLeftArm
            // 
            this.chkProtectsLeftArm.AutoSize = true;
            this.chkProtectsLeftArm.Location = new System.Drawing.Point(244, 110);
            this.chkProtectsLeftArm.Name = "chkProtectsLeftArm";
            this.chkProtectsLeftArm.Size = new System.Drawing.Size(115, 18);
            this.chkProtectsLeftArm.TabIndex = 19;
            this.chkProtectsLeftArm.Text = "Protects Right Arm";
            this.chkProtectsLeftArm.UseVisualStyleBackColor = true;
            this.chkProtectsLeftArm.CheckedChanged += new System.EventHandler(this.chkProtectsArea_CheckedChanged);
            // 
            // chkProtectsChest
            // 
            this.chkProtectsChest.AutoSize = true;
            this.chkProtectsChest.Location = new System.Drawing.Point(244, 135);
            this.chkProtectsChest.Name = "chkProtectsChest";
            this.chkProtectsChest.Size = new System.Drawing.Size(97, 18);
            this.chkProtectsChest.TabIndex = 20;
            this.chkProtectsChest.Text = "Protects Chest";
            this.chkProtectsChest.UseVisualStyleBackColor = true;
            this.chkProtectsChest.CheckedChanged += new System.EventHandler(this.chkProtectsArea_CheckedChanged);
            // 
            // chkProtectsStomach
            // 
            this.chkProtectsStomach.AutoSize = true;
            this.chkProtectsStomach.Location = new System.Drawing.Point(244, 159);
            this.chkProtectsStomach.Name = "chkProtectsStomach";
            this.chkProtectsStomach.Size = new System.Drawing.Size(111, 18);
            this.chkProtectsStomach.TabIndex = 21;
            this.chkProtectsStomach.Text = "Protects Stomach";
            this.chkProtectsStomach.UseVisualStyleBackColor = true;
            this.chkProtectsStomach.CheckedChanged += new System.EventHandler(this.chkProtectsArea_CheckedChanged);
            // 
            // ArmourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 348);
            this.Controls.Add(this.chkProtectsStomach);
            this.Controls.Add(this.chkProtectsChest);
            this.Controls.Add(this.chkProtectsLeftArm);
            this.Controls.Add(this.chkProtectsRightArm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDurability);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxArmourList);
            this.Name = "ArmourForm";
            this.Text = "Armour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxArmourList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDurability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkProtectsRightArm;
        private System.Windows.Forms.CheckBox chkProtectsLeftArm;
        private System.Windows.Forms.CheckBox chkProtectsChest;
        private System.Windows.Forms.CheckBox chkProtectsStomach;
    }
}