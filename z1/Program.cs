namespace z1
{
    class Program
    {
        static void Main()
        {
            z1 classLoner = z1.GetInstance();
            classLoner.Name = "classLoner1";
            Console.WriteLine(classLoner.Name);
            z1 classLoner2 = z1.GetInstance();
            classLoner2.Name = "classLoner2";
            Console.WriteLine(classLoner2.Name);
            Console.WriteLine(classLoner.Name);
        }
    }
}