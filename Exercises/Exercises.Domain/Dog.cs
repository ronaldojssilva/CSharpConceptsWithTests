

namespace Exercises.Domain
{
    public class Dog
    {
        public string Bark()
        {
            return "woof! woof!";
        }

        public string HowMuchShouldIEat(int weigh)
        {
            var foodQuantity = weigh * 1000 * 0.05;
            var message = $"As I weigh {weigh}kg, I should eat {foodQuantity}g per day";

            return message;
        }
    }
}
