using Exercises.Domain;

namespace Exercises.Tests
{
    public class DogTest
    {

        [Fact]
        public void Dog_Bark_Test()
        {
            //Arranje
            Dog dog = new Dog();
            //Act
            string bark = dog.Bark();
            //Assert
            Assert.Equal("woof! woof!", bark);
        }

        //Considering that the dog weighs 1kg,
        //and eats 5% of its feed weight,
        //implement the “How Much Should I Eat” method
        //to pass this test

        [Fact]
        public void Dog_HowMuchShouldIEat_Test()
        {
            //Arranje
            Dog dog = new Dog();
            //Act
            string howMuchShouldIEat = dog.HowMuchShouldIEat(1);
            //Assert
            Assert.Equal("As I weigh 1kg, I should eat 50g per day", howMuchShouldIEat);
        }

        [Fact]
        public void Tequila_HowMuchShouldIEat_Test()
        {
            //Arranje
            Dog dog = new Dog();
            //Act
            string howMuchShouldIEat = dog.HowMuchShouldIEat(30);
            //Assert
            Assert.Equal("As I weigh 30kg, I should eat 1500g per day", howMuchShouldIEat);
        }

        [Fact]
        public void Yuri_HowMuchShouldIEat_Test()
        {
            //Arranje
            Dog dog = new Dog();
            //Act
            string howMuchShouldIEat = dog.HowMuchShouldIEat(15);
            //Assert
            Assert.Equal("As I weigh 15kg, I should eat 750g per day", howMuchShouldIEat);
        }

        [Fact]
        public void Dog_Set_Get_Name_Test()
        {
            Dog dog = new Dog();
            dog.SetName("Yuri");
            string name = dog.GetName();

            Assert.Equal("Yuri", name);
        }

        [Fact]
        public void Dog_Set_Get_sex_Test()
        {
            Dog dog = new Dog();
            dog.SetSex("Female");
            string sex = dog.GetSex();

            Assert.Equal("Female", sex);
        }
    }
}
