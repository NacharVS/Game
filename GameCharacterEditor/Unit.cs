using System.Collections.Generic;

namespace GameCharacterEditor
{
    class Unit
    {
        protected double hp;
        protected string name = "Unit";
        protected double strength;
        protected double dexterity; // ловкость
        protected double intelegence;
        protected double constitution; //телосложение
        private double extra = 20;
        private double attackSpeed;
        protected double walkingSpeed;
        protected double pDefence;
        protected double mDefence;
        protected double pAttack;
        protected double mAttack;
        Inventar inventar = new Inventar();


        public double Hp { get => hp; set => hp = value; }
        public string Name { get => name; set => name = value; }
        public double Extra { get => extra; set => extra = value; }
        public double Strength { get => strength; set => strength = value; }
        public double Dexterity { get => dexterity; set => dexterity = value; }
        public double Intelegence { get => intelegence; set => intelegence = value; }
        public double AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        public Inventar Inventar { get => inventar; private set => inventar = value; }
        public double Constitution { get => constitution; set => constitution = value; }
        public double WalkingSpeed { get => walkingSpeed; set => walkingSpeed = value; }

        public Unit(double strength, double dexterity, double constitution, double intelegence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelegence = intelegence;
            this.constitution = constitution;
            hp += strength * 5 + constitution * 10;
            attackSpeed += dexterity * 5;
            walkingSpeed += dexterity * 2;
            pDefence += dexterity * 3;
            mAttack += intelegence * 10;
            mDefence += intelegence * 5;
            pDefence += constitution * 5;
            pAttack = strength * 5 > 20 ? strength * 5 : extra;
            inventar.FillAllItemsList();
        }

        public void PhysAttack()
        {
            hp -= pAttack;
        }

        public void MagicAttack()
        {
            hp -= mAttack;
        }

        public void Defence()
        {

        }
    }

    class Warrior : Unit
    {
        public Warrior() : base(250, 10, 100, 50)
        {
            strength = 250;
            dexterity = 10;
            constitution = 100;
            intelegence = 50;
            name = "Warrior 1.0";
        }
        public Warrior(double strength, double dexterity, double constitution, double intelegence) : base(strength, dexterity, constitution, intelegence)
        {
            name = "Warrior 2.0";
        }
    }

    class Sorcerer : Unit
    {
        public Sorcerer() : base(50, 50, 50, 250)
        {
            intelegence = 250;
            strength = 50;
            constitution = 50;
            dexterity = 50;
            name = "Sorcerer 1.0";
        }
        public Sorcerer(double strength, double dexterity, double constitution, double intelegence) : base(strength, dexterity, constitution, intelegence)
        {
            name = "Sorcerer 2.0";
        }
    }

    class Rogue : Unit
    {
        public Rogue() : base(60, 250, 60, 100)
        {
            dexterity = 250;
            strength = 60;
            intelegence = 100;
            constitution = 60;
            name = "Rogue 1.0";
        }
        public Rogue(double strength, double dexterity, double constitution, double intelegence) : base(strength, dexterity, constitution, intelegence)
        {
            name = "Rogue 2.0";
        }
    }
}