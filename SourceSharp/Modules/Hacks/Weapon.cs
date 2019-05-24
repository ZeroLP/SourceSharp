using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPSharp;
using SourceSharp.Modules;

namespace SourceSharp.Modules.Hacks
{
    public static class Weapon
    {
        public static class Pistol
        {
            public static void InifiniteAmmo()
            {
                var pPointer = Reader.ReadInt(Helper.GetSourceHandle(),  OffsetManager.Weapon.Pistol.PistolAmmo_PTR);
                var Offset1 = Reader.ReadInt(Helper.GetSourceHandle(), pPointer + OffsetManager.Weapon.Pistol.PistolAmmo[0]);
                var offset2 = Reader.ReadInt(Helper.GetSourceHandle(), Offset1 + OffsetManager.Weapon.Pistol.PistolAmmo[1]);
                var offset3 = Reader.ReadInt(Helper.GetSourceHandle(), offset2 + OffsetManager.Weapon.Pistol.PistolAmmo[2]);
                Writer.WriteBytes(Helper.GetSourceHandle(), offset2 + OffsetManager.Weapon.Pistol.PistolAmmo[2], 10);
            }
            public static void InfiniteMag()
            {
                var pmPointer = Reader.ReadInt(Helper.GetSourceHandle(), OffsetManager.Weapon.Pistol.PistolMag_PTR);
                Writer.WriteBytes(Helper.GetSourceHandle(), pmPointer + OffsetManager.Weapon.Pistol.PistolMag, 100);
            }
        }
    }
}
