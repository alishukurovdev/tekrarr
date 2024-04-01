namespace EncapsulationPraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("aLi   ", "  sHuKuRoV ", "Alik123");
            user.ChangePassword("Alik123", "Alik44");

            Console.WriteLine(user.UserName);
        }
    }
}