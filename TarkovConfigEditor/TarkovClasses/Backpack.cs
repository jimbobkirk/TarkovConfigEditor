﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkovConfigEditor.TarkovClasses
{
    public class Backpack
    {
        public string _id { get; set; }
        public string _name { get; set; }
        public string _parent { get; set; }
        public string _type { get; set; }
        public Props _props { get; set; }
        public string _proto { get; set; }
        public override string ToString()
        {
            return _name + " (" + _props.Name + ")";
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public class Filters
        {
            public List<string> Filter { get; set; }
            public List<string> ExcludedFilter { get; set; }
        }

        public class Grid
        {
            public string _name { get; set; }
            public string _id { get; set; }
            public string _parent { get; set; }
            public Props _props { get; set; }
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
            public Prefab Prefab { get; set; }
            public UsePrefab UsePrefab { get; set; }
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
            public List<object> ConflictingItems { get; set; }
            public bool Unlootable { get; set; }
            public string UnlootableFromSlot { get; set; }
            public List<object> UnlootableFromSide { get; set; }
            public int AnimationVariantsNumber { get; set; }
            public bool DiscardingBlock { get; set; }
            public int RagFairCommissionModifier { get; set; }
            public bool IsAlwaysAvailableForInsurance { get; set; }
            public List<Grid> Grids { get; set; }
            public List<object> Slots { get; set; }
            public bool CanPutIntoDuringTheRaid { get; set; }
            public List<object> CantRemoveFromSlotsDuringRaid { get; set; }
            public string SearchSound { get; set; }
            public bool BlocksArmorVest { get; set; }
            public int speedPenaltyPercent { get; set; }
            public string GridLayoutName { get; set; }
            public int? TagColor { get; set; }
            public string TagName { get; set; }
            public List<Filters> filters { get; set; }
            public int cellsH { get; set; }
            public int cellsV { get; set; }
            public int minCount { get; set; }
            public int maxCount { get; set; }
            public int maxWeight { get; set; }
            public bool isSortingTable { get; set; }
        }

        public class UsePrefab
        {
            public string path { get; set; }
            public string rcid { get; set; }
        }


    }
}
