using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPSharp;

namespace SourceSharp.Modules.Hacks
{
    public static class Enemy
    { 
        public static void OneShotKill()
        {
            var hPointer = Reader.ReadInt(Helper.GetSourceHandle(), OffsetManager.Enemy.Enemy_PTR);
            Writer.WriteBytes(Helper.GetSourceHandle(), hPointer + OffsetManager.Enemy.Health, 1);
        }
    }
}
