using System;

namespace Task8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool end = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Граф задан матрицей инциденций. Найти все его блоки.");


                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nНахождение блоков в графе, сгенерированном с помощью ДСЧ:");
                Console.ResetColor();
                Graph g2 = Graph.CreateGraph();
                Graph.PrintGraph(g2);
                g2.Block();
                end = CheckKey();
            } while (!end);
        }
        
        //выход из программы или формирование новой последоватльности
        public static bool CheckKey()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            bool next, end = false;
            int keyNum;
            Console.WriteLine("Для выхода из программы нажмите Esc, для генерации другого графа нажмите Enter.");
            do
            {
                keyNum = Console.ReadKey().KeyChar;
                next = (keyNum == 27) || (keyNum == 13);
            } while (!next);
            if (keyNum == 27) end = true;
            Console.Clear();
            Console.ResetColor();
            return end;
        }
    }
}

