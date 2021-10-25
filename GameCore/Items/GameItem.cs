using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public abstract class GameItem
    {
        protected string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        protected int _price;

        public int Price
        {
            get => _price;
            set
            {
                _price = value;
            }
        }

        protected string _descriptionMain;

        public string DescriptionMain
        {
            get => _descriptionMain;
            set
            {
                _descriptionMain = value;
            }
        }

        protected string _descriptionAdditional { get; set; }

        public string DescriptionAdditional
        {
            get => _descriptionAdditional;
            set
            {
                _descriptionAdditional = value;
            }
        }

        public GameItem(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public GameItem(string name, int price, string descriptionMain, string descriptionAdditional)
        {
            _name = name;
            _price = price;
            _descriptionMain = descriptionMain;
            _descriptionAdditional = descriptionAdditional;
        }
    }
}
