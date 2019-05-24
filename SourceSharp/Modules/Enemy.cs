using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPSharp;

namespace SourceSharp.Modules
{
    public static class Enemy
    {
        public static float GetPos(string Axis)
        {
            if (Axis == "X")
            {
                var X_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.Enemy.PosX_PTR);
                var X_Offset1 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), X_PTR + OffsetManager.Enemy.PosX[0]);
                var X_Offset2 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), X_Offset1 + OffsetManager.Enemy.PosX[1]);
                var X_Offset3 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), X_Offset2 + OffsetManager.Enemy.PosX[2]);
                var X_Offset4 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), X_Offset3 + OffsetManager.Enemy.PosX[3]);
                var X_Pos = Reader.ReadFloat(Modules.Helper.GetSourceHandle(), X_Offset4 + OffsetManager.Enemy.PosX[4]);
                return X_Pos;
            }

            if (Axis == "Y")
            {
                var Y_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.Enemy.PosY_PTR);
                var Y_Pos = Reader.ReadFloat(Modules.Helper.GetSourceHandle(), Y_PTR + OffsetManager.Enemy.PosY);
                return Y_Pos;
            }

            if (Axis == "Z")
            {
                var Z_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.Enemy.PosZ_PTR);
                var Z_Pos = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Z_PTR + OffsetManager.Enemy.PosZ);
                return Z_Pos;
            }

            else
            {
                return (float)0.0;
            }
        }

        public static int GetHealth()
        {
            var H_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.Enemy.Enemy_PTR);
            var Health = Reader.ReadInt(Modules.Helper.GetSourceHandle(), H_PTR + OffsetManager.Enemy.Health);
            return Health;
        }
    }
}
