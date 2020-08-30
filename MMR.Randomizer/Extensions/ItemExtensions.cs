﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMR.Randomizer.Attributes;
using MMR.Randomizer.GameObjects;
using MMR.Common.Extensions;
using MMR.Randomizer.Attributes.Entrance;
using System.Text.RegularExpressions;
using MMR.Randomizer.Models.Settings;
using MMR.Randomizer.Utils;

namespace MMR.Randomizer.Extensions
{
    public static class ItemExtensions
    {
        public static int? GetItemIndex(this Item item)
        {
            return item.GetAttribute<GetItemIndexAttribute>()?.Index;
        }

        public static int[] GetBottleItemIndices(this Item item)
        {
            return item.GetAttribute<GetBottleItemIndicesAttribute>()?.Indices;
        }

        public static string Name(this Item item)
        {
            return item.GetAttribute<ItemNameAttribute>()?.Name;
        }

        private static Regex entranceLocationNameRegex = new Regex("Entrance(.+)From(.+)");
        public static string Location(this Item item)
        {
            var locationName = item.GetAttribute<LocationNameAttribute>()?.Name;

            if (locationName != null)
            {
                return locationName;
            }

            locationName = item.ToString();

            if (item.IsEntrance())
            {
                var match = entranceLocationNameRegex.Match(locationName);
                if (match.Success)
                {
                    locationName = $"Exit{match.Groups[2]}To{match.Groups[1]}";
                }
            }

            return locationName;
        }

        public static Region? Region(this Item item)
        {
            return item.GetAttribute<RegionAttribute>()?.Region;
        }

        public static string Entrance(this Item item)
        {
            return item.GetAttribute<EntranceNameAttribute>()?.Name;
        }

        public static ShopTextAttribute ShopTexts(this Item item)
        {
            return item.GetAttribute<ShopTextAttribute>();
        }

        public static string[] ItemHints(this Item item)
        {
            return item.GetAttribute<GossipItemHintAttribute>().Values;
        }

        public static string[] LocationHints(this Item item)
        {
            return item.GetAttribute<GossipLocationHintAttribute>().Values;
        }

        public static bool IsRepeatable(this Item item)
        {
            return item.HasAttribute<RepeatableAttribute>();
        }

        public static bool IsCycleRepeatable(this Item item)
        {
            return item.HasAttribute<CycleRepeatableAttribute>();
        }

        public static bool IsRupeeRepeatable(this Item item)
        {
            return item.HasAttribute<RupeeRepeatableAttribute>();
        }

        public static bool IsDowngradable(this Item item)
        {
            return item.HasAttribute<DowngradableAttribute>();
        }

        public static bool IsTemporary(this Item item)
        {
            return item.HasAttribute<TemporaryAttribute>();
        }

        public static bool IsFake(this Item item)
        {
            return item.Name() == null && !item.IsEntrance();
        }

        public static bool IsEntrance(this Item item)
        {
            return item.HasAttribute<EntranceAttribute>();
        }

        public static EntranceType? Type(this Item entrance)
        {
            return entrance.GetAttribute<EntranceAttribute>().Type;
        }

        public static Item? Pair(this Item entrance)
        {
            return entrance.GetAttribute<PairAttribute>()?.Pair;
        }

        public static ushort SpawnId(this Item entrance)
        {
            return entrance.GetAttribute<SpawnAttribute>().SpawnId;
        }

        public static IEnumerable<Tuple<int, byte>> ExitIndices(this Item entrance)
        {
            return entrance.GetAttributes<ExitAttribute>().Select(ea => new Tuple<int, byte>(ea.SceneId, ea.ExitIndex));
        }

        public static IEnumerable<Tuple<int, byte, byte>> ExitCutscenes(this Item entrance)
        {
            return entrance.GetAttributes<ExitCutsceneAttribute>().Select(eca => new Tuple<int, byte, byte>(eca.SceneId, eca.SetupIndex, eca.CutsceneIndex));
        }

        public static IEnumerable<int> ExitAddresses(this Item entrance)
        {
            return entrance.GetAttributes<ExitAddressAttribute>().Select(eaa => eaa.Address);
        }

        public static bool IsEntranceImplemented(this Item entrance)
        {
            return entrance.HasAttribute<SpawnAttribute>() && 
                (entrance.HasAttribute<ExitAttribute>() 
                || entrance.HasAttribute<ExitAddressAttribute>() 
                || entrance.HasAttribute<ExitCutsceneAttribute>()
                );
        }

        public static bool IsOverwritable(this Item item)
        {
            return item.HasAttribute<OverwritableAttribute>();
        }

        public static bool IsBottleCatchContent(this Item item)
        {
            return item >= Item.BottleCatchFairy
                   && item <= Item.BottleCatchMushroom;
        }

        public static bool IsSameType(this Item item, Item other)
        {
            return item.IsEntrance() == other.IsEntrance()
                && item.IsBottleCatchContent() == other.IsBottleCatchContent();
        }

        public static ItemType GetItemType(this Item item, GameplaySettings settings)
        {
            if (item.IsEntrance())
            {
                if (!settings.DecoupleEntrances && !item.Pair().HasValue)
                {
                    return ItemType.OneWayEntrance;
                }
                return ItemType.Entrance;
            }
            if (item.IsBottleCatchContent())
            {
                return ItemType.Scoop;
            }
            if (ItemUtils.IsSong(item) && !settings.AddSongs)
            {
                return ItemType.Song;
            }
            return ItemType.Item;
        }
    }

    public enum ItemType
    {
        Item,
        Song,
        Scoop,
        Entrance,
        OneWayEntrance,
    }
}
