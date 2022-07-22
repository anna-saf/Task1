using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;
            ChangeParams(ref x, ref y);
            ChangeParams(ref y, ref z);

            Console.WriteLine(String.Format("x={0}, y={1}, z={2}", x, y, z));
        }

        private static void ChangeParams(ref int param1, ref int param2)
        {
            param1 = param1 + param2;
            param2 = param1 - param2;
            param1 = param1 - param2;
        }
    }
}
