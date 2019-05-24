using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceSharp.Modules;

namespace SourceSharp.Modules
{
    public static class OffsetManager
    {
        public static class LocalPlayer
        {
            public static int Health_PTR = Helper.GetModuleAddress("server.dll") + 0x562D7C;
            public static int Health = 0x88;

            public static int PosX_PTR = Helper.GetModuleAddress("server.dll") + 0x577510;
            public static int[] PosX = { 0x1C, 0x98, 0x31C, 0x22C, 0x298 };

            public static int PosY_PTR = Helper.GetModuleAddress("server.dll") + 0x577510;
            public static int[] PosY = { 0x08, 0x98, 0x08, 0x20, 0x294 };

            public static int PosZ_PTR = Helper.GetModuleAddress("server.dll") + 0x577510;
            public static int[] PosZ = { 0x1C, 0x320, 0x22C, 0xF0, 0x29C };

            public static int ViewAngleX_PTR = Helper.GetModuleAddress("engine.dll") + 0x03F504;
            public static int ViewAngleX = 0x74;

        }


        public static class Enemy
        {
            public static int Enemy_PTR = Helper.GetModuleAddress("server.dll") + 0x562D8C;
            public static int Health = 0x88;

            public static int PosX_PTR = Helper.GetModuleAddress("server.dll") + 0x5D9938;
            public static int[] PosX = { 0x14, 0x10C, 0x170, 0x1C, 0x150 };

            public static int PosY_PTR = Helper.GetModuleAddress("server.dll") + 0x5A4228;
            public static int PosY = 0x294;

            public static int PosZ_PTR = Helper.GetModuleAddress("server.dll") + 0x5A4228;
            public static int PosZ = 0x29C;
        }

        public static class Weapon
        {
            public static class Pistol
            {
                public static int PistolAmmo_PTR = Helper.GetModuleAddress("server.dll") + 0x54FF40;
                public static int[] PistolAmmo = { 0x08, 0x150, 0x4B4 };

                public static int PistolMag_PTR = Helper.GetModuleAddress("server.dll") + 0x562D7C;
                public static int PistolMag = 0x648;
            }
        }
    }
}
