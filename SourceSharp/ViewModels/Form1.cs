using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MPSharp;

namespace SourceSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OnActivate();
        }

        async void OnActivate()
        {
            while (true)
            {
                int Health = Modules.LocalPlayer.GetHealth();
                float PlayerX = Modules.LocalPlayer.GetPos("X");
                float PlayerY = Modules.LocalPlayer.GetPos("Y");
                float PlayerZ = Modules.LocalPlayer.GetPos("Z");

                string HealthInfo = "N/A";
                string PositionInfo = "N/A";
                string Aimbot = "N/A";
                string InfiniteHealth = "N/A";
                string InfinitePA = "N/A";
                string InfinitePM = "N/A";


                if (States.IsHealthDisplay == true)
                {
                    HealthInfo = $"{Health}";
                }
                else
                {
                    HealthInfo = "N/A";
                }

                if (States.IsPositionDisplay == true)
                {
                    PositionInfo = $"\nPos X: {PlayerX}\nPos Y: {PlayerY}\nPos Z: {PlayerZ}";
                }
                else
                {
                    PositionInfo = "N/A";
                }

                if(States.IsAimbot == true)
                {
                    Aimbot = "On";
                    Modules.Hacks.Aimbot.Start();
                }
                else
                {
                    Aimbot = "Off";
                }

                if(States.IsInfiniteHealth == true)
                {
                    InfiniteHealth = "On";
                    Modules.Hacks.LocalPlayer.Health.InfiniteHealth();
                }
                else
                {
                    InfiniteHealth = "Off";
                }

                if(States.IsInfinitePistolA == true)
                {
                    InfinitePA = "On";
                    Modules.Hacks.Weapon.Pistol.InifiniteAmmo();
                }
                else
                {
                    InfinitePA = "Off";
                }

                if(States.IsInfinitePistolM == true)
                {
                    InfinitePM = "On";
                    Modules.Hacks.Weapon.Pistol.InfiniteMag();
                }
                else
                {
                    InfinitePM = "Off";
                }

                LocalPlayerText.Text = $"Health: {HealthInfo}\nPosition: {PositionInfo}\n\nAimbot: {Aimbot}\nInfinite Health: {InfiniteHealth}\nInfinite Pistol Ammo: {InfinitePA}\nInfinite Pistol Mag: {InfinitePM}";

                await Task.Delay(100);
            }
        }

        private void DisplayHealth_CheckedChanged(object sender, EventArgs e)
        {
            if(DisplayHealth.Checked == true)
            {
                States.IsHealthDisplay = true;
            }
            else
            {
                States.IsHealthDisplay = false;
            }
        }

        private void DisplayPosition_CheckedChanged(object sender, EventArgs e)
        {
            if(DisplayPosition.Checked == true)
            {
                States.IsPositionDisplay = true;
            }
            else
            {
                States.IsPositionDisplay = false;
            }
        }

        private void InfiniteHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (InfiniteHealth.Checked == true)
            {
                States.IsInfiniteHealth = true;
            }
            else
            {
                States.IsInfiniteHealth = false;
            }
        }

        private void InfinitePistolA_CheckedChanged(object sender, EventArgs e)
        {
            if(InfinitePistolA.Checked == true)
            {
                States.IsInfinitePistolA = true;
            }
            else
            {
                States.IsInfinitePistolA = false;
            }
        }

        private void InfinitePistolM_CheckedChanged(object sender, EventArgs e)
        {
            if(InfinitePistolM.Checked == true)
            {
                States.IsInfinitePistolM = true;
            }
            else
            {
                States.IsInfinitePistolM = false;
            }
        }

        private void Aimbot_CheckedChanged(object sender, EventArgs e)
        {
            if(Aimbot.Checked == true)
            {
                States.IsAimbot = true;
            }
            else
            {
                States.IsAimbot = false;
            }
        }

        class States
        {
            public static bool IsHealthDisplay = false;
            public static bool IsPositionDisplay = false;

            public static bool IsInfiniteHealth = false;
            public static bool IsInfinitePistolA = false;
            public static bool IsInfinitePistolM = false;
            public static bool IsAimbot = false;
        }
    }
}
