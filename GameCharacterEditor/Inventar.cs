using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Inventar
    {
        private List<Item> allItems = new List<Item>();
        public List<Item> AllItems { get => allItems; private set => allItems = value; }
        private List<Item> existItem = new List<Item>();
        public List<Item> ExistItem { get => existItem; private set => existItem = value; }

        public void Add(int index)
        {
            existItem.Add(allItems[index]);
        }

        public void Delete(int index)
        {
            existItem.Remove(allItems[index]);
        }

        public void FillAllItemsList()
        {
            allItems.Add(new Robe());
            allItems.Add(new Leather());
            allItems.Add(new Hecoy());
            allItems.Add(new RobeHelmet());
            allItems.Add(new LeatherHelmet());
            allItems.Add(new HoceyHelmet());
        }
    }

    class Item
    {
        protected double hp;
        public virtual double Hp { get => hp; private set => hp = value; }
    }

}
