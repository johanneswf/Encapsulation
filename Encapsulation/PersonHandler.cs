using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fName, string lName, double height = 0, double weight = 0)
        {
            var pers = new Person();
            SetAge(pers, age);
            SetFName(pers, fName);
            SetLName(pers, lName);
            SetHeight(pers, height);
            SetWeight(pers, weight);
            return pers;
        }

    }

}
