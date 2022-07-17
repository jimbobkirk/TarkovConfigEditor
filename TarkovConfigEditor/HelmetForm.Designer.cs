namespace TarkovConfigEditor
{
    partial class HelmetForm
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
            this.btnSave = new TarkovConfigEditor.BaseButton();
            this.chkProtectsTop = new System.Windows.Forms.CheckBox();
            this.chkProtectsNape = new System.Windows.Forms.CheckBox();
            this.chkProtectsEars = new System.Windows.Forms.CheckBox();
            this.chkProtectsEyes = new System.Windows.Forms.CheckBox();
            this.chkProtectsJaws = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Helmet";
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
            this.btnSave.Location = new System.Drawing.Point(35, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 55);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkProtectsTop
            // 
            this.chkProtectsTop.AutoSize = true;
            this.chkProtectsTop.Location = new System.Drawing.Point(216, 84);
            this.chkProtectsTop.Name = "chkProtectsTop";
            this.chkProtectsTop.Size = new System.Drawing.Size(86, 18);
            this.chkProtectsTop.TabIndex = 18;
            this.chkProtectsTop.Text = "Protects Top";
            this.chkProtectsTop.UseVisualStyleBackColor = true;
            this.chkProtectsTop.CheckedChanged += new System.EventHandler(this.chkProtectsAreas_CheckedChanged);
            // 
            // chkProtectsNape
            // 
            this.chkProtectsNape.AutoSize = true;
            this.chkProtectsNape.Location = new System.Drawing.Point(216, 109);
            this.chkProtectsNape.Name = "chkProtectsNape";
            this.chkProtectsNape.Size = new System.Drawing.Size(94, 18);
            this.chkProtectsNape.TabIndex = 19;
            this.chkProtectsNape.Text = "Protects Nape";
            this.chkProtectsNape.UseVisualStyleBackColor = true;
            this.chkProtectsNape.CheckedChanged += new System.EventHandler(this.chkProtectsAreas_CheckedChanged);
            // 
            // chkProtectsEars
            // 
            this.chkProtectsEars.AutoSize = true;
            this.chkProtectsEars.Location = new System.Drawing.Point(216, 135);
            this.chkProtectsEars.Name = "chkProtectsEars";
            this.chkProtectsEars.Size = new System.Drawing.Size(91, 18);
            this.chkProtectsEars.TabIndex = 20;
            this.chkProtectsEars.Text = "Protects Ears";
            this.chkProtectsEars.UseVisualStyleBackColor = true;
            this.chkProtectsEars.CheckedChanged += new System.EventHandler(this.chkProtectsAreas_CheckedChanged);
            // 
            // chkProtectsEyes
            // 
            this.chkProtectsEyes.AutoSize = true;
            this.chkProtectsEyes.Location = new System.Drawing.Point(216, 159);
            this.chkProtectsEyes.Name = "chkProtectsEyes";
            this.chkProtectsEyes.Size = new System.Drawing.Size(93, 18);
            this.chkProtectsEyes.TabIndex = 21;
            this.chkProtectsEyes.Text = "Protects Eyes";
            this.chkProtectsEyes.UseVisualStyleBackColor = true;
            this.chkProtectsEyes.CheckedChanged += new System.EventHandler(this.chkProtectsAreas_CheckedChanged);
            // 
            // chkProtectsJaws
            // 
            this.chkProtectsJaws.AutoSize = true;
            this.chkProtectsJaws.Location = new System.Drawing.Point(216, 184);
            this.chkProtectsJaws.Name = "chkProtectsJaws";
            this.chkProtectsJaws.Size = new System.Drawing.Size(96, 18);
            this.chkProtectsJaws.TabIndex = 22;
            this.chkProtectsJaws.Text = "Protects Jaws";
            this.chkProtectsJaws.UseVisualStyleBackColor = true;
            this.chkProtectsJaws.CheckedChanged += new System.EventHandler(this.chkProtectsAreas_CheckedChanged);
            // 
            // HelmetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 366);
            this.Controls.Add(this.chkProtectsJaws);
            this.Controls.Add(this.chkProtectsEyes);
            this.Controls.Add(this.chkProtectsEars);
            this.Controls.Add(this.chkProtectsNape);
            this.Controls.Add(this.chkProtectsTop);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDurability);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxArmourList);
            this.Name = "HelmetForm";
            this.Text = "Helmet";
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
        private System.Windows.Forms.CheckBox chkProtectsTop;
        private System.Windows.Forms.CheckBox chkProtectsNape;
        private System.Windows.Forms.CheckBox chkProtectsEars;
        private System.Windows.Forms.CheckBox chkProtectsEyes;
        private System.Windows.Forms.CheckBox chkProtectsJaws;
        private BaseButton btnSave;
    }
}