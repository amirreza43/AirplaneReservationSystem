using System;
using lib;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Database();
        }
    }
}
