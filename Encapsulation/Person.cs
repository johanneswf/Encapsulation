using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private int age;
        private string? fName; //We validate the string in the public property so that it can't return null.
        private string? lName; //We validate the string in the public property so that it can't return null.
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
                else throw new ArgumentException("Age needs to greater than 0.");
            }
        }

        public string FName
        {
            get
            {
                //Removes possibility of null return even though it shouldn't be possible for it to be null anyway,
                //since we check it when set.
                if (string.IsNullOrEmpty(fName)) throw new ArgumentException("FName is null or empty.");
                else return fName;
            }

            set
            {
                if (value.Length >= 2 || value.Length <= 10) fName = value;
                else throw new ArgumentException("FName needs to be between 2 and 10 characters.");
            }
        }

        public string LName
        {
            // Removes warning instead of checking for null like we did in the FName property.
#pragma warning disable CS8603 // Possible null reference return.
            get { return lName; }
#pragma warning restore CS8603 // Possible null reference return.
            set
            {
                if (value.Length >= 3 || value.Length <= 15) lName = value;
                else throw new ArgumentException("LName needs to be between 3 and 15 characters.");
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //public Person(int age, string fName, string lName, double height = 0, double weight = 0)
        //{
        //    Age = age;
        //    FName = fName;
        //    LName = lName;
        //    Height = height;
        //    Weight = weight;
        //}
    }

}
