﻿using Be.IO;
using MMR.Common.Extensions;
using System.IO;
using System.Linq;

namespace MMR.Randomizer.Asm
{
    /// <summary>
    /// D-Pad item value.
    /// </summary>
    public enum DPadValue : byte
    {
        Ocarina = 0x00,
        DekuMask = 0x32,
        GoronMask = 0x33,
        ZoraMask = 0x34,
        BunnyHood = 0x39,
        None = 0xFF,
    }

    /// <summary>
    /// Category of a <see cref="DPadValue"/>.
    /// </summary>
    public enum DPadCategory
    {
        None,
        Ocarina,
        TransformationMasks,
        NormalMasks,
    }

    /// <summary>
    /// D-Pad state.
    /// </summary>
    public enum DPadState : byte
    {
        Disabled,
        Enabled,
        Defaults,
    }

    /// <summary>
    /// D-Pad display type.
    /// </summary>
    public enum DPadDisplay : byte
    {
        None,
        Left,
        Right,
    }

    /// <summary>
    /// D-Pad configuration structure.
    /// </summary>
    public struct DPadConfigStruct : IAsmConfigStruct
    {
        public uint Version;
        public byte[] Items;
        public byte State;
        public byte Display;

        /// <summary>
        /// Convert to bytes.
        /// </summary>
        /// <returns>Bytes</returns>
        public byte[] ToBytes()
        {
            using (var memStream = new MemoryStream())
            using (var writer = new BeBinaryWriter(memStream))
            {
                writer.WriteUInt32(this.Version);

                // Version 0
                writer.WriteBytes(this.Items);
                writer.WriteByte(this.State);
                writer.WriteByte(this.Display);

                return memStream.ToArray();
            }
        }
    }

    /// <summary>
    /// Container for all D-Pad configuration variables.
    /// </summary>
    public class DPadConfig : AsmConfig
    {
        /// <summary>
        /// D-Pad values.
        /// </summary>
        public DPad Pad { get; set; }

        /// <summary>
        /// State of the D-Pad.
        /// </summary>
        public DPadState State { get; set; }

        /// <summary>
        /// Where the D-Pad displays on-screen.
        /// </summary>
        public DPadDisplay Display { get; set; }

        public DPadConfig()
            : this(DPad.Default, DPadState.Enabled, DPadDisplay.Left)
        {
        }

        public DPadConfig(DPad pad, DPadState state, DPadDisplay display)
        {
            this.Pad = pad;
            this.State = state;
            this.Display = display;
        }

        /// <summary>
        /// Get which D-Pad directions are in use.
        /// </summary>
        public bool[] InUse()
        {
            if (this.State == DPadState.Disabled)
            {
                return this.Pad.Values.Select(x => false).ToArray();
            }
            else
            {
                return this.Pad.Values.Select(x => x != DPadValue.None).ToArray();
            }
        }

        /// <summary>
        /// Get a <see cref="DPadConfigStruct"/> representation which can be converted to bytes.
        /// </summary>
        /// <param name="version">Structure version</param>
        /// <returns>Configuration structure</returns>
        public override IAsmConfigStruct ToStruct(uint version)
        {
            var items = new byte[0x10];
            this.Pad.Bytes.CopyTo(items, 0);

            return new DPadConfigStruct
            {
                Version = version,
                Items = items,
                State = (byte)this.State,
                Display = (byte)this.Display,
            };
        }
    }

    /// <summary>
    /// Named <see cref="DPadValue"/> with a category.
    /// </summary>
    public class DPadItem
    {
        /// <summary>
        /// Value.
        /// </summary>
        public DPadValue Value { get; }

        /// <summary>
        /// Category.
        /// </summary>
        public DPadCategory Category { get; }

        /// <summary>
        /// Item name.
        /// </summary>
        public string Name { get; }

        public DPadItem(DPadValue value, DPadCategory category, string name)
        {
            this.Value = value;
            this.Category = category;
            this.Name = name;
        }

