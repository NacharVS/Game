using GameCharacterEditor.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GameCharacterEditor.Logic
{
    public class Serializing
    {
        public static void Serializer(Warrior warrior)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = warrior.Path;
            using (FileStream fs = new FileStream("C:/Users/Администратор/Desktop/serializedImage.txt", FileMode.OpenOrCreate))
            {
                Bitmap bitmap = new Bitmap(path);
                formatter.Serialize(fs, bitmap);
            }
        }
    }
}
