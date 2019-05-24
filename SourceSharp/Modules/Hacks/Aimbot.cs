using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceSharp.Modules.Hacks
{
    public static class Aimbot
    {
        public static void Start()
        {
                    float EnemyX = Modules.Enemy.GetPos("X");
                    float EnemyY = Modules.Enemy.GetPos("Y");
                    float EnemyZ = Modules.Enemy.GetPos("Z");

                    float LocalPlayerX = Modules.LocalPlayer.GetPos("X");
                    float LocalPlayerY = Modules.LocalPlayer.GetPos("Y");
                    float LocalPlayerZ = Modules.LocalPlayer.GetPos("Z");

                    float ViewAngleX = Modules.LocalPlayer.GetAngle("X");

                    double scalemul = EnemyX - LocalPlayerX;
                    double length = Math.Sqrt(Math.Pow(EnemyX - LocalPlayerX, 2) + Math.Pow(EnemyY - LocalPlayerY, 2));
                    double result = Math.Acos(scalemul / length) * 180 / Math.PI;
                    if (EnemyY < LocalPlayerY)
                    {
                        result *= -1;
                    }
                    Modules.LocalPlayer.SetAngle((float)result);
        }
    }
}
