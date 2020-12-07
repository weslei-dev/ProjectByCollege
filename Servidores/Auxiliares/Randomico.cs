using System;

namespace Servidores.Auxiliares
{
    public static class Randomico
    {
        public static int ObterRandomico(int minima, int maximo)
        {
            return new Random().Next(minima, maximo);
        }
    }
}
