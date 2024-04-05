







namespace Exercises.Domain
{
    public class Dog
    {

        public string Name { get; set; }

        public string Sex { get; set; }

        public string Breed { get; set; }

        public string Size { get; set; }

        public int Age { get; set; }

        private double _weightKg;
        public double WeightKg 
        {
            get {return _weightKg;}
            set { _weightKg = Math.Max(0, value); }
        }

        public string Bark => "woof! woof!";


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
