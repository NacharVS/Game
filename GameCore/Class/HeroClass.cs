using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Class
{
    public class HeroClass
    {
        protected LevelHero _level;
        public int Level
        {
            get => _level.Level;
            set
            {
                _level.Level = value;
            }
        }
        public long XP
        {
            get => _level.XP;
            set
            {
                _level.XP = value;
            }
        }

        protected string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        protected int _hp;
        public int HP
        {
            get => _hp;
            set
            {
                _hp = value;
            }
        }

        protected int _mana;
        public int Mana
        {
            get => _mana;
            set
            {
                _mana = value;
            }
        }

        protected int coins;
        public int Coins
        {
            get => coins;
            set
            {
                coins = value;
            }
        }

        protected int _strength;
        public int Strength
        {
            get => _strength;
            set
            {
                _strength = value;
            }
        }

        protected int _dexterity;
        public int Dexterity
        {
            get => _strength;
            set
            {
                _strength = value;
            }
        }

        protected int _intellect;
        public int Intellect
        {
            get => _intellect;
            set
            {
                _intellect = value;
            }
        }

        protected int _constitution;
        public int Constitution
        {
            get => _constitution;
            set
            {
                _constitution = value;
            }
        }

        protected int strengthMin;
        public int StrengthMin
        {
            get => strengthMin;
            set
            {
                strengthMin = value;
            }
        }

        protected int dexterityMin;
        public int DexterityMin
        {
            get => dexterityMin;
            set
            {
                dexterityMin = value;
            }
        }

        protected int intellectMin;
        public int IntellectMin
        {
            get => intellectMin;
            set
            {
                intellectMin = value;
            }
        }

        protected int constitutionMin;
        public int ConstitutionMin
        {
            get => constitutionMin;
            set
            {
                constitutionMin = value;
            }
        }

        protected int strengthMax;
        public int StrengthMax
        {
            get => strengthMin;
            set
            {
                strengthMin = value;
            }
        }

        protected int dexterityMax;
        public int DexterityMax
        {
            get => dexterityMin;
            set
            {
                dexterityMin = value;
            }
        }

        protected int intellectMax;
        public int IntellectMax
        {
            get => intellectMin;
            set
            {
                intellectMin = value;
            }
        }

        protected int constitutionMax;
        public int ConstitutionMax
        {
            get => constitutionMin;
            set
            {
                constitutionMin = value;
            }
        }

        protected int attack;
        public int Attack
        {
            get => attack;
            set
            {
                attack = value;
            }
        }

        protected int spAttack;
        public int SpAttack
        {
            get => spAttack;
            set
            {
                spAttack = value;
            }
        }

        protected int defense;
        public int Defense
        {
            get => defense;
            set
            {
                defense = value;
            }
        }

        protected int spDefense;
        public int SpDefense
        {
            get => spDefense;
            set
            {
                spDefense = value;
            }
        }

        protected int speed;
        public int Speed
        {
            get => speed;
            set
            {
                speed = value;
            }
        }

        public virtual void GetStats()
        {
            Attack = Attack + Strength * 2;
            SpAttack = SpAttack + Intellect * 2;
            Defense = Defense + Constitution * 2;
            SpDefense = SpDefense + Intellect * 2;
            Speed = Speed + Dexterity * 2;
        }

        public virtual void GetXP(int xp)
        {
            var lvlOld = _level.Level;
            if (_level.GetXP(xp))
            {
                for(int i = lvlOld; i < _level.Level; i++)
                {
                    HP += 10;
                    Mana += 10;
                }  
            }
        }

        public HeroClass(string name)
        {
            _name = name;

            _hp = _mana = 20;

            _level = new LevelHero();

            _strength = _dexterity = _intellect = _constitution = 10;

            coins = 100;
        }

        public HeroClass(string name, int strength, int dexterity, int intellect, int constitution)
        {
            _name = name;

            _hp = _mana = 20;

            _level = new LevelHero();

            _strength = strength;
            _dexterity = dexterity;
            _intellect = intellect;
            _constitution = constitution;

            coins = 100;
        }
    }
}
