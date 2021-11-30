using GameCharacterEditor.Models;
using System;
using System.Collections;
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
            using (FileStream fs = new FileStream("C:/Users/211925/Desktop/serializedImageWar.txt", FileMode.OpenOrCreate))
            {
                Bitmap bitmap = new Bitmap(path);
                formatter.Serialize(fs, bitmap);
                fs.Close();
            }
        }

        public static void Serializer(Sorcerer sorcecer)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = sorcecer.Path;
            using (FileStream fs = new FileStream("C:/Users/211925/Desktop/serializedImageSorc.txt", FileMode.OpenOrCreate))
            {
                Bitmap bitmap = new Bitmap(path);
                formatter.Serialize(fs, bitmap);
                fs.Close();
            }
        }

        public static void Serializer(Rogue rogue)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = rogue.Path;
            using (FileStream fs = new FileStream("C:/Users/211925/Desktop/serializedImageRogue.txt", FileMode.OpenOrCreate))
            {
                Bitmap bitmap = new Bitmap(path);
                formatter.Serialize(fs, bitmap);
                fs.Close();
            }
        }

        public static void Deserialize()
        {
            Hashtable addresses = null;
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("C:/Users/Администратор/Desktop/serializedImage.txt", FileMode.Open))
            {
                addresses = (Hashtable)formatter.Deserialize(fs);
                fs.Close();
            }
        }
    }
}
