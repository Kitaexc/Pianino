using System;

namespace Piano
{
    internal class Program
    {
        private static int activeOctave = 0;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Добро пожаловать в пианино!");
            Console.WriteLine("\nНажмите Enter, чтобы запустить игру");
            Console.ReadLine();
            Piano();
        }

        static void Piano()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("┌----------------------------------┐                                                                    ");
            Console.WriteLine("|  |███||███|     |███||███||███|  |                                                                    ");
            Console.WriteLine("|  |███||███|     |███||███||███|  |                                                                    ");
            Console.WriteLine("|__|Do#||Re#|_____|Fa#||Sl#||La#|__|                                   ___  ___       ___  ___  ___     ");
            Console.WriteLine("|  |███||███|  |  |███||███||███|  |       Регулируйте октавы         | S || D |     | G || H || J |    ");
            Console.WriteLine("|  |███||███|  |  |███||███||███|  |        нажатием стрелок        __|Do#||Re#|__ __|Fa#||Sl#||La#|__  ");
            Console.WriteLine("| Do | Re | Mi | Fa | Sl | La | Ci |       ┌---------------┐       |  |___||___|  |  |___||___||___|  | ");
            Console.WriteLine("|    |    |    |    |    |    |    |       |  <--  |  -->  |       |Z-Do|X-Re|C-Mi|V-Fa|B-Sl|N-La|M-Ci| ");
            Console.WriteLine("|____|____|____|____|____|____|____|       |_______|_______|       |____|____|____|____|____|____|____| ");

