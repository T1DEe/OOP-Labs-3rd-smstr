using System;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
//using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace OOP_Lab14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1 –––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

            Car car1 = new Car(new CarEngine(), 1000, 1000);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream file = new FileStream("binary.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, car1);
            }

            using (FileStream file = new FileStream("binary.txt", FileMode.Open))
            {
                Car car1des = (Car)binaryFormatter.Deserialize(file);
                Console.WriteLine(car1des.Length);
            }
            Console.WriteLine("Binary serialize/deserialize was succesfully complete\n");



            Car car2 = new Car(new CarEngine(), 2000, 2000);

            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream file = new FileStream("soap.txt", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(file, car2);
            }

            using (FileStream file = new FileStream("soap.txt", FileMode.Open))
            {
                Car car2des = (Car)soapFormatter.Deserialize(file);
                Console.WriteLine(car2des.Length);
            }
            Console.WriteLine("Soap serialize/deserialize was succesfully complete\n");


            int int1 = 4;
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(int));
            using (FileStream file = new FileStream("Xml.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(file, int1);
            }
            using (FileStream file = new FileStream("Xml.xml", FileMode.Open))
            {
                int ades = (int)xmlFormatter.Deserialize(file);
                Console.WriteLine(ades);
            }


            //Car car3 = new Car(new CarEngine(), 3000, 3000);

            //XmlSerializer xmlFormatter = new XmlSerializer(typeof(Car));
            //using (FileStream file3 = new FileStream("Xml.xml", FileMode.OpenOrCreate))
            //{
            //    xmlFormatter.Serialize(file3, car3);
            //}
            //using (FileStream file3 = new FileStream("Xml.xml", FileMode.Open))
            //{
            //    Car car3des = (Car)xmlFormatter.Deserialize(file3);
            //    Console.WriteLine(car3des.Length);
            //}
            //Console.WriteLine("XML serialize/deserialize was succesfully complete\n");

            // 2 –––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

            User[] users = new User[4];
            users[0] = new User();
            users[1] = new User("sasha2000");
            users[2] = new User("lol228");

            XmlSerializer xmlFormatter2 = new XmlSerializer(typeof(User));
            using (FileStream file = new FileStream("users.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter2.Serialize(file, users);
            }
            using (FileStream file = new FileStream("users.xml", FileMode.Open))
            {
                User[] usersDes = (User[])xmlFormatter2.Deserialize(file);
                foreach (User item in usersDes)
                {
                    Console.WriteLine($"{item.Nickname}");
                }
            }

            // 3 –––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––



        }
    }
}
