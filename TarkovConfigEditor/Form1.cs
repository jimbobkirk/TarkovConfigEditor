using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarkovConfigEditor
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
            LoadAll();
        }

        private void LoadAll()
        {
            try
            {
                SaveAndLoad.LoadAll();
                chkWeight.Checked = StaticStuff.lessWeightItems.configuration.NoWeight;
            }
            catch {
                MessageBox.Show("Please select your server folder location.", "There was an error loading the data");
                ShowServerForm();
            }
        }

        private void chkWeight_CheckedChanged(object sender, EventArgs e)
        {
            StaticStuff.lessWeightItems.configuration.NoWeight = chkWeight.Checked;
            SaveAndLoad.SaveLessWeightItems();
        }

        private void btnBackpacks_Click(object sender, EventArgs e)
        {
            BackpacksForm backpacksForm = new BackpacksForm();
            backpacksForm.Show();
        }

        private void btnCharacters_Click(object sender, EventArgs e)
        {
            CharactersForm backpacksForm = new CharactersForm();
            backpacksForm.Show();
        }

        private void btnArmour_Click(object sender, EventArgs e)
        {
            ArmourForm armourForm = new ArmourForm();
            armourForm.Show();
        }

        private void btnHelmet_Click(object sender, EventArgs e)
        {
            HelmetForm armourForm = new HelmetForm();
            armourForm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowServerForm();
        }

        private void ShowServerForm()
        {
            ServerFolderEdit armourForm = new ServerFolderEdit();
            armourForm.ShowDialog();
            LoadAll();
        }

        private void btnTrading_Click(object sender, EventArgs e)
        {
            TradingForm armourForm = new TradingForm();
            armourForm.Show();
        }

        private void btnMagazines_Click(object sender, EventArgs e)
        {
            MagazinesForm armourForm = new MagazinesForm();
            armourForm.Show();
        }
    }
}
