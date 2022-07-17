using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarkovConfigEditor.Properties;

namespace TarkovConfigEditor
{
    public partial class ServerFolderEdit : BaseForm
    {
        public ServerFolderEdit()
        {
            InitializeComponent();
            txtServerLoction.Text = Settings.Default.TarkovServerFolder;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtServerLoction.Text = Settings.Default.TarkovServerFolder;
            folderBrowserDialog1.SelectedPath = txtServerLoction.Text;
            var resul = folderBrowserDialog1.ShowDialog();
            txtServerLoction.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.TarkovServerFolder = txtServerLoction.Text;
            string lastChar = txtServerLoction.Text.Substring(txtServerLoction.Text.Length - 1, 1);
            if (lastChar != "\\" && lastChar != "/")
                Settings.Default.TarkovServerFolder += "/";
            SaveAndLoad.BaseServerPath = Settings.Default.TarkovServerFolder;
            Settings.Default.Save();
        }
    }
}
