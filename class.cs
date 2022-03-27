//Code was created using OCR, use with caution.
<<<<<<< HEAD

=======
// branch pizza
>>>>>>> pizza
using System;

namespace Hello_world
{
    //what should be added here (slide 33)
    class Cat
    {

        /* this is a class for the animal: cat */
        // Member attributes (variables) 
        private bool isEating;
        private int _numLives;
        public int numLives
        {
            get
            { return _numLives; }
            set
            {
                if (value <= 7 && value >= 0)
                {
                    _numLives = value;
                }
            }
        }

        public string Name;
        // Member Functions (methods) 
        public Cat() //constructor 
        {
            numLives = 7;
            isEating = false;
            Name = "none";
        }
        public void GiveFood()
        {
            isEating = true;
        }
        public void TakeAwayFood()
        {
            isEating = false;
        }
        public bool GetEatingStatus()

        {
            return isEating;
        }
    }
}
namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // New instance of "Cat" 
            Cat myHouseCat = new Cat(); //calls the class's public constructor 
            myHouseCat.Name = "Mr. Nibbles"; //one way to change an attribute 
            Console.WriteLine("num lives: " + myHouseCat.numLives);


            myHouseCat.numLives = 10; // a better way to change an attribute 
            Console.WriteLine("num lives: " + myHouseCat.numLives);

            myHouseCat.numLives = 3; // a better way to change an attribute 
            Console.WriteLine("num lives: " + myHouseCat.numLives);

            myHouseCat.numLives = 3;
            Console.WriteLine("num lives: " + myHouseCat.numLives);
            myHouseCat.numLives = 999;
            Console.WriteLine("num lives: " + myHouseCat.numLives);

               myHouseCat.GiveFood();
            if (myHouseCat.GetEatingStatus())// if he is eating 
            {
                Console.WriteLine(myHouseCat.Name + " is eating right now");
                myHouseCat.TakeAwayFood();// take away the food (so he wont get fat) 
            }
            else //if he is not eating 
                Console.WriteLine(myHouseCat.Name + "is not eating right now");
            Console.ReadLine();
        }
    }
}