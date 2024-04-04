

namespace Exercises.Domain
{
    public class Dog
    {
        public string Bark()
        {
            return "woof! woof!";
        }

        /// <summary>
        /// Method to calculate 5% of the dog's weight(Kg) in grams of food
        /// </summary>
        /// <param name="weighKg"></param>
        /// <returns></returns>
        public string HowMuchShouldIEat(int weighKg)
        {
            return $"As I weigh {weighKg}kg, I should eat {weighKg * 50}g per day";
        }
    }
}
