using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GameCharacterEditor
{
    public class Unit
    {
        protected string name = "";
        protected int strenght = 0;
        protected int constitution = 0;
        protected int intelligence = 0;
        protected int dexterity = 0;
        protected int pResist = 0;
        protected int mResist = 0;
        protected int health = 0;
        protected int mana = 0;
        protected int pAttack = 0;
        protected int mAttack = 0;
        protected int walkSpeed = 0;
        protected int attackSpeed = 0;
        public static int extra = 20;
        public string Name { get => name; set => name = value; }
        public int Strenght { get => strenght; set => strenght = value; }
        public int Constitution { get => constitution; set => constitution = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int PResist { get => pResist; set => pResist = value; }
        public int MResist { get => mResist; set => mResist = value; }
        public int Health { get => health; set => health = value; }
        public int Mana { get => mana; set => mana = value; }
        public int PAttack { get => pAttack; set => pAttack = value; }
        public int MAttack { get => mAttack; set => mAttack = value; }
        public int WalkSpeed { get => walkSpeed; set => walkSpeed = value; }
        public int AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        public Unit()
        {
            name = "unit";
            strenght = 20;
            dexterity = 20;
            intelligence = 20;
            constitution = 20;
        }

        

    }

    class Warrior : Unit
    {
        public Warrior()
        {
            name = "War";
            strenght = 250;
            dexterity = 70;
            intelligence = 50;
            constitution = 100;
        }
    }

    class Witch : Unit
    {
        public Witch()
        {
            name = "Witch";
            strenght = 50;
            dexterity = 50;
            intelligence = 250;
            constitution = 50;
        }
    }

    class Rogue : Unit
    {
        public Rogue()
        {
            name = "Rogue";
            strenght = 60;
            dexterity = 250;
            intelligence = 100;
            constitution = 60;
        }
    }
}
