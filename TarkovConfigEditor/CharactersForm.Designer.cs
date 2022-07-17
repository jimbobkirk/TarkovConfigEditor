namespace TarkovConfigEditor
{
    partial class CharactersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxQuestStatus = new System.Windows.Forms.ComboBox();
            this.txtXP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSkills = new System.Windows.Forms.ComboBox();
            this.cbxQuests = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSkillXP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxCharacterList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxQuestStatus);
            this.panel1.Controls.Add(this.txtXP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbxSkills);
            this.panel1.Controls.Add(this.cbxQuests);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSkillXP);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 235);
            this.panel1.TabIndex = 17;
            // 
            // cbxQuestStatus
            // 
            this.cbxQuestStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuestStatus.FormattingEnabled = true;
            this.cbxQuestStatus.Location = new System.Drawing.Point(343, 85);
            this.cbxQuestStatus.Name = "cbxQuestStatus";
            this.cbxQuestStatus.Size = new System.Drawing.Size(148, 22);
            this.cbxQuestStatus.TabIndex = 16;
            this.cbxQuestStatus.SelectedIndexChanged += new System.EventHandler(this.cbxQuestStatus_SelectedIndexChanged);
            // 
            // txtXP
            // 
            this.txtXP.Location = new System.Drawing.Point(8, 27);
            this.txtXP.Name = "txtXP";
            this.txtXP.Size = new System.Drawing.Size(100, 20);
            this.txtXP.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "XP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quest";
            // 
            // cbxSkills
            // 
            this.cbxSkills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSkills.FormattingEnabled = true;
            this.cbxSkills.Location = new System.Drawing.Point(8, 116);
            this.cbxSkills.Name = "cbxSkills";
            this.cbxSkills.Size = new System.Drawing.Size(251, 22);
            this.cbxSkills.TabIndex = 8;
            this.cbxSkills.SelectedIndexChanged += new System.EventHandler(this.cbxSkills_SelectedIndexChanged);
            // 
            // cbxQuests
            // 
            this.cbxQuests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuests.FormattingEnabled = true;
            this.cbxQuests.Location = new System.Drawing.Point(343, 37);
            this.cbxQuests.Name = "cbxQuests";
            this.cbxQuests.Size = new System.Drawing.Size(251, 22);
            this.cbxQuests.TabIndex = 12;
            this.cbxQuests.SelectedIndexChanged += new System.EventHandler(this.cbxQuests_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Skills";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "XP";
            // 
            // txtSkillXP
            // 
            this.txtSkillXP.Location = new System.Drawing.Point(11, 167);
            this.txtSkillXP.Name = "txtSkillXP";
            this.txtSkillXP.Size = new System.Drawing.Size(100, 20);
            this.txtSkillXP.TabIndex = 10;
            this.txtSkillXP.TextChanged += new System.EventHandler(this.txtSkillXP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Character";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(12, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(635, 53);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxCharacterList
            // 
            this.cbxCharacterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCharacterList.FormattingEnabled = true;
            this.cbxCharacterList.Location = new System.Drawing.Point(12, 33);
            this.cbxCharacterList.Name = "cbxCharacterList";
            this.cbxCharacterList.Size = new System.Drawing.Size(251, 22);
            this.cbxCharacterList.TabIndex = 1;
            this.cbxCharacterList.SelectedIndexChanged += new System.EventHandler(this.cbxCharacterList_SelectedIndexChanged);
            // 
            // CharactersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxCharacterList);
            this.Name = "CharactersForm";
            this.Text = "Characters";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCharacterList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSkills;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSkillXP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxQuests;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxQuestStatus;
        private System.Windows.Forms.Panel panel1;
    }
}