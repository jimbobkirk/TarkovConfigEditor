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
using static TarkovConfigEditor.TarkovClasses.Character;

namespace TarkovConfigEditor
{
    public partial class CharactersForm : BaseForm
    {
        public CharactersForm()
        {
            InitializeComponent();
            LoadCharacters();
            LoadQuestStatuses();
        }

        public void LoadQuestStatuses()
        {
            cbxQuestStatus.Items.Add("Success");
            cbxQuestStatus.Items.Add("Started");
            cbxQuestStatus.Items.Add("Fail");
            cbxQuestStatus.Items.Add("Locked");
            cbxQuestStatus.Items.Add("AvailableForStart");
            cbxQuestStatus.Items.Add("AvailableForFinish");
            foreach (var item in StaticStuff.quests.OrderBy(x => x.QuestName))
            {
                cbxQuests.Items.Add(item);
            }
        }

        public void LoadCharacters()
        {
            foreach (var backpack in StaticStuff.characters)
            {
                cbxCharacterList.Items.Add(backpack);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Character backpack = (Character)cbxCharacterList.SelectedItem;
            //backpack.Info.Level = Convert.ToInt32(txtLevel.Text);
            backpack.Info.Experience = Convert.ToInt32(txtXP.Text);
            SaveAndLoad.SaveCharacter();
        }

        private void cbxCharacterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var backpack = (Character)cbxCharacterList.SelectedItem;
            //txtLevel.Text = backpack.Info.Level.ToString();
            txtXP.Text = backpack.Info.Experience.ToString();
            foreach(var skill in backpack.Skills.Common)
            {
                cbxSkills.Items.Add(skill);
            }
            panel1.Enabled = true;
        }

        private void cbxSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Common)cbxSkills.SelectedItem;
            txtSkillXP.Text = item.Progress.ToString();
        }

        private void txtSkillXP_TextChanged(object sender, EventArgs e)
        {
            var item = (Common)cbxSkills.SelectedItem;
            try
            {
                item.Progress = Convert.ToDouble(txtSkillXP.Text);
            }
            catch { }
        }

        private void cbxQuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            var character = (Character)cbxCharacterList.SelectedItem;
            var id = StaticStuff.quests.Where(x => x.QuestName == cbxQuests.SelectedItem.ToString()).FirstOrDefault().QuestID;
            cbxQuestStatus.SelectedItem = character.Quests.Where(x => x.qid == id).FirstOrDefault().status;
        }

        private void cbxQuestStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var character = (Character)cbxCharacterList.SelectedItem;
            var id = StaticStuff.quests.Where(x => x.QuestName == cbxQuests.SelectedItem.ToString()).FirstOrDefault().QuestID;
            character.Quests.Where(x => x.qid == id).FirstOrDefault().status = cbxQuestStatus.SelectedItem.ToString();
        }
    }
}
