namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Son 1 : ");
            string a1 = Console.ReadLine();
            bool a = int.TryParse(a1, out int a2);
            if (!a)
            {
                Console.WriteLine($" ERROR !!! {a2}");
                return;

            }
            else
            {
                Console.WriteLine("Son 2 :");
                string b = Console.ReadLine();
                bool b1 = int.TryParse(b, out int b2);
                if (!b1)
                {
                    Console.WriteLine($" ERROR !!! {b2}");
                    return;

                }
                else
                {
                    int g = 0;
                    Console.WriteLine("Amal Kiriting : ");
                    string d = Console.ReadLine();
                    for (int i=0; i <= d.Length; i++)
                    {
                        g++;
                    }
                    if (g == 2)
                    {
                        char c = Convert.ToChar(d);
                        if (c == '+' || c == '-' || c == '*' || c == '/')
                        {
                            if(c == '+')
                            {
                                Console.Write("Natija : ");
                                Console.WriteLine(a2+b2);
                            }   
                            else if(c == '-')
                            {
                                Console.Write("Natija : ");
                                Console.WriteLine(a2-b2);
                            }
                            else if(c == '*')
                            {
                                Console.Write("Natija : ");
                                Console.WriteLine(a2*b2);
                            }else if(c == '/')
                            {
                                Console.Write("Natija : ");
                                Console.WriteLine(a2/b2);
                            }
                        }
                        else
                        {
                            Console.WriteLine($" ERROR !!! {d}");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($" ERROR !!! {d}");
                        return;
                    }

                }
            }
            Main(args);
        }
    }
}