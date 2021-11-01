using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    enum WeaponCategory
    {
        OneHanded,
        TwoHanded,
        Bows,
        MagicStick,
    }
    class Weapon : Item
    {
        protected double min = 0;
        protected double max = 0;
        protected double wD = 0;
        protected WeaponCategory category = WeaponCategory.OneHanded;

        public Weapon(Unit unit)
        {
            pDamage = wD + (wD * (0.5 * unit.Strength) + wD * (0.5 * unit.Dexterity));
            mDamage = wD + (wD * (0.3 * unit.Intelegence));
        }

        protected void GetMinMaxValue()
        {
            switch (category)
            {
                case WeaponCategory.OneHanded:
                    min = 1;
                    max = 2.5;
                    break;
                case WeaponCategory.TwoHanded:
                    min = 1.5;
                    max = 4.5;
                    break;
                case WeaponCategory.Bows:
                    min = 0.5;
                    max = 3;
                    break;
                case WeaponCategory.MagicStick:
                    min = 1.5;
                    max = 1.5;
                    break;
            }
        }
    }

    class Sword : Weapon
    {
        public Sword(int state, Unit unit) : base(unit)
        {
            if (state == 0)
                category = WeaponCategory.OneHanded;
            else if (state == 1)
                category = WeaponCategory.TwoHanded;

            GetMinMaxValue();
        }
    }


    class Axe : Weapon
    {
        public Axe(int state, Unit unit) : base(unit)
        {
            if (state == 0)
                category = WeaponCategory.OneHanded;
            else if (state == 1)
                category = WeaponCategory.TwoHanded;

            GetMinMaxValue();
        }
    }

    class Bow : Weapon
    {
        public Bow(Unit unit) : base(unit)
        {
            category = WeaponCategory.Bows;
            GetMinMaxValue();
        }
    }

    class MagicStick : Weapon
    {
        public MagicStick(Unit unit) : base(unit)
        {
            category = WeaponCategory.MagicStick;
            GetMinMaxValue();
        }
    }

    class Dagger : Weapon
    {
        public Dagger(Unit unit) : base(unit)
        {
            category = WeaponCategory.OneHanded;
            GetMinMaxValue();
        }
    }
}
