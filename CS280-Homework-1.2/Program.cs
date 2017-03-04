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
            pokemon.height = 12.7f;
            pokemon.weight = 4.8f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "blaze";
            pokemon.Gender = "female";
            Console.WriteLine("Height:{0}meters, Weight:{1}tons, Category:{2}, Ability:{3}, Gender:{4}", pokemon.height, pokemon.weight, pokemon.Category, pokemon.Category, pokemon.Gender);
        }
    }
}