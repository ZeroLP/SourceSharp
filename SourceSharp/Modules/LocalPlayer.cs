using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPSharp;

namespace SourceSharp.Modules
{
    public static class LocalPlayer
    {
        public static float GetPos(string Axis)
        {
            if(Axis == "X")
            {
                var X_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.LocalPlayer.PosX_PTR);
                var X_Offset1 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), X_PTR + OffsetManager.LocalPlayer.PosX[0]);
                var X_Offset2 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), X_Offset1 + OffsetManager.LocalPlayer.PosX[1]);
                var X_Offset3 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), X_Offset2 + OffsetManager.LocalPlayer.PosX[2]);
                var X_Offset4 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), X_Offset3 + OffsetManager.LocalPlayer.PosX[3]);
                var X_Pos = Reader.ReadFloat(Modules.Helper.GetSourceHandle(), X_Offset4 + OffsetManager.LocalPlayer.PosX[4]);
                return X_Pos;
            }

            if(Axis == "Y")
            {
                var Y_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.LocalPlayer.PosY_PTR);
                var Y_Offset1 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Y_PTR + OffsetManager.LocalPlayer.PosY[0]);
                var Y_Offset2 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Y_Offset1 + OffsetManager.LocalPlayer.PosY[1]);
                var Y_Offset3 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Y_Offset2 + OffsetManager.LocalPlayer.PosY[2]);
                var Y_Offset4 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Y_Offset3 + OffsetManager.LocalPlayer.PosY[3]);
                var Y_Pos = Reader.ReadFloat(Modules.Helper.GetSourceHandle(), Y_Offset4 + OffsetManager.LocalPlayer.PosY[4]);
                return Y_Pos;
            }

            if(Axis == "Z")
            {
                var Z_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.LocalPlayer.PosZ_PTR);
                var Z_Offset1 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Z_PTR + OffsetManager.LocalPlayer.PosZ[0]);
                var Z_Offset2 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Z_Offset1 + OffsetManager.LocalPlayer.PosZ[1]);
                var Z_Offset3 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Z_Offset2 + OffsetManager.LocalPlayer.PosZ[2]);
                var Z_Offset4 = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Z_Offset3 + OffsetManager.LocalPlayer.PosZ[3]);
                var Z_Pos = Reader.ReadInt(Modules.Helper.GetSourceHandle(), Z_Offset4 + OffsetManager.LocalPlayer.PosZ[4]);
                return Z_Pos;
            }

            else
            {
                return (float)0.0;
            }
        }

        public static int GetHealth()
        {
            var H_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.LocalPlayer.Health_PTR);
            var Health = Reader.ReadInt(Modules.Helper.GetSourceHandle(), H_PTR + OffsetManager.LocalPlayer.Health);
            return Health;
        }

        public static float GetAngle(string Axis)
        {
            if(Axis == "X")
            {
                var ViewAngleX_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.LocalPlayer.ViewAngleX_PTR);
                var ViewAngleX = Reader.ReadFloat(Modules.Helper.GetSourceHandle(), ViewAngleX_PTR + OffsetManager.LocalPlayer.ViewAngleX);
                return ViewAngleX;
            }

            else
            {
                return (float)0.0;
            }
        }

        public static void SetAngle(float Angle)
        {
            var ViewAngleX_PTR = Reader.ReadInt(Modules.Helper.GetSourceHandle(), OffsetManager.LocalPlayer.ViewAngleX_PTR);
            int ViewAngleX_Address = ViewAngleX_PTR + OffsetManager.LocalPlayer.ViewAngleX;
            IntPtr written = IntPtr.Zero;
            MPSharp.Writer.WriteProcessMemory(Modules.Helper.GetSourceHandle(), (IntPtr)ViewAngleX_Address, BitConverter.GetBytes(Angle), 4, out written);

        }
    }
}
