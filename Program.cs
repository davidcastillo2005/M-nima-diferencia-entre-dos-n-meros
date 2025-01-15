namespace Mínima_diferencia_entre_dos_números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = [4, 9, 1, 32, 13, 6];
            List<int> list = MenorDiferencia(ints);
            Console.WriteLine(list[0]);
        }

        static List<int> MenorDiferencia(int[] ints)
        {
            List<int> listaDiferencias = new List<int>();
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    if (i == j) continue;
                    int diferencia = Math.Abs(ints[i] - ints[j]);
                    listaDiferencias.Add(diferencia);
                }
            }

            bool intercambiado;
            for (int i = 0; i < listaDiferencias.Count - 1; i++)
            {
                intercambiado = false;
                for (int j = 0; j < listaDiferencias.Count - 1; j++)
                {
                    if (listaDiferencias[j] > listaDiferencias[j + 1])
                    {
                        int temp = listaDiferencias[j];
                        listaDiferencias[j] = listaDiferencias[j + 1];
                        listaDiferencias[j + 1] = temp;
                        intercambiado = true;
                    }
                }
                if (!intercambiado)
                {
                    break;
                }
            }

            return listaDiferencias;
        }
    }
}
