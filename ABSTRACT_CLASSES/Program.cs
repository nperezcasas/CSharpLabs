namespace ABSTRACT_CLASSES
{
    class Program
    {
        static void Main(string[] args)
        {
            Fox fox = new Fox();
            fox.Color = "red";

            Dog dog = new Dog();
            dog.Color = "brown";

            Cat cat = new Cat();
            cat.Color = "orange";

            Bird bird = new Bird();
            bird.Color = "black";

            Duck duck = new Duck();
            duck.Color = "white";

            dog.Move(GlobalValues.Direction.Northwest, 100);
            cat.Move(GlobalValues.Direction.South, 50);


            dog.Speak();
            cat.Speak();
            bird.Speak();
            duck.Speak();
            fox.Speak();

        }
    }
}
