


namespace Exercises.Domain
{
    public class Dog
    {
        private string _name;
        private string _sex;
        private string _breed;
        private string _size;
        private string _age;
        private string _weightKg;

        public string Bark()
        {
            return "woof! woof!";
        }

        public string GetName()
        {
            return _name;
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

        public void SetName(string name)
        {
            _name = name;   
        }
    }
}
