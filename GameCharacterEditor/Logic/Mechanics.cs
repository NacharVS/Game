using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor.Logic
{
    public static class Mechanics
    {
        public static int LevelUpLogic(int yourExp, int yourLevel)
        {
            if (yourExp <= 0 && yourExp > 1000)
                yourLevel = 1;
            else if (yourExp >= 1000 && yourExp < 3000)
                yourLevel = 2;
            else if (yourExp >= 3000 && yourExp < 6000)
                yourLevel = 3;
            else if (yourExp >= 6000 && yourExp < 10000)
                yourLevel = 4;
            else if (yourExp >= 10000 && yourExp < 15000)
                yourLevel = 5;
            else if (yourExp >= 15000 && yourExp < 21000)
                yourLevel = 6;
            else if (yourExp >= 21000 && yourExp < 28000)
                yourLevel = 7;
            else if (yourExp >= 28000 && yourExp < 36000)
                yourLevel = 8;
            else if (yourExp >= 36000 && yourExp < 45000)
                yourLevel = 9;
            else if (yourExp >= 45000)
                yourLevel = 10;

            return yourLevel;
        }
    }
}
