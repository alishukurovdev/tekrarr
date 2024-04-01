namespace ThisAndBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile = new Mobile(2);
            mobile.AddNumber(0, "+99451*****14");
            mobile.AddNumber(1, "+994-51-410-92-14");
            mobile.GetNumbers();
            mobile.RemoveNumber(0);
            mobile.GetNumbers();
            mobile.OpenDevice();
            mobile.CloseDevice();






        }
















    }
}
