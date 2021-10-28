using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class LevelHero
    {
        private int _lvl;
        public int Level { get => _lvl; set => _lvl = value; }

        private int _lvlMax;

        private long _xp;
        public long XP { get => _xp; set => _xp = value; }

        private int _extraPoints;
        public int ExtraPoints { get => _extraPoints; set => _extraPoints = value; }

        private int count;

        public bool LevelUp()
        {
            var _lvlOld = _lvl;

            while (_xp >= count && _lvlMax != _lvl)
            {
                ++_lvl;
                count = count + count * 2;
                ++_extraPoints;
            }

            if(_lvl > _lvlOld && _lvlMax != _lvl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetXP(int xp)
        {
            _xp += xp;
            return LevelUp();
        }

        public LevelHero()
        {
            _lvl = 1;
            _lvlMax = 30;
            _xp = 0;
            count = 1000;
            _extraPoints = 20;
        }
    }
}
