using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dog
{
    public class Dog
    {
        public enum Gender
        {
            Male, Female
        }
        public string name;
        public string owner;
        public int age;
        public Gender gender;
        public static string getGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "His";
            }
            return "Her";
        }
        public Dog(string name2, string owner2, int age2, Gender gender2) // this is for the second dog and owner
        {
            name = name2;

            owner = owner2;

            age = age2;

            gender = gender2;
        }
        public void bark(int woofs)
        {
            for (int i = 0; i < woofs; i++) 
            {
                Console.Write("Woof!");
            }
            Console.WriteLine();
        }
        public string getTag()
        {
            string herOrhis = getGender(gender).ToString(); // differentiate he or she
            string sheOrhe;
            if (herOrhis == "His")
            {
                sheOrhe = "he";
            }
            else
            {
                sheOrhe = "she";
            }
            if (age > 1) //differntiate between 1 and dogs over 1
            {
            return "If lost, call " + owner + ". " + herOrhis + " name is " + name + " and " + sheOrhe + " is " + age + " years old.";
            }
            return "If lost, call " + owner + ". " + herOrhis + " name is " + name + " and " + sheOrhe + " is " + age + " year old.";

        }
        static void Main(string[] args)
        {   Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);

            puppy.bark(3);

            Console.WriteLine(puppy.getTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female); 

            myDog.bark(1);

            Console.WriteLine(myDog.getTag());

            Console.ReadLine();


        }
    }
}
