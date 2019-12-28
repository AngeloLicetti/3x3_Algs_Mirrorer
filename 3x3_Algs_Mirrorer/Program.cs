using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3_Algs_Mirrorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string inAlg;
            while (true)
            {
                Console.Write("Alg to mirror: ");
                inAlg = Console.ReadLine();
                Console.WriteLine("Alg mirrored: {0}\n", mirrorAlg(inAlg));
            }

        }

        private static string mirrorAlg(string inAlg)
        {
            if (inAlg.Length == 0)
            {
                return "No input";
            }
            if (inAlg == "clr")
            {
                Console.Clear();
                return "Cleared";
            }
            string[] partes;
            partes = inAlg.Split(' ');
            for(int i=0; i<partes.Length; i++)
            {
                partes[i] = mirrorPart(partes[i]);
            }
            return concatenarPartes(partes);
        }

        private static string concatenarPartes(string[] partes)
        {
            string salida = "";
            for (int i = 0; i < (partes.Length - 1); i++)
            {
                salida += partes[i] + " ";
            }
            salida += partes[partes.Length - 1];
            return salida;
        }

        private static string mirrorPart(string part)
        {
            if (part[0].Equals('('))
            {
                return "(" + mirrorPart(part.Substring(1));
            }
            char lastChar = part[part.Length - 1];
            if (lastChar.Equals(')'))
            {
                return mirrorPart(part.Remove(part.Length - 1)) + ")";
            }
            switch (part)
            {
                //giros normales:
                case "R":
                    return "L'";
                case "R'":
                    return "L";
                case "L":
                    return "R'";
                case "L'":
                    return "R";
                case "U":
                    return "U'";
                case "U'":
                    return "U";
                case "D":
                    return "D'";
                case "D'":
                    return "D";
                case "F":
                    return "F'";
                case "F'":
                    return "F";
                case "B":
                    return "B'";
                case "B'":
                    return "B";

                //giros con dos capas:
                case "r":
                    return "l'";
                case "r'":
                    return "l";
                case "l":
                    return "r'";
                case "l'":
                    return "r";
                case "u":
                    return "u'";
                case "u'":
                    return "u";
                case "d":
                    return "d'";
                case "d'":
                    return "d";
                case "f":
                    return "f'";
                case "f'":
                    return "f";
                case "b":
                    return "b'";
                case "b'":
                    return "b";

                //giros dobles normales:
                case "R2":
                    return "L2'";
                case "R2'":
                    return "L2";
                case "L2":
                    return "R2'";
                case "L2'":
                    return "R2";
                case "U2":
                    return "U2'";
                case "U2'":
                    return "U2";
                case "D2":
                    return "D2'";
                case "D2'":
                    return "D2";
                case "F2":
                    return "F2'";
                case "F2'":
                    return "F2";
                case "B2":
                    return "B2'";
                case "B2'":
                    return "B2";

                //giros dobles con dos capas:
                case "r2":
                    return "l2'";
                case "r2'":
                    return "l2";
                case "l2":
                    return "r2'";
                case "l2'":
                    return "r2";
                case "u2":
                    return "u2'";
                case "u2'":
                    return "u2";
                case "d2":
                    return "d2'";
                case "d2'":
                    return "d2";
                case "f2":
                    return "f2'";
                case "f2'":
                    return "f2";
                case "b2":
                    return "b2'";
                case "b2'":
                    return "b2";


                //giros de capas medias:
                case "M":
                    return "M";
                case "M'":
                    return "M'";
                default:
                    return part;
            }
        }
    }
}
