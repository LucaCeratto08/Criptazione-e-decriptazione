using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptazione_e_decriptazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime oraCorrente = DateTime.Now;
            string alfabeto = "abcdefghijklmnopqrstuvwxyz,èà'?!0123456789£$%&/()=;:ì. ";
            string alfabetopc="qè5$a4?àzw6s£xò)ed%0= c37rf'&v.tgb1,y!h8n/uj29ìmi(kolp";
            string s1, s2,continuare="s", cripde;
            if (oraCorrente.Hour < 12)
            {
                alfabetopc = "q0%7w,.er$t6y!ò=1ui9o?èa/2sp£ d'5fghà4jk(3lzxìc)vb8nm";
            }
            else if (oraCorrente.Hour > 12 && oraCorrente.Hour <18)
            {
                alfabetopc = "abcdefghijklmnopqrstuvwxyz,èà'?!0123456789£$%&/()=;:ì. ";
            }
            do
            {
                s2 = "";
                Console.WriteLine("Vuoi criptare o decriptare una frase?\nPer scegliere criptare inserire:c\nPer decriptare inserire: d");
                cripde = Console.ReadLine();
                Console.WriteLine("\n\n");
                if (cripde == "c")
                {
                    Console.WriteLine("Inserisci la frase che vuoi criptare");
                    s1 = Console.ReadLine();
                    s1= s1.ToLower();
                    for (int j = 0; j < s1.Length; j++)
                    {
                        for (int i = 0; i < alfabetopc.Length; i++)
                        {
                            if (s1[j] == alfabeto[i])
                            {
                                s2 = s2 + alfabetopc[i];
                                break;
                            }
                        }
                    }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("La frase criptata è: " + s2);
                }
                else if (cripde == "d")
                {
                    Console.WriteLine("Inserisci la frase che vuoi decriptare");
                    s1 = Console.ReadLine();
                    s1.ToLower();
                    for (int j = 0; j < s1.Length; j++)
                    {
                        for (int i = 0; i < alfabetopc.Length; i++)
                        {
                            if (alfabetopc[i] == s1[j])
                            {
                                s2 = s2 + alfabeto[i];
                                break;
                            }
                        }
                    }
                    Console.WriteLine("La frase decriptata è: " + s2);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
                Console.WriteLine("Vuoi criptare/decriptare un altra frase?(s/n)");
                continuare = Console.ReadLine();
                Console.WriteLine("\n\n");
            } while (continuare == "s");
            Console.WriteLine("Ciao alla prossima!\nPremi un qualunque tasto per uscire");
            Console.ReadKey();
        }
    }
}
