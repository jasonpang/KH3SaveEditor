﻿using KHSave.Lib2.Types;
using Xe.BinaryMapper;

namespace KHSave.Lib2.Models
{
    public class DriveFormFinalMix : IDriveForm
    {
        [Data(0)] public EquipmentType Weapon { get; set; }
        [Data] public byte Level { get; set; }
        [Data] public byte Unknown { get; set; }
        [Data] public int Experience { get; set; }
        [Data(Count = 0x18)] public ushort[] Abilities { get; set; }
    }
}
