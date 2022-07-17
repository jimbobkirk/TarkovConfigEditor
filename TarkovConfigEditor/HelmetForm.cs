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
    public partial class HelmetForm : BaseForm
    {
        bool isLoading = true;
        public HelmetForm()
        {
            InitializeComponent();
            LoadHelmet();
        }

        public void LoadHelmet()
        {
            foreach (var backpack in StaticStuff.helmet)
            {
                cbxArmourList.Items.Add(backpack);
            }
        }

        private void cbxArmourList_SelectedIndexChanged(object sender, EventArgs e)
        {
            isLoading = true;
            var armour = (Helmet)cbxArmourList.SelectedItem;
            txtClass.Text = armour._props.armorClass;
            txtDurability.Text = armour._props.Durability.ToString();
            txtWeight.Text = armour._props.Weight.ToString();
            chkProtectsTop.Checked = armour._props.headSegments.Contains("Top");
            chkProtectsNape.Checked = armour._props.headSegments.Contains("Nape");
            chkProtectsEars.Checked = armour._props.headSegments.Contains("Ears");
            chkProtectsEyes.Checked = armour._props.headSegments.Contains("Eyes");
            chkProtectsJaws.Checked = armour._props.headSegments.Contains("Jaws");
            isLoading = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Helmet armour = (Helmet)cbxArmourList.SelectedItem;
            armour._props.armorClass = txtClass.Text;
            armour._props.Durability = Convert.ToInt32(txtDurability.Text);
            armour._props.MaxDurability = Convert.ToInt32(txtDurability.Text);
            armour._props.Weight = Convert.ToDouble(txtWeight.Text);
            SaveAndLoad.SaveHelmet();
        }

        private void chkProtectsAreas_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            List<string> headSegments = new List<string>();
            if (chkProtectsTop.Checked)
                headSegments.Add("Top");
            if (chkProtectsNape.Checked)
                headSegments.Add("Nape");
            if (chkProtectsEars.Checked)
                headSegments.Add("Ears");
            if (chkProtectsEyes.Checked)
                headSegments.Add("Eyes");
            if (chkProtectsJaws.Checked)
                headSegments.Add("Jaws");

            Helmet armour = (Helmet)cbxArmourList.SelectedItem;
            armour._props.headSegments = headSegments;
        }
    }
}
