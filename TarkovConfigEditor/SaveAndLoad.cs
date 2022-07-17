using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarkovConfigEditor.Properties;
using TarkovConfigEditor.TarkovClasses;

namespace TarkovConfigEditor
{
    public class SaveAndLoad
    {
        public static string BaseServerPath = Settings.Default.TarkovServerFolder;
        public static string LessWeightItemsPath = "user\\mods\\LessWeightItems_1.0.0\\mod.config.json";
        public static string BackpackPath = "db\\items\\Backpack.json";

        public static string LoadFile(string path)
        {
            return File.ReadAllText(BaseServerPath + path);
        }

        public static string LoadFileFullPath(string path)
        {
            return File.ReadAllText(path);
        }

        public static void Save(string path, string text)
        {
            File.WriteAllText(BaseServerPath + path, text);
        }

        public static void LoadAll()
        {
            try
            {
                StaticStuff.lessWeightItems = Serialiser.Deserialise<LessWeightItems>(LoadFile(LessWeightItemsPath));
            }
            catch { }
            StaticStuff.backpack = Serialiser.Deserialise<List<Backpack>>(LoadFile(BackpackPath));
            //StaticStuff.locale = Serialiser.Deserialise<Locale>(LoadFile("D:\\TarkovOffline2022\\server\\db\\locales\\en\\locale.json"));
            StaticStuff.quests = QuestMap.LoadQuests();
            StaticStuff.armour = Serialiser.Deserialise<List<Armour>>(LoadFile("\\db\\items\\Armor.json"));
            StaticStuff.helmet = Serialiser.Deserialise<List<Helmet>>(LoadFile("\\db\\items\\Headwear.json"));
            StaticStuff.magazines = Serialiser.Deserialise<List<Magazines>>(LoadFile("\\db\\items\\Magazine.json"));
            StaticStuff.gameplay = Serialiser.Deserialise<Gameplay>(LoadFile("\\user\\configs\\gameplay.json"));
            StaticStuff.characters = new List<Character>();
            foreach (string file in Directory.GetDirectories(BaseServerPath + "\\user\\profiles"))
            {
                StaticStuff.characters.Add(Serialiser.Deserialise<Character>(LoadFileFullPath(file + "\\character.json")));
            }
        }

        public static void SaveLessWeightItems()
        {
            Save(LessWeightItemsPath, Serialiser.Serialise<LessWeightItems>(StaticStuff.lessWeightItems));
        }

        public static void SaveBackpack()
        {
            Save(BackpackPath, Serialiser.Serialise<List<Backpack>>(StaticStuff.backpack));
        }

        public static void SaveMagazines()
        {
            //fix for item 610720f290b75a49ff2e5e25
            //foreach (var item in StaticStuff.magazines)
            //{
            //    if (item._type == "Node")
            //        item._props = new object();
            //}
            Save("\\db\\items\\Magazine.json", Serialiser.Serialise<List<Magazines>>(StaticStuff.magazines));
        }

        public static void SaveGameplay()
        {
            Save("\\user\\configs\\gameplay.json", Serialiser.Serialise<Gameplay>(StaticStuff.gameplay));
        }

        public static void SaveArmour()
        {
            Save("\\db\\items\\Armor.json", Serialiser.Serialise<List<Armour>>(StaticStuff.armour));
        }

        public static void SaveHelmet()
        {
            Save("\\db\\items\\Headwear.json", Serialiser.Serialise<List<Helmet>>(StaticStuff.helmet));
        }

        public static void SaveCharacter()
        {
            foreach (var character in StaticStuff.characters)
            {
                string path = "user\\profiles\\" + character.aid + "\\character.json";
                Save(path, Serialiser.Serialise<Character>(character));
            }
        }
    }
}
