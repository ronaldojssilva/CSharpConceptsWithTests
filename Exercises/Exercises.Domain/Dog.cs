







namespace Exercises.Domain
{
    public class Dog
    {

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        private string _name;


        public void SetSex(string sex)
        {
            _sex = sex;
        }

        public string GetSex()
        {
            return _sex;
        }
        private string _sex;

        public void SetBreed(string breed)
        {
            _breed = breed;
        }

        public string GetBreed()
        {
            return _breed;
        }

        private string _breed;

        public void SetSize(string size)
        {
            _size = size;
        }

        public string GetSize()
        {
            return _size;
        }

        private string _size;

        public void SetAge(int age)
        {
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }
        private int _age;

        public void SetWeightKg(double weightKg)
        {
            if (weightKg < 0)
                _weightKg = 0;
            else 
                _weightKg = weightKg;
        }

        public double GetWeightKg()
        {
            return _weightKg;
        }

        private double _weightKg;

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
