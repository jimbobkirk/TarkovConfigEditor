namespace TarkovConfigEditor
{
    partial class MagazinesForm
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
            this.cbxMagazineList = new System.Windows.Forms.ComboBox();
            this.btnSave = new TarkovConfigEditor.BaseButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecoil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtErgonomics = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmmoCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Magazine";
            // 
            // cbxMagazineList
            // 
            this.cbxMagazineList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMagazineList.FormattingEnabled = true;
            this.cbxMagazineList.Location = new System.Drawing.Point(16, 29);
            this.cbxMagazineList.Name = "cbxMagazineList";
            this.cbxMagazineList.Size = new System.Drawing.Size(251, 22);
            this.cbxMagazineList.TabIndex = 11;
            this.cbxMagazineList.SelectedIndexChanged += new System.EventHandler(this.cbxMagazineList_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(11, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(251, 71);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(16, 72);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 15;
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(16, 118);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(100, 20);
            this.txtAccuracy.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Accuracy";
            // 
            // txtRecoil
            // 
            this.txtRecoil.Location = new System.Drawing.Point(16, 165);
            this.txtRecoil.Name = "txtRecoil";
            this.txtRecoil.Size = new System.Drawing.Size(100, 20);
            this.txtRecoil.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Recoil";
            // 
            // txtErgonomics
            // 
            this.txtErgonomics.Location = new System.Drawing.Point(16, 213);
            this.txtErgonomics.Name = "txtErgonomics";
            this.txtErgonomics.Size = new System.Drawing.Size(100, 20);
            this.txtErgonomics.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ergonomics";
            // 
            // txtAmmoCount
            // 
            this.txtAmmoCount.Location = new System.Drawing.Point(16, 262);
            this.txtAmmoCount.Name = "txtAmmoCount";
            this.txtAmmoCount.Size = new System.Drawing.Size(100, 20);
            this.txtAmmoCount.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ammo Count";
            // 
            // MagazinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 394);
            this.Controls.Add(this.txtAmmoCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtErgonomics);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRecoil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccuracy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxMagazineList);
            this.Name = "MagazinesForm";
            this.Text = "MagazinesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMagazineList;
        private BaseButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtAccuracy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecoil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtErgonomics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmmoCount;
        private System.Windows.Forms.Label label6;
    }
}