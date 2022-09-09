using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VirtualPetSimulator
{
    class VirtualPet
    {
        public string? FullName;
        public int Age;
        public string? Species;
        public double HungerLevel;
        public bool IsAwake;
        private int ExperiencePoints;

        /// <summary>
        /// constructor 
        /// </summary>
        public VirtualPet(string petName, 
                          int petAge, 
                          string petSpecies, 
                          bool petIsAwake)
        {
            FullName = petName;
            Age = petAge;
            Species = petSpecies;
            IsAwake = petIsAwake;
        }

        public void Greet()
        {
            
            WriteLine($"My name is {FullName}, I am a {Species} and I am {Age} years young!");
            WriteLine($"Is awake? {IsAwake}");
        }

        public void Sleep()
        {
            IsAwake = false;
            WriteLine($"zZzZZzZZzzZ. {FullName} is now sleeping.");
        }

        public void Eat(string FoodName)
        {
            WriteLine($"{FullName} is now eating {FoodName}");
        }

    }
}
