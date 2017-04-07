namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Thing.Start()
                .AddWord("First")
                .AddWord("Second")
                .AddWord("Third")
                .FinalWord("Fourth")
                .Complete();
        }
    }
}
