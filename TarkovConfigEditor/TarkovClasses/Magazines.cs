using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkovConfigEditor.TarkovClasses
{
    public class Magazines
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);

        public override string ToString()
        {
            return _name;
        }

        public string _id { get; set; }
        public string _name { get; set; }
        public string _parent { get; set; }
        public string _type { get; set; }
        public object _props { get; set; }
        public string _proto { get; set; }

        public class Cartridge
        {
            public string _name { get; set; }
            public string _id { get; set; }
            public string _parent { get; set; }
            public int _max_count { get; set; }
            public object _props { get; set; }
            public string _proto { get; set; }
        }

        public class Prefab
        {
            public string path { get; set; }
            public string rcid { get; set; }
        }

        public class Props
        {
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string Description { get; set; }
            public double Weight { get; set; }
            public string BackgroundColor { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int StackMaxSize { get; set; }
            public string ItemSound { get; set; }
            public object Prefab { get; set; }
            public object UsePrefab { get; set; }
            public int StackObjectsCount { get; set; }
            public bool NotShownInSlot { get; set; }
            public bool ExaminedByDefault { get; set; }
            public int ExamineTime { get; set; }
            public bool IsUndiscardable { get; set; }
            public bool IsUnsaleable { get; set; }
            public bool IsUnbuyable { get; set; }
            public bool IsUngivable { get; set; }
            public bool IsLockedafterEquip { get; set; }
            public bool QuestItem { get; set; }
            public int LootExperience { get; set; }
            public int ExamineExperience { get; set; }
            public bool HideEntrails { get; set; }
            public int RepairCost { get; set; }
            public int RepairSpeed { get; set; }
            public int ExtraSizeLeft { get; set; }
            public int ExtraSizeRight { get; set; }
            public int ExtraSizeUp { get; set; }
            public int ExtraSizeDown { get; set; }
            public bool ExtraSizeForceAdd { get; set; }
            public bool MergesWithChildren { get; set; }
            public bool CanSellOnRagfair { get; set; }
            public bool CanRequireOnRagfair { get; set; }
            public List<string> ConflictingItems { get; set; }
            public bool Unlootable { get; set; }
            public string UnlootableFromSlot { get; set; }
            public List<object> UnlootableFromSide { get; set; }
            public int AnimationVariantsNumber { get; set; }
            public bool DiscardingBlock { get; set; }
            public int RagFairCommissionModifier { get; set; }
            public bool IsAlwaysAvailableForInsurance { get; set; }
            public List<object> Grids { get; set; }
            public List<object> Slots { get; set; }
            public bool CanPutIntoDuringTheRaid { get; set; }
            public List<object> CantRemoveFromSlotsDuringRaid { get; set; }
            public int Durability { get; set; }
            public double Accuracy { get; set; }
            public double Recoil { get; set; }
            public int Loudness { get; set; }
            public int EffectiveDistance { get; set; }
            public double Ergonomics { get; set; }
            public int Velocity { get; set; }
            public bool RaidModdable { get; set; }
            public bool ToolModdable { get; set; }
            public bool BlocksFolding { get; set; }
            public bool BlocksCollapsible { get; set; }
            public bool IsAnimated { get; set; }
            public bool HasShoulderContact { get; set; }
            public int SightingRange { get; set; }
            public int DoubleActionAccuracyPenaltyMult { get; set; }
            public int magAnimationIndex { get; set; }
            public List<Cartridge> Cartridges { get; set; }
            public bool CanFast { get; set; }
            public bool CanHit { get; set; }
            public bool CanAdmin { get; set; }
            public int LoadUnloadModifier { get; set; }
            public int CheckTimeModifier { get; set; }
            public int CheckOverride { get; set; }
            public string ReloadMagType { get; set; }
            public string VisibleAmmoRangesString { get; set; }
            public double MalfunctionChance { get; set; }
            public int TagColor { get; set; }
            public string TagName { get; set; }
            public List<object> filters { get; set; }
        }

        public class UsePrefab
        {
            public string path { get; set; }
            public string rcid { get; set; }
        }


    }
}
