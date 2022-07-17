using Newtonsoft.Json.Linq;
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
    public partial class MagazinesForm : BaseForm
    {
        public MagazinesForm()
        {
            InitializeComponent();
            foreach(var mag in StaticStuff.magazines.Where(x => x._type == "Item"))
            {
                cbxMagazineList.Items.Add(mag);
            }
        }

        private void cbxMagazineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mag = (Magazines)cbxMagazineList.SelectedItem;
            var props = ((JObject)mag._props).ToObject<Magazines.Props>();
            txtAccuracy.Text = props.Accuracy.ToString();
            txtErgonomics.Text = props.Ergonomics.ToString();
            txtRecoil.Text = props.Recoil.ToString();
            txtWeight.Text = props.Weight.ToString();
            txtAmmoCount.Text = props.Cartridges.First()._max_count.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mag = (Magazines)cbxMagazineList.SelectedItem;
            var props = ((JObject)mag._props).ToObject<Magazines.Props>();
            props.Accuracy = Convert.ToDouble(txtAccuracy.Text);
            props.Ergonomics = Convert.ToDouble(txtErgonomics.Text);
            props.Recoil = Convert.ToDouble(txtRecoil.Text);
            props.Weight = Convert.ToDouble(txtWeight.Text);
            props.Cartridges.First()._max_count = Convert.ToInt32(txtAmmoCount.Text);
            mag._props = props;
            SaveAndLoad.SaveMagazines();
        }
    }
}
