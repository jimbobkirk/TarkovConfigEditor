using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkovConfigEditor.TarkovClasses
{
    public class Gameplay
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        public Autosave autosave { get; set; }
        public Inraid inraid { get; set; }
        public Other other { get; set; }
        public DefaultRaidSettings defaultRaidSettings { get; set; }
        public Hideout hideout { get; set; }
        public Bots bots { get; set; }
        public Trading trading { get; set; }
        public Location location { get; set; }
        public Locationloot locationloot { get; set; }
        public Match match { get; set; }

        public class Autosave
        {
            public bool saveOnReceive { get; set; }
            public bool saveOnExit { get; set; }
            public int saveIntervalSec { get; set; }
        }

        public class Bots
        {
            public Pmc pmc { get; set; }
            public Limits limits { get; set; }
        }

        public class Containers
        {
            public int ChanceForEmpty { get; set; }
            public int ChanceToSpawnNextItem { get; set; }
            public int AttemptsToPlaceLoot { get; set; }
        }

        public class DefaultRaidSettings
        {
            public string aiAmount { get; set; }
            public string aiDifficulty { get; set; }
            public bool bossEnabled { get; set; }
            public bool scavWars { get; set; }
            public bool taggedAndCursed { get; set; }
        }

        public class Hideout
        {
            public int productionTimeDivide_Areas { get; set; }
            public int productionTimeDivide_ScavCase { get; set; }
            public int productionTimeDivide_Production { get; set; }
        }

        public class Inraid
        {
            public bool saveLootEnabled { get; set; }
            public bool saveWeaponDurability { get; set; }
            public bool saveHealthEnabled { get; set; }
            public double saveHealthMultiplier { get; set; }
            public bool miaOnTimerEnd { get; set; }
        }

        public class Limits
        {
            public int assault { get; set; }
            public int marksman { get; set; }
            public int pmcBot { get; set; }
            public int bossBully { get; set; }
            public int bossGluhar { get; set; }
            public int bossKilla { get; set; }
            public int bossKojaniy { get; set; }
            public int bossSanitar { get; set; }
            public int followerBully { get; set; }
            public int followerGluharAssault { get; set; }
            public int followerGluharScout { get; set; }
            public int followerGluharSecurity { get; set; }
            public int followerGluharSnipe { get; set; }
            public int followerKojaniy { get; set; }
            public int followerSanitar { get; set; }
            public int test { get; set; }
            public int followerTest { get; set; }
            public int bossTest { get; set; }
        }

        public class Location
        {
            public bool realTimeEnabled { get; set; }
            public bool forceWeatherEnabled { get; set; }
            public int forceWeatherId { get; set; }
        }

        public class Locationloot
        {
            public Containers containers { get; set; }
            public RarityMultipliers RarityMultipliers { get; set; }
            public int noDuplicatesTill { get; set; }
            public bool useDynamicLootFromItemsArray { get; set; }
            public bool useDynamicLootMultiplier { get; set; }
        }

        public class Match
        {
            public bool enabled { get; set; }
        }

        public class Other
        {
            public int RedeemTime { get; set; }
        }

        public class Pmc
        {
            public bool enabled { get; set; }
            public int usecChance { get; set; }
            public Types types { get; set; }
        }

        public class RarityMultipliers
        {
            public int Not_exist { get; set; }
            public double Common { get; set; }
            public double Uncommon { get; set; }
            public double Rare { get; set; }
            public double Superrare { get; set; }
        }

        public class TraderSupply
        {
            public int _5a7c2eca46aef81a7ca2145d { get; set; }
            public int _5ac3b934156ae10c4430e83c { get; set; }
            public int _5c0647fdd443bc2504c2d371 { get; set; }
            public int _54cb50c76803fa8b248b4571 { get; set; }
            public int _54cb57776803fa99248b456e { get; set; }
            public int _579dc571d53a0658a154fbec { get; set; }
            public int _5935c25fb3acc3127c3d8cd9 { get; set; }
            public int _58330581ace78e27b8b10cee { get; set; }
        }

        public class Trading
        {
            public double ragfairMultiplier { get; set; }
            public double repairMultiplier { get; set; }
            public double insureMultiplier { get; set; }
            public int insureReturnChance { get; set; }
            public int fenceAssortSize { get; set; }
            public bool buyItemsMarkedFound { get; set; }
            public TraderSupply traderSupply { get; set; }
        }

        public class Types
        {
            public int followerTest { get; set; }
            public int bossTest { get; set; }
            public int assault { get; set; }
            public int pmcBot { get; set; }
        }
    }
}
