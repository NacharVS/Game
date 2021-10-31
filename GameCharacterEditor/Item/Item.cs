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

        protected int requiredLVL;
        public int RequiredLVL
        {
            get => requiredLVL;
        }

        public Item(string name, bool isSelected, string description, int requiredLVL)
        {
            this.name = name;
            this.isSelected = isSelected;
            this.description = description;
            this.requiredLVL = requiredLVL;
        }
    }

    public class Weapon : Item
    {
        protected double required_str;
        public double Required_str
        {
            get => required_str;
        }

        protected double required_dex;
        public double Required_dex
        {
            get => required_dex;
        }

        protected double required_constit;
        public double Required_const
        {
            get => required_constit;
        }

        protected double required_int;
        public double Required_int
        {
            get => required_int;
        }

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

        public Weapon(string name, bool isSelected, string description, int requiredLVL,
            
                     double required_str, double required_constit, double required_dex, double required_int,
                     
                     double damage, double critChance, double damageBoost) : base(name, isSelected, description, requiredLVL)
        {
            this.damage = damage;
            this.critChance = critChance;
            this.damageBoost = damageBoost;
            this.required_str = required_str;
            this.required_constit = required_constit;
            this.required_dex = required_dex;
            this.required_int = required_int;
        }
    }

    public class OneHandedWeapon : Weapon
    {
        public OneHandedWeapon() : base("Relict sabr", true, "Incredibly lightweight and durable. Its blade cuts through equally easily the air, small trees and ... the flesh ", 7, 
                                        40, 0, 80, 0, 
                                        100, 0.1, 1.5)
        { }
    }

    public class TwoHandedWeapon : Weapon
    {
        public TwoHandedWeapon() : base ("Axe of the dwart", true, "Is it so easy to take something away from a dwarf? Those who tried to take this ancient artifact from its owner are not able to answer", 7,
                                        100, 0, 0, 0,
                                        110, 0.05, 4)
        { }
    }

    public class Bow : Weapon
    {
        public Bow() : base ("Bowl of the Rebel", true, "The weapon of true master. Powerful arrows fly so fast and silently that enemy will not have time to undestand that he died. A very humane weapon", 2,
                            35, 0, 50, 0,
                            50, 0.1, 2)
        { }        
    }
}
