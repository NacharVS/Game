using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor.Item
{
    public class Item
    {
        protected string name;
        public string Name
        {
            get => name;
        }

        protected bool isSelected;
        public bool IsSelected
        {
            get => isSelected;
        }

        protected string description;
        public string Description
        {
            get => description;
        }

        public Item(string name, bool isSelected, string description)
        {
            this.name = name;
            this.isSelected = isSelected;
            this.description = description;
        }
    }

    public class Weapon : Item
    {
        protected double damage;
        public double Damage
        {
            get => damage;
        }

        protected double critChance;
        public double CritChance
        {
            get => critChance;
        }

        protected double damageBoost;
        public double DamageBoost
        {
            get => damageBoost;
        }

        public Weapon(double damage, double critChance, double damageBoost) : base("Weapon", true, "Very cool weapon")
        {
            this.damage = damage;
            this.critChance = critChance;
            this.damageBoost = damageBoost;
        }
    }

    public class OneHandedWeapon : Weapon
    {
        public OneHandedWeapon() : base(100, 0.05, 2)
        { }
    }
}
