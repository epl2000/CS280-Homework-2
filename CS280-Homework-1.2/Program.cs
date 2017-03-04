using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.name = "Solgaleo";
            pokemon.number = 791;
            pokemon.height = 11.167f;
            pokemon.weight = 507.1f;
            pokemon.Category = "Sunne";
            pokemon.Abilities = "Full Metal Body";
            pokemon.Gender = "unknown";
            Console.WriteLine("Number:{0}, Name:{1}, Height:{2}feet, Weight:{3}lbs, Category:{4}, Ability:{5}, Gender:{6}", pokemon.name, pokemon.number, pokemon.height, pokemon.weight, pokemon.Category, pokemon.Category, pokemon.Gender);
        }
    }
}