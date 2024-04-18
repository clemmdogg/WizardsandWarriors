using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WizardsandWarriors
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Kort nicolai = new Kort("Nicolai", true, 1, 2, 5, 3);
            Kort simon = new Kort("Simon", true, 1, 4, 1, 5);
            Kort kasper = new Kort("Kasper", true, 5, 3, 2, 1);
            Kort jørgen = new Kort("Jørgen", true, 4, 4, 1, 2);
            Kort annemette = new Kort("Anne-Mette", false, 0, 0, 0, 0);
            Kort maja = new Kort("Maja", false, 4, 4, 1, 4);

            List<Kort> kortListe = new List<Kort>();
            List<Kort> spillerListe = new List<Kort>();
            List<Kort> computerListe = new List<Kort>();

            kortListe.Add(nicolai);
            kortListe.Add(simon);
            kortListe.Add(kasper);
            kortListe.Add(jørgen);
            kortListe.Add(annemette);
            kortListe.Add(maja);

            var random = new Random();

            int kortListeStart = kortListe.Count / 2;

            for (int i = 0; i < kortListeStart; i++)
            {
                int index = random.Next(kortListe.Count);
                spillerListe.Add(kortListe[index]);
                kortListe.Remove(kortListe[index]);
            }

            while (kortListe.Count != 0)
            {
                int index = random.Next(kortListe.Count);
                computerListe.Add(kortListe[index]);
                kortListe.Remove(kortListe[index]);
            }

            Console.WriteLine("Velkommen til Troldmænd og Krigere!");
            Console.WriteLine("Du får tre kæmpere, og computeren får tre kæmpere. Held og lykke med at slå computeren!");

            string køn = "hej";
            string spillerValg = "hej";


            while (true)
            {
                Console.WriteLine("---------------------------------------");

                if (spillerListe[0].erMand == true)
                {
                    køn = "Han";
                }
                else
                {
                    køn = "Hun";
                }

                Console.WriteLine("Du har trukket kæmperen, " + spillerListe[0].navn + ". " + køn + ", der skal kæmpe mod computerens kæmper, " + computerListe[0].navn + "!");
                Console.WriteLine("Du skal nu vælge, om de skal slås på styrke, liv, magi eller våben!");
                while (true)
                {
                    Console.WriteLine("Tast S for styrke, L for liv, M for magi eller V for våben: ");
                    spillerValg = Console.ReadLine().ToLower();

                    if (spillerValg == "s" || spillerValg == "l" || spillerValg == "m" || spillerValg == "v")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("FORKERT INPUT.PRØV IGEN!");
                        Console.WriteLine("---------------------------------------");
                    }
                }
                Console.WriteLine("---------------------------------------");
                if (spillerValg == "s")
                {
                    if (spillerListe[0].styrke > computerListe[0].styrke)
                    {
                        Console.WriteLine("Tillykke! Du vandt kampen og vandt krigeren, " + computerListe[0].navn + "!");
                        spillerListe.Add(computerListe[0]);
                        computerListe.Remove(computerListe[0]);

                    }
                    else if (spillerListe[0].styrke > computerListe[0].styrke)
                    {
                        Console.WriteLine("Æv! Du tabte kampen og tabte krigeren, " + spillerListe[0].navn + "!");
                        computerListe.Add(spillerListe[0]);
                        spillerListe.Remove(spillerListe[0]);
                    }
                    else
                    {
                        Console.WriteLine("Kampen endte uafgjort både computer og spiller beholder deres kæmper!");
                    }
                }

                else if (spillerValg == "l")
                {
                    if (spillerListe[0].liv > computerListe[0].liv)
                    {
                        Console.WriteLine("Tillykke! Du vandt kampen og vandt krigeren, " + computerListe[0].navn + "!");
                        spillerListe.Add(computerListe[0]);
                        computerListe.Remove(computerListe[0]);
                    }
                    else if (spillerListe[0].liv < computerListe[0].liv)
                    {
                        Console.WriteLine("Æv! Du tabte kampen og tabte krigeren, " + spillerListe[0].navn + "!");
                        computerListe.Add(spillerListe[0]);
                        spillerListe.Remove(spillerListe[0]);
                    }
                    else
                    {
                        Console.WriteLine("Kampen endte uafgjort både computer og spiller beholder deres kæmper!");
                    }
                }

                else if (spillerValg == "m")
                {
                    if (spillerListe[0].magi > computerListe[0].magi)
                    {
                        Console.WriteLine("Tillykke! Du vandt kampen og vandt krigeren, " + computerListe[0].navn + "!");
                        spillerListe.Add(computerListe[0]);
                        computerListe.Remove(computerListe[0]);
                    }
                    else if (spillerListe[0].magi < computerListe[0].magi)
                    {
                        Console.WriteLine("Æv! Du tabte kampen og tabte krigeren, " + spillerListe[0].navn + "!");
                        computerListe.Add(spillerListe[0]);
                        spillerListe.Remove(spillerListe[0]);
                    }
                    else
                    {
                        Console.WriteLine("Kampen endte uafgjort både computer og spiller beholder deres kæmper!");
                    }
                }

                else
                {
                    if (spillerListe[0].våben > computerListe[0].våben)
                    {
                        Console.WriteLine("Tillykke! Du vandt kampen og vandt krigeren, " + computerListe[0].navn + "!");
                        spillerListe.Add(computerListe[0]);
                        computerListe.Remove(computerListe[0]);
                    }
                    else if (spillerListe[0].våben < computerListe[0].våben)
                    {
                        Console.WriteLine("Æv! Du tabte kampen og tabte krigeren, " + spillerListe[0].navn + "!");
                        computerListe.Add(spillerListe[0]);
                        spillerListe.Remove(spillerListe[0]);
                    }
                    else
                    {
                        Console.WriteLine("Kampen endte uafgjort både computer og spiller beholder deres kæmper!");
                    }
                }

                Console.WriteLine("Du har " + spillerListe.Count + " krigere! Computeren har " + computerListe.Count + " krigere!");

                if (computerListe.Count == 0)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("TILLYKKE! DU VANDT DET HELE!!!!");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("---------------------------------------");
                    break;
                }
                else if (spillerListe.Count == 0)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("SHAME ON YOU! DU TABTE ALT!!!!");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("---------------------------------------");
                    break;
                }
            }

        }

        class Kort{
            public string navn;
            public bool erMand;
            public int styrke;
            public int liv;
            public int magi;
            public int våben;

            public Kort (string navn, bool erMand, int styrke, int liv, int magi, int våben)
            {
                this.navn = navn;
                this.erMand = erMand;
                this.styrke = styrke;
                this.liv = liv;
                this.magi = magi;
                this.våben = våben;
            }

        }
    }    
}