            Octava_0();
        }

        static void PlayNote(double frequency)
        {
            int durationMs = 500;
            Console.Beep((int)frequency, durationMs);
        }

        static void Octava_0()
        {
            int[] Do = new int[] { 260, 523, 1046, 2093, 4186 };
            int[] DoH = new int[] { 277, 554, 1108, 2217, 4434 };
            int[] Re = new int[] { 293, 587, 1174, 2349, 4698 };
            int[] ReH = new int[] { 311, 622, 1244, 2489, 4978 };
            int[] Mi = new int[] { 329, 659, 1318, 2637, 5274 };
            int[] Fa = new int[] { 349, 698, 1396, 2793, 5587 };
            int[] FaH = new int[] { 369, 739, 1479, 2959, 5919 };
            int[] Sl = new int[] { 392, 784, 1568, 3136, 6272 };
            int[] SlH = new int[] { 415, 830, 1661, 3322, 6644 };
            int[] La = new int[] { 440, 880, 1760, 3520, 7040 };
            int[] LaH = new int[] { 466, 932, 1864, 3729, 7458 };
            int[] Si = new int[] { 493, 987, 1975, 3951, 7902 };

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                    if (keyInfo.Key == ConsoleKey.Z)
                    {
                        PlayNote(Do[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.X)
                    {
                        PlayNote(Re[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.C)
                    {
                        PlayNote(Mi[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.V)
                    {
                        PlayNote(Fa[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.B)
                    {
                        PlayNote(Sl[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        PlayNote(La[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.M)
                    {
                        PlayNote(Si[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.S)
                    {
                        PlayNote(DoH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.D)
                    {
                        PlayNote(ReH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.G)
                    {
                        PlayNote(FaH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.H)
                    {
                        PlayNote(SlH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.J)
                    {
                        PlayNote(LaH[activeOctave]);
                    }

                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        activeOctave = 1;
                        Octava_1();
                    }
                }
            }
        }

        static void Octava_1()
        {
            int[] Do = new int[] { 260, 523, 1046, 2093, 4186 };
            int[] DoH = new int[] { 277, 554, 1108, 2217, 4434 };
            int[] Re = new int[] { 293, 587, 1174, 2349, 4698 };
            int[] ReH = new int[] { 311, 622, 1244, 2489, 4978 };
            int[] Mi = new int[] { 329, 659, 1318, 2637, 5274 };
            int[] Fa = new int[] { 349, 698, 1396, 2793, 5587 };
            int[] FaH = new int[] { 369, 739, 1479, 2959, 5919 };
            int[] Sl = new int[] { 392, 784, 1568, 3136, 6272 };
            int[] SlH = new int[] { 415, 830, 1661, 3322, 6644 };
            int[] La = new int[] { 440, 880, 1760, 3520, 7040 };
            int[] LaH = new int[] { 466, 932, 1864, 3729, 7458 };
            int[] Si = new int[] { 493, 987, 1975, 3951, 7902 };

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                    if (keyInfo.Key == ConsoleKey.Z)
                    {
                        PlayNote(Do[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.X)
                    {
                        PlayNote(Re[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.C)
                    {
                        PlayNote(Mi[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.V)
                    {
                        PlayNote(Fa[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.B)
                    {
                        PlayNote(Sl[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        PlayNote(La[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.M)
                    {
                        PlayNote(Si[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.S)
                    {
                        PlayNote(DoH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.D)
                    {
                        PlayNote(ReH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.G)
                    {
                        PlayNote(FaH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.H)
                    {
                        PlayNote(SlH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.J)
                    {
                        PlayNote(LaH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        activeOctave = 0;
                        Octava_0();
                    }
                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        activeOctave = 2;
                        Octava_2();
                    }
                }
            }
        }
        static void Octava_2()
        {
            int[] Do = new int[] { 260, 523, 1046, 2093, 4186 };
            int[] DoH = new int[] { 277, 554, 1108, 2217, 4434 };
            int[] Re = new int[] { 293, 587, 1174, 2349, 4698 };
            int[] ReH = new int[] { 311, 622, 1244, 2489, 4978 };
            int[] Mi = new int[] { 329, 659, 1318, 2637, 5274 };
            int[] Fa = new int[] { 349, 698, 1396, 2793, 5587 };
            int[] FaH = new int[] { 369, 739, 1479, 2959, 5919 };
            int[] Sl = new int[] { 392, 784, 1568, 3136, 6272 };
            int[] SlH = new int[] { 415, 830, 1661, 3322, 6644 };
            int[] La = new int[] { 440, 880, 1760, 3520, 7040 };
            int[] LaH = new int[] { 466, 932, 1864, 3729, 7458 };
            int[] Si = new int[] { 493, 987, 1975, 3951, 7902 };

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                    if (keyInfo.Key == ConsoleKey.Z)
                    {
                        PlayNote(Do[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.X)
                    {
                        PlayNote(Re[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.C)
                    {
                        PlayNote(Mi[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.V)
                    {
                        PlayNote(Fa[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.B)
                    {
                        PlayNote(Sl[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        PlayNote(La[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.M)
                    {
                        PlayNote(Si[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.S)
                    {
                        PlayNote(DoH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.D)
                    {
                        PlayNote(ReH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.G)
                    {
                        PlayNote(FaH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.H)
                    {
                        PlayNote(SlH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.J)
                    {
                        PlayNote(LaH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        activeOctave = 1;
                        Octava_1();
                    }
                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        activeOctave = 3;
                        Octava_3();
                    }
                }
            }
        }
        static void Octava_3()
        {
            int[] Do = new int[] { 260, 523, 1046, 2093, 4186 };
            int[] DoH = new int[] { 277, 554, 1108, 2217, 4434 };
            int[] Re = new int[] { 293, 587, 1174, 2349, 4698 };
            int[] ReH = new int[] { 311, 622, 1244, 2489, 4978 };
            int[] Mi = new int[] { 329, 659, 1318, 2637, 5274 };
            int[] Fa = new int[] { 349, 698, 1396, 2793, 5587 };
            int[] FaH = new int[] { 369, 739, 1479, 2959, 5919 };
            int[] Sl = new int[] { 392, 784, 1568, 3136, 6272 };
            int[] SlH = new int[] { 415, 830, 1661, 3322, 6644 };
            int[] La = new int[] { 440, 880, 1760, 3520, 7040 };
            int[] LaH = new int[] { 466, 932, 1864, 3729, 7458 };
            int[] Si = new int[] { 493, 987, 1975, 3951, 7902 };

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                    if (keyInfo.Key == ConsoleKey.Z)
                    {
                        PlayNote(Do[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.X)
                    {
                        PlayNote(Re[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.C)
                    {
                        PlayNote(Mi[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.V)
                    {
                        PlayNote(Fa[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.B)
                    {
                        PlayNote(Sl[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        PlayNote(La[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.M)
                    {
                        PlayNote(Si[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.S)
                    {
                        PlayNote(DoH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.D)
                    {
                        PlayNote(ReH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.G)
                    {
                        PlayNote(FaH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.H)
                    {
                        PlayNote(SlH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.J)
                    {
                        PlayNote(LaH[activeOctave]);
                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        activeOctave = 2;
                        Octava_2();
                    }
                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        activeOctave = 4;
                        Octava_4();
                    }
                }
            }
            static void Octava_4()
            {
                int[] Do = new int[] { 260, 523, 1046, 2093, 4186 };
                int[] DoH = new int[] { 277, 554, 1108, 2217, 4434 };
                int[] Re = new int[] { 293, 587, 1174, 2349, 4698 };
                int[] ReH = new int[] { 311, 622, 1244, 2489, 4978 };
                int[] Mi = new int[] { 329, 659, 1318, 2637, 5274 };
                int[] Fa = new int[] { 349, 698, 1396, 2793, 5587 };
                int[] FaH = new int[] { 369, 739, 1479, 2959, 5919 };
                int[] Sl = new int[] { 392, 784, 1568, 3136, 6272 };
                int[] SlH = new int[] { 415, 830, 1661, 3322, 6644 };
                int[] La = new int[] { 440, 880, 1760, 3520, 7040 };
                int[] LaH = new int[] { 466, 932, 1864, 3729, 7458 };
                int[] Si = new int[] { 493, 987, 1975, 3951, 7902 };

                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                        if (keyInfo.Key == ConsoleKey.Z)
                        {
                            PlayNote(Do[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.X)
                        {
                            PlayNote(Re[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.C)
                        {
                            PlayNote(Mi[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.V)
                        {
                            PlayNote(Fa[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.B)
                        {
                            PlayNote(Sl[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.N)
                        {
                            PlayNote(La[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.M)
                        {
                            PlayNote(Si[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.S)
                        {
                            PlayNote(DoH[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.D)
                        {
                            PlayNote(ReH[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.G)
                        {
                            PlayNote(FaH[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.H)
                        {
                            PlayNote(SlH[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.J)
                        {
                            PlayNote(LaH[activeOctave]);
                        }
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            activeOctave = 3;
                            Octava_3();
                        }
                    }
                }
            }
        }
    }
}

