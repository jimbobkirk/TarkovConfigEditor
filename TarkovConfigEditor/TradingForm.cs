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
    public partial class TradingForm : BaseForm
    {
        public TradingForm()
        {
            InitializeComponent();
            txtInsuranceMultiplier.Text = StaticStuff.gameplay.trading.insureMultiplier.ToString();
            txtMarketPlaceMultiplier.Text = StaticStuff.gameplay.trading.ragfairMultiplier.ToString();
            txtRepairMultiplier.Text = StaticStuff.gameplay.trading.repairMultiplier.ToString();
            txtInsureReturnChance.Text = StaticStuff.gameplay.trading.insureReturnChance.ToString();
            chkBuyFoundInRaid.Checked = StaticStuff.gameplay.trading.buyItemsMarkedFound;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaticStuff.gameplay.trading.insureMultiplier = Convert.ToDouble(txtInsuranceMultiplier.Text);
            StaticStuff.gameplay.trading.ragfairMultiplier = Convert.ToDouble(txtMarketPlaceMultiplier.Text);
            StaticStuff.gameplay.trading.repairMultiplier = Convert.ToDouble(txtRepairMultiplier.Text);
            StaticStuff.gameplay.trading.insureReturnChance = Convert.ToInt32(txtInsureReturnChance.Text);
            StaticStuff.gameplay.trading.buyItemsMarkedFound = chkBuyFoundInRaid.Checked;
            SaveAndLoad.SaveGameplay();
        }
    }
}
