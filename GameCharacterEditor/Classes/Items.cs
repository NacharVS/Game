using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor.Classes
{
    public class Item
    {
        protected string name;
        public virtual string Name { get => name; }

        //protected int 

        protected string description;
        public virtual string Description { get => description; }
    }

    public class Helmet : Item
    {
        public override string Name { get => name; }

        public override string Description { get => description; }
    }
}
