using System.Globalization;

namespace Mark
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTRA UNA NOTA: ");
            int nota = Convert.ToInt32(Console.ReadLine());
            string notaText = CalcularNotaText(nota);
            Console.WriteLine(notaText);
        }

        /// <summary>
        /// Transforma una nota numèrica en una nota en format text.
        /// </summary>
        /// <param name="nota">Nota numèrica entera.</param>
        /// <returns>Nota en format text</returns>
        /// <exception cref="Exception">La nota numèrica ha de ser 
        /// un valor de l'interval [0,10]</exception>
        public static string CalcularNotaText(int nota)
        {
            if (nota < 0 || nota > 10)
                throw new Exception("Nota no vàlida");

            string notaStr = "";
            if (nota > 8) notaStr = "Excel·lent";
            else if (nota > 6) notaStr = "Notable";
            else if (nota > 4) notaStr = "Satisfactori";
            else notaStr = "No assolit";

            return notaStr;                
        }
    }
}
