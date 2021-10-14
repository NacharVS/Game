using System;
using System.Collections.Generic;

namespace GameCharacterEditor
{
    class Inventar
    {
        private List<Item> allItems = new List<Item>();
        private List<Item> existItem = new List<Item>();
        public List<Item> AllItems { get => allItems; private set => allItems = value; }
        public List<Item> ExistItem { get => existItem; private set => existItem = value; }

        public void Add(int index, double strength, double dexterity, double constitution, double intelegence, int lvl)
        {
            string a = allItems[index].ToString().Substring(20);
            if (a == "Robe")
            {
                if (intelegence > 70 && lvl > 2)
                    existItem.Add(allItems[index]);
                else
                    throw new Exception("Не хватает статов");
            }

            else if (a == "Leather")
            {
                if (strength > 110 && dexterity > 150 && lvl > 4)
                    existItem.Add(allItems[index]);
                else
                    throw new Exception("Не хватает статов");
            }

            else if (a == "Hecoy")
            {
                if (strength > 250 && constitution > 300 && lvl > 7)
                    existItem.Add(allItems[index]);
                else
                    throw new Exception("Не хватает статов");
            }

            else if (a == "RobeHelmet")
            {
                if (strength > 250 && constitution > 300 && lvl > 7)
                    existItem.Add(allItems[index]);
                else
                    throw new Exception("Не хватает статов");
            }

            else if (a == "LeatherHelmet")
            {
                if (strength > 250 && constitution > 300 && lvl > 7)
                    existItem.Add(allItems[index]);
                else
                    throw new Exception("Не хватает статов");
            }

            else if (a == "HoceyHelmet")
            {
                if (strength > 250 && constitution > 300 && lvl > 7)
                    existItem.Add(allItems[index]);
                else
                    throw new Exception("Не хватает статов");
            }
        }

        public void Delete(int index)
        {
            existItem.Remove(existItem[index]);
        }

        public void FillAllItemsList()
        {
            allItems.Add(new Robe());
            allItems.Add(new Hecoy());
            allItems.Add(new Leather());
            allItems.Add(new RobeHelmet());
            allItems.Add(new HoceyHelmet());
            allItems.Add(new LeatherHelmet());
        }
    }
}