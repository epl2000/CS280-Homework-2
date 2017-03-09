using System;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            Console.Write("Please enter the name of your Pokemon: ");
            try
            {
                pokemon.name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The name you've entered is not valid");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
        Number:
            Console.Write("Please enter the number of your Pokemon: ");
            try
            {
                pokemon.number = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                if (e.Message.ToString() == "輸入字串格式不正確。")
                {
                    Console.WriteLine("The number you've entered is not valid");
                    goto Number;
                }
                else
                {
                    Console.WriteLine("The number you've entered is not valid");
                    Console.WriteLine("error message:\n" + e.ToString());
                }
            }
        Height:
            Console.Write("Please enter the height of your Pokemon: ");
            try
            {
                pokemon.height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                if (e.Message.ToString() == "輸入字串格式不正確。")
                {
                    Console.WriteLine("The number you've entered is not valid");
                    goto Height;
                }
                else
                {
                    Console.WriteLine("The number you've entered is not valid");
                    Console.WriteLine("error message:\n" + e.ToString());
                }
            }
        Weight:
            Console.Write("Please enter the weight of your Pokemon: ");
            try
            {
                pokemon.weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                if (e.Message.ToString() == "輸入字串格式不正確。")
                {
                    Console.WriteLine("The number you've entered is not valid");
                    goto Weight;
                }
                else
                {
                    Console.WriteLine("The number you've entered is not valid");
                    Console.WriteLine("error message:\n" + e.ToString());
                }
            }
            Console.Write("Please enter the category of your Pokemon: ");
            try
            {
                pokemon.Category = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The category you've entered is not valid");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("Please enter the ability of your Pokemon: ");
            try
            {
                pokemon.Abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The ability you've entered is not valid");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("Please enter the gender of your Pokemon: ");
            try
            {
                pokemon.Gender = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The gender you've entered is not valid");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.WriteLine("Name:{0}, Number:{1}, Height:{2}feet, Weight:{3}lbs, Category:{4}, Ability:{5}, Gender:{6}", pokemon.name, pokemon.number, pokemon.height, pokemon.weight, pokemon.Category, pokemon.Abilities, pokemon.Gender);
        }
    }
}