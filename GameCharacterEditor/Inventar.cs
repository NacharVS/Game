using System;
using System.Collections.Generic;

namespace GameCharacterEditor
{
    class Inventar
    {
        private List<Item> allItems = new List<Item>() { new Robe(), new Leather(), new Hecoy(), new RobeHelmet(), new LeatherHelmet(), new HoceyHelmet() };
        private List<Item> existItem = new List<Item>();
        public List<Item> AllItems { get => allItems; }
        public List<Item> ExistItem { get => existItem; }

        public void Add(int index, double strength, double dexterity, double constitution, double intelegence, int lvl)
        {
            //string a = allItems[index].ToString().Substring(20);
            if (index == 0)
            {
                if (intelegence > 70 && lvl > 2 && CheckExistItems("Robe"))
                    existItem.Add(new Robe());
                else if (CheckExistItems("Robe") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 1)
            {
                if (strength > 110 && dexterity > 150 && lvl > 4 && CheckExistItems("Leather"))
                    existItem.Add(new Leather());
                else if (CheckExistItems("Leather") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 2)
            {
                if (strength > 250 && constitution > 300 && lvl > 7 && CheckExistItems("Hecoy"))
                    existItem.Add(new Hecoy());
                else if (CheckExistItems("Hecoy") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 3)
            {
                if (strength > 250 && constitution > 300 && lvl > 7 && CheckExistItems("RobeHelmet"))
                    existItem.Add(new RobeHelmet());
                else if (CheckExistItems("RobeHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 4)
            {
                if (strength > 250 && constitution > 300 && lvl > 7 && CheckExistItems("LeatherHelmet"))
                    existItem.Add(new LeatherHelmet());
                else if (CheckExistItems("LeatherHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 5)
            {
                if (strength > 250 && constitution > 300 && lvl > 7 && CheckExistItems("HoceyHelmet"))
                    existItem.Add(new HoceyHelmet());
                else if (CheckExistItems("HoceyHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }
        }

        private bool CheckExistItems(string itemName)
        {
            foreach (var item in existItem)
            {
                if (item.ToString().Substring(20) == itemName)
                    return false;
            }
            return true;
        }

        public void Delete(int index)
        {
            try
            {
                existItem.Remove(existItem[index]);
            }
            catch
            {
                throw new Exception("Невозможно удалить");
            }
        }

        //public void FillAllItemsList()
        //{
        //    allItems.Add(new Robe());
        //    allItems.Add(new Hecoy());
        //    allItems.Add(new Leather());
        //    allItems.Add(new RobeHelmet());
        //    allItems.Add(new HoceyHelmet());
        //    allItems.Add(new LeatherHelmet());
        //}
    }
}