using Servidores.Properties;
using System.Linq;

namespace Servidores.Auxiliares
{
    public static class Nomes
    {
        public static string Nome => ObterNomes();

        private static string ObterNomes()
        {
            var nomes = Resources.nomes.Trim().Split('\n').ToList();

            return nomes[Randomico.ObterRandomico(0, nomes.Count)];
        }
    }
}
