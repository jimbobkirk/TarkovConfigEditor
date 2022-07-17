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
    public partial class BackpacksForm : BaseForm
    {
        public BackpacksForm()
        {
            InitializeComponent();
            LoadBackpacks();
        }

        public void LoadBackpacks()
        {
            foreach(var backpack in StaticStuff.backpack)
            {
                cbxBackpacksList.Items.Add(backpack);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Backpack backpack = (Backpack)cbxBackpacksList.SelectedItem;
            backpack._props.Grids.First()._props.cellsH = Convert.ToInt32(txtSlotsWide.Text);
            backpack._props.Grids.First()._props.cellsV = Convert.ToInt32(txtSlotsHigh.Text);
            backpack._props.Weight = Convert.ToDouble(txtWeight.Text);
            SaveAndLoad.SaveBackpack();
        }

        private void cbxBackpacksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var backpack = (Backpack)cbxBackpacksList.SelectedItem;
            txtSlotsWide.Text = backpack._props.Grids.First()._props.cellsH.ToString();
            txtSlotsHigh.Text = backpack._props.Grids.First()._props.cellsV.ToString();
            txtWeight.Text = backpack._props.Weight.ToString();
        }
    }
}
