using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Class
{
    public class HeroClass
    {

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

        protected int lvl;

        public int LVL
        {
            get => lvl;
            set
            {
                lvl = value;
            }
        }

        protected int lvlMax;
        protected int _extraPoints;

        public int ExtraPoints
        {
            get => _extraPoints;
            set
            {
                _extraPoints = value;
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

        protected int strength;

        public int Strength
        {
            get => strength;
            set
            {
                strength = value;
            }
        }

        protected int dexterity;

        public int Dexterity
        {
            get => dexterity;
            set
            {
                dexterity = value;
            }
        }

        protected int intellect;

        public int Intellect
        {
            get => intellect;
            set
            {
                intellect = value;
            }
        }

        protected int constitution;

        public int Constitution
        {
            get => constitution;
            set
            {
                constitution = value;
            }
        }

        protected int _strengthMax;

        public int StrengthMax
        {
            get => _strengthMax;
            set
            {
                _strengthMax = value;
            }
        }

        protected int _dexterityMax;

        public int DexterityMax
        {
            get => _dexterityMax;
            set
            {
                _dexterityMax = value;
            }
        }

        protected int _intellectMax;

        public int IntellectMax
        {
            get => _intellectMax;
            set
            {
                _intellectMax = value;
            }
        }

        protected int _constitutionMax;

        public int ConstitutionMax
        {
            get => _constitutionMax;
            set
            {
                _constitutionMax = value;
            }
        }


        public int StrengthMin { private set; get; }
        public int DexterityMin { private set; get; }
        public int IntellectMin { private set; get; }
        public int ConstitutionMin { private set; get; }

        protected int attack { get; }
        protected int spAttack { get; }
        protected int defense { get; }
        protected int spDefense { get; }
        protected int speed { get; }

        public virtual void LevelUp()
        {
            if(lvl < lvlMax)
            {
                ++lvl;
                ++ExtraPoints;

                _hp += 3;
                _mana += 2;
            }
        }

        public int TakeDamage(int damage)
        {
            if(HP > 0)
            {
                HP -= damage;
                if(CheckDeath() == false)
                { }
            }
            return HP;
        }

        public bool CheckDeath()
        {
            if(HP < 0)
            {
                HP = 0;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public HeroClass(string name)
        {
            _name = name;

            _hp = _mana = 20;

            lvl = 1;
            lvlMax = 30;
            _extraPoints = 10;

            strength = dexterity = intellect = constitution = 10;

            StrengthMax = DexterityMax = IntellectMax = ConstitutionMax = 100;
            StrengthMin = DexterityMin = IntellectMin = ConstitutionMin = 10;

            coins = 100;
        }

        public HeroClass(string name, int strength, int dexterity, int intellect, int constitution)
        {
            _name = name;

            _hp = _mana = 20;

            lvl = 1;
            lvlMax = 30;
            _extraPoints = 20;

            this.strength = strength;
            this.dexterity = dexterity;
            this.intellect = intellect;
            this.constitution = constitution;

            StrengthMax = DexterityMax = IntellectMax = ConstitutionMax = 100;
            StrengthMin = DexterityMin = IntellectMin = ConstitutionMin = 10;

            coins = 100;
        }
    }
}
