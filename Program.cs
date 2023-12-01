class Program
    {
        static void Main()
        {
            Console.Write("Digite a quantidade de números da sequência Fibonacci a serem exibidos:");
                int n = int.Parse(Console.ReadLine());

                int a = 0, b = 1;

                Console.WriteLine($"Os primeiros {n} números da sequência de Fibonacci são:");
                    for (int i = 0; i<n; i++)
                    {
                        Console.WriteLine(a);
                            int temp = a;
                            a = b;
                            b = temp + b;
                    }
        }
    }
