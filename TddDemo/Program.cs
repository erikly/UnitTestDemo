namespace TddDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new BusinessLogic(new DependencyAdapter());
            logic.Execute();
        }
    }
}