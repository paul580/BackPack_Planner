using System;

namespace Mochila
{
    class Program
    {
        static void Main(string[] args)
        {
            Mochila mochila = new Mochila(
                new int [3,4]{
                    { 0, 5, 3, 0},
                    { 7, 1, 4, 8},
                    { 2, 1, 4, 8}
                },
                3
            );
            mochila.PrintMochila();
        }
    }
}
