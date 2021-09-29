using System;
using MyLib;

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
