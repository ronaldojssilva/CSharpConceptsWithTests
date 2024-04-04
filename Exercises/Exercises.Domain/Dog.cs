

namespace Exercises.Domain
{
    public class Dog
    {
        public string Bark()
        {
            return "woof! woof!";
        }

        public string HowMuchShouldIEat(int weighKg)
        {
            var foodQuantityGrams = weighKg * 50;
            var message = $"As I weigh {weighKg}kg, I should eat {foodQuantityGrams}g per day";

            return message;
        }
    }
}
