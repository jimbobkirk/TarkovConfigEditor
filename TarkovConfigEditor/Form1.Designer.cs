namespace TarkovConfigEditor
{
    partial class Form1
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
            this.chkWeight = new System.Windows.Forms.CheckBox();
            this.btnTrading = new TarkovConfigEditor.BaseButton();
            this.btnSettings = new TarkovConfigEditor.BaseButton();
            this.btnHelmet = new TarkovConfigEditor.BaseButton();
            this.btnArmour = new TarkovConfigEditor.BaseButton();
            this.btnCharacters = new TarkovConfigEditor.BaseButton();
            this.btnBackpacks = new TarkovConfigEditor.BaseButton();
            this.btnMagazines = new TarkovConfigEditor.BaseButton();
            this.SuspendLayout();
            // 
            // chkWeight
            // 
            this.chkWeight.AutoSize = true;
            this.chkWeight.Location = new System.Drawing.Point(13, 338);
            this.chkWeight.Name = "chkWeight";
            this.chkWeight.Size = new System.Drawing.Size(77, 17);
            this.chkWeight.TabIndex = 0;
            this.chkWeight.Text = "No Weight";
            this.chkWeight.UseVisualStyleBackColor = true;
            this.chkWeight.CheckedChanged += new System.EventHandler(this.chkWeight_CheckedChanged);
            // 
            // btnTrading
            // 
            this.btnTrading.BackColor = System.Drawing.Color.Black;
            this.btnTrading.Location = new System.Drawing.Point(137, 12);
            this.btnTrading.Name = "btnTrading";
            this.btnTrading.Size = new System.Drawing.Size(118, 58);
            this.btnTrading.TabIndex = 6;
            this.btnTrading.Text = "Traders/Marketplace";
            this.btnTrading.UseVisualStyleBackColor = false;
            this.btnTrading.Click += new System.EventHandler(this.btnTrading_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(599, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHelmet
            // 
            this.btnHelmet.BackColor = System.Drawing.Color.Black;
            this.btnHelmet.ForeColor = System.Drawing.Color.White;
            this.btnHelmet.Location = new System.Drawing.Point(12, 144);
            this.btnHelmet.Name = "btnHelmet";
            this.btnHelmet.Size = new System.Drawing.Size(118, 58);
            this.btnHelmet.TabIndex = 4;
            this.btnHelmet.Text = "Helmet";
            this.btnHelmet.UseVisualStyleBackColor = false;
            this.btnHelmet.Click += new System.EventHandler(this.btnHelmet_Click);
            // 
            // btnArmour
            // 
            this.btnArmour.BackColor = System.Drawing.Color.Black;
            this.btnArmour.Location = new System.Drawing.Point(13, 80);
            this.btnArmour.Name = "btnArmour";
            this.btnArmour.Size = new System.Drawing.Size(118, 58);
            this.btnArmour.TabIndex = 3;
            this.btnArmour.Text = "Armour";
            this.btnArmour.UseVisualStyleBackColor = false;
            this.btnArmour.Click += new System.EventHandler(this.btnArmour_Click);
            // 
            // btnCharacters
            // 
            this.btnCharacters.BackColor = System.Drawing.Color.Black;
            this.btnCharacters.Location = new System.Drawing.Point(13, 12);
            this.btnCharacters.Name = "btnCharacters";
            this.btnCharacters.Size = new System.Drawing.Size(118, 58);
            this.btnCharacters.TabIndex = 2;
            this.btnCharacters.Text = "Character";
            this.btnCharacters.UseVisualStyleBackColor = false;
            this.btnCharacters.Click += new System.EventHandler(this.btnCharacters_Click);
            // 
            // btnBackpacks
            // 
            this.btnBackpacks.BackColor = System.Drawing.Color.Black;
            this.btnBackpacks.Location = new System.Drawing.Point(13, 209);
            this.btnBackpacks.Name = "btnBackpacks";
            this.btnBackpacks.Size = new System.Drawing.Size(118, 56);
            this.btnBackpacks.TabIndex = 1;
            this.btnBackpacks.Text = "Backpacks";
            this.btnBackpacks.UseVisualStyleBackColor = false;
            this.btnBackpacks.Click += new System.EventHandler(this.btnBackpacks_Click);
            // 
            // btnMagazines
            // 
            this.btnMagazines.BackColor = System.Drawing.Color.Black;
            this.btnMagazines.Location = new System.Drawing.Point(137, 80);
            this.btnMagazines.Name = "btnMagazines";
            this.btnMagazines.Size = new System.Drawing.Size(118, 58);
            this.btnMagazines.TabIndex = 7;
            this.btnMagazines.Text = "Magazines";
            this.btnMagazines.UseVisualStyleBackColor = false;
            this.btnMagazines.Click += new System.EventHandler(this.btnMagazines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 381);
            this.Controls.Add(this.btnMagazines);
            this.Controls.Add(this.btnTrading);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnHelmet);
            this.Controls.Add(this.btnArmour);
            this.Controls.Add(this.btnCharacters);
            this.Controls.Add(this.btnBackpacks);
            this.Controls.Add(this.chkWeight);
            this.Name = "Form1";
            this.Text = "EmuTarkov Profile Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BaseButton btnBackpacks;
        private BaseButton btnCharacters;
        private BaseButton btnArmour;
        private BaseButton btnHelmet;
        private System.Windows.Forms.CheckBox chkWeight;
        private BaseButton btnSettings;
        private BaseButton btnTrading;
        private BaseButton btnMagazines;
    }
}

