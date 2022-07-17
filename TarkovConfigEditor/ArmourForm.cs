using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarkovConfigEditor.TarkovClasses;

namespace TarkovConfigEditor
{
    public partial class ArmourForm : BaseForm
    {
        public ArmourForm()
        {
            InitializeComponent();
            LoadArmour();
        }

        public void LoadArmour()
        {
            foreach (var backpack in StaticStuff.armour)
            {
                cbxArmourList.Items.Add(backpack);
            }
        }

        private void cbxArmourList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var armour = (Armour)cbxArmourList.SelectedItem;
            txtClass.Text = armour._props.armorClass;
            txtDurability.Text = armour._props.Durability.ToString();
            txtWeight.Text = armour._props.Weight.ToString();
            chkProtectsLeftArm.Checked = armour._props.armorZone.Contains("LeftArm");
            chkProtectsRightArm.Checked = armour._props.armorZone.Contains("RightArm");
            chkProtectsChest.Checked = armour._props.armorZone.Contains("Chest");
            chkProtectsStomach.Checked = armour._props.armorZone.Contains("Stomach");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Armour armour = (Armour)cbxArmourList.SelectedItem;
            armour._props.armorClass = txtClass.Text;
            armour._props.Durability = Convert.ToInt32(txtDurability.Text);
            armour._props.MaxDurability = Convert.ToInt32(txtDurability.Text);
            armour._props.Weight = Convert.ToDouble(txtWeight.Text);
            SaveAndLoad.SaveArmour();
        }


        private void chkProtectsArea_CheckedChanged(object sender, EventArgs e)
        {
            List<string> headSegments = new List<string>();
            if (chkProtectsLeftArm.Checked)
                headSegments.Add("LeftArm");
            if (chkProtectsRightArm.Checked)
                headSegments.Add("RightArm");
            if (chkProtectsChest.Checked)
                headSegments.Add("Chest");
            if (chkProtectsStomach.Checked)
                headSegments.Add("Stomach");

            Armour armour = (Armour)cbxArmourList.SelectedItem;
            armour._props.armorZone = headSegments;
        }
    }
}