        /// <summary>
        /// Get all supported items.
        /// </summary>
        /// <returns>Items</returns>
        public static DPadItem[] All()
        {
            return new DPadItem[]
            {
                new DPadItem(DPadValue.None, DPadCategory.None, "None"),
                new DPadItem(DPadValue.Ocarina, DPadCategory.Ocarina, "Ocarina"),
                new DPadItem(DPadValue.DekuMask, DPadCategory.TransformationMasks, "Deku Mask"),
                new DPadItem(DPadValue.GoronMask, DPadCategory.TransformationMasks, "Goron Mask"),
                new DPadItem(DPadValue.ZoraMask, DPadCategory.TransformationMasks, "Zora Mask"),
                new DPadItem(DPadValue.BunnyHood, DPadCategory.NormalMasks, "Bunny Hood"),
            };
        }

        /// <summary>
        /// Check if equal using the <see cref="DPadValue"/>.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is DPadItem)
                // For simplicity, only check value
                return this.Value == ((DPadItem)obj).Value;
            else
                return false;
        }

        /// <summary>
        /// Get the corresponding <see cref="DPadItem"/> given a <see cref="DPadValue"/>.
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns>Item</returns>
        public static DPadItem From(DPadValue value)
        {
            var all = All();
            foreach (var item in all)
                if (item.Value == value)
                    return item;
            return null;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Get the item name.
        /// </summary>
        /// <returns>Name</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// Named preset for <see cref="DPad"/> values.
    /// </summary>
    public class DPadPreset
    {
        /// <summary>
        /// DPad values.
        /// </summary>
        public DPad Pad { get; }

        /// <summary>
        /// Preset name.
        /// </summary>
        public string Name { get; }

        public DPadPreset(DPad pad, string name)
        {
            this.Pad = pad;
            this.Name = name;
        }

        /// <summary>
        /// Default preset, utilizing the ocarina and main transformation masks.
        /// </summary>
        public static DPadPreset Default => new DPadPreset(DPad.Default, "Default");

        /// <summary>
        /// Virtual console preset ("up" not accessible), utilizing the main transformation masks.
        /// </summary>
        public static DPadPreset VirtualConsole => new DPadPreset(DPad.VirtualConsole, "Virtual Console");

        /// <summary>
        /// Get all presets.
        /// </summary>
        /// <returns>Presets</returns>
        public static DPadPreset[] All()
        {
            return new DPadPreset[]
            {
                DPadPreset.Default,
                DPadPreset.VirtualConsole,
            };
        }

        /// <summary>
        /// Get the preset name.
        /// </summary>
        /// <returns>Name</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// D-Pad values.
    /// </summary>
    public struct DPad
    {
        /// <summary>
        /// Byte representation.
        /// </summary>
        public byte[] Bytes => Values.Select(x => (byte)x).ToArray();

        /// <summary>
        /// Values.
        /// </summary>
        public DPadValue[] Values { get; set; }

        /// <summary>
        /// Default preset values.
        /// </summary>
        public static DPad Default => new DPad(DPadValue.DekuMask, DPadValue.ZoraMask, DPadValue.Ocarina, DPadValue.GoronMask);

        /// <summary>
        /// Virtual console preset values.
        /// </summary>
        public static DPad VirtualConsole => new DPad(DPadValue.None, DPadValue.ZoraMask, DPadValue.GoronMask, DPadValue.DekuMask);

        public DPad(DPadValue up, DPadValue right, DPadValue down, DPadValue left)
        {
            Values = new DPadValue[] { up, right, down, left };
        }

        public DPad(DPadValue[] values)
            : this(values[0], values[1], values[2], values[3])
        {
        }

        /// <summary>
        /// Check if equal using the <see cref="DPadValue"/> values.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is DPad)
                return Values.SequenceEqual(((DPad)obj).Values);
            else
                return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
