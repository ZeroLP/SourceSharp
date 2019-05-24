using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPSharp;

namespace SourceSharp.Modules.Hacks
{
    public static class LocalPlayer
    {
        public static class Health
        {
            public static void InfiniteHealth()
            {
                    var hPointer = Reader.ReadInt(Helper.GetSourceHandle(), OffsetManager.LocalPlayer.Health_PTR);
                    Writer.WriteBytes(Helper.GetSourceHandle(), hPointer + OffsetManager.LocalPlayer.Health, 100);
            }
            
        }
    }
}
