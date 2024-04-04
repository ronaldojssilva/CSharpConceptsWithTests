﻿using Exercises.Domain;

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
    }
}
