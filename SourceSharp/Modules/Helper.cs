using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPSharp;

namespace SourceSharp.Modules
{
    class Helper
    {
        public static IntPtr GetSourceHandle()
        {
            var Proc = ProcessManager.GetProcess("hl2");
            return ProcessManager.GetProcessHandle(Proc);
        }

        public static int ReadPointer(int PTR)
        {
            return Reader.ReadInt(GetSourceHandle(), PTR);
        }

        public static int GetModuleAddress(string ModuleName)
        {
            var Proc = ProcessManager.GetProcess("hl2");
            IntPtr MAD = IntPtr.Zero;
            foreach (System.Diagnostics.ProcessModule Module in Proc.Modules)
            {
                if (Module.ModuleName.Contains(ModuleName))
                    MAD = Module.BaseAddress;
            }
            if (MAD != IntPtr.Zero)
            {
                return MAD.ToInt32();
            }
            else
            {
                return 0;
            }
        }
    }
}
