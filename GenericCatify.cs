namespace csharpDemo
{
    public class GenericCatify<T>
    {
        public string AddCats(T input)
        {
            return $"😹😻 {input} 🐈🐱";
        }
    }
}