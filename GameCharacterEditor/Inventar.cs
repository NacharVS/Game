using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Inventar
    {
        private List<Item> allItems = new List<Item>();
        public List<Item> AllItems { get => allItems; private set => allItems = value; }

        public void Add(List<Item> existItems, int index)
        {
            existItems.Add(allItems[index]);
        }

        public void Delete(List<Item> existItems, int index)
        {
            existItems.Remove(allItems[index]);
        }

        public void FillAllItemsList()
        {
            allItems.Add(new BodyArmor());
            allItems.Add(new Helmet());
        }
    }

    class Item
    {

    }

}
