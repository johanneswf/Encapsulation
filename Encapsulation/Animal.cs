using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal abstract class Animal
    {
        // If all animals need a property we put it here.
        public string Name { get; set; } = string.Empty;
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();


    }

    internal class Horse : Animal
    {
        public bool IsRidable { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The horse neighs.");
        }
    }

    internal class Dog : Animal
    {
        public bool IsTrained { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The hedgehog sqeaks.");
        }
    }

    internal class Worm : Animal
    {
        public double Length { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The worm grunts.");
        }
    }

    internal class Bird : Animal
    {
        // If all birds need a property we put it here.
        public double WingSpan { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The bird chirps.");
        }
    }

    internal class Wolf : Animal
    {
        public bool IsLoneWolf { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The wolf howls.");
        }
    }

    internal class Pelican : Bird
    {
        public double BillLength { get; set; }
    }

    internal class Flamingo : Bird
    {
        public bool IsStandingOnOneLeg { get; set; }
    }

    internal class Swan : Bird
    {
        public bool IsSinging { get; set; }
    }

    internal class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("The wolfman says \"rawr\".");
        }
    }
}
