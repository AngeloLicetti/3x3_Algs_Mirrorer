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
                Console.Write("Alg to y2-rotate: ");
                inAlg = Console.ReadLine();
                Console.WriteLine("Alg y2-rotated: {0}\n", mirrorAlg(inAlg));
            }

        }

        private static string mirrorAlg(string inAlg)
        {
            if (inAlg == "clr")
            {
                Console.Clear();
                return "Cleared";
            }
            string[] partes;
            partes = inAlg.Split(' ');
            for(int i=0; i<partes.Length; i++)
            {
                partes[i] = y2rotationPart(partes[i]);
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

        private static string y2rotationPart(string part)
        {
            if (part[0].Equals('('))
            {
                return "(" + y2rotationPart(part.Substring(1));
            }
            char lastChar = part[part.Length - 1];
            if (lastChar.Equals(')'))
            {
                return y2rotationPart(part.Remove(part.Length - 1)) + ")";
            }
            switch (part)
            {
                //giros normales:
                case "R":
                    return "L";
                case "R'":
                    return "L'";
                case "L":
                    return "R";
                case "L'":
                    return "R'";
                case "F":
                    return "B";
                case "F'":
                    return "B'";
                case "B":
                    return "F";
                case "B'":
                    return "f'";

                //giros con dos capas:
                case "r":
                    return "l";
                case "r'":
                    return "l'";
                case "l":
                    return "r";
                case "l'":
                    return "r'";
                case "f":
                    return "b";
                case "f'":
                    return "b'";
                case "b":
                    return "f";
                case "b'":
                    return "f'";

                //giros dobles normales:
                case "R2":
                    return "L2";
                case "R2'":
                    return "L2'";
                case "L2":
                    return "R2";
                case "L2'":
                    return "R2'";
                case "F2":
                    return "B2";
                case "F2'":
                    return "B2'";
                case "B2":
                    return "F2";
                case "B2'":
                    return "F2'";

                //giros dobles con dos capas:
                case "r2":
                    return "l2";
                case "r2'":
                    return "l2'";
                case "l2":
                    return "r2";
                case "l2'":
                    return "r2'";
                case "f2":
                    return "b2";
                case "f2'":
                    return "b2'";
                case "b2":
                    return "f2";
                case "b2'":
                    return "f2'";


                //giros de capas medias:
                case "M":
                    return "M'";
                case "M'":
                    return "M";

                //default:
                default:
                    return part;
            }
        }
    }
}
