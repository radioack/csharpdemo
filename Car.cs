namespace csharpDemo
{
    public class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car car)
        {
            return (this.Make, this.Model, this.Year) ==
                (car.Make, car.Model, car.Year);
        }
    }
}
