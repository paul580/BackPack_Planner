using System;

namespace Mochila
{
    class Mochila
    {
        private int[,] GPeso;
        private int GNombre;

        public Mochila(int[,]girdASD, int GNombre)
         {
           this.GPeso = girdASD;
           this.GNombre = GNombre;
        }
        public void PrintMochila()
        {
            for (int y = 0; y < this.GNombre; y++)
            {
                for (int x = 0; x < this.GNombre; x++)
                {
                    Console.WriteLine();
                }
            }
        }
    }

}