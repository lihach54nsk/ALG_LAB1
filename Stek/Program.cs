using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListApp;

namespace Stek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagStack = true;
            bool flagList = true;

            while (true)
            {
                flagList = flagStack = true;

                Console.WriteLine("1 - стек\n 2 - список\n 0 - выход"); // стек

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        while (flagStack == true) // стек
                        {
                            Console.WriteLine("Введите размер стека:");

                            Stack<int> stek = new Stack<int>(Convert.ToInt32(Console.ReadLine()));

                            Console.WriteLine("Выберите действие:\n 1 - добавление\n 2 - удаление\n 3 - достать элемент в вершине\n 4 - очистить\n 5 - проверить на пустоту\n 0 - выход");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    try { stek.PUSH(Convert.ToInt32(Console.ReadLine())); }
                                    catch { Console.WriteLine("Введён неверный символ!"); }
                                    continue;
                                case 2: stek.POP(); continue;
                                case 3: Console.WriteLine(stek.TOP()); continue;
                                case 4: stek.CLEAR(); continue;
                                case 5:
                                    if (stek.IsEmpty() == true) Console.WriteLine("Стек пуст!");
                                    else Console.WriteLine("Стек не пуст!");
                                    continue;
                                default: flagStack = false; break;
                            }
                        }
                        continue;

                    case 2:
                        LinkedList1<string> list = new LinkedList1<string>();

                        while (flagList == true)
                        {
                            Console.WriteLine("1 - вставка\n  2 - вставка с сортировкой\n 3 - удаление по значению\n 4 - поиск элемента\n 5 - очистка списка\n 0 - выход");

                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1: Console.WriteLine("Введите символы"); list.Add(Console.ReadLine()); continue;
                                case 2: Console.WriteLine("Введите символы"); list.AddWithSort(Console.ReadLine()); continue;
                                case 3: Console.WriteLine("Введите символы"); list.RemoveAt(list.IndexOf(Console.ReadLine())); continue;
                                case 4: Console.WriteLine("Введите символы"); Console.WriteLine(list.IndexOf(Console.ReadLine()) + " - индекс элемента\n"); continue;
                                case 5: list.Clear(); continue;
                                default: flagList = false; break;
                            }
                        }
                        continue;
                    default: Environment.Exit(0); break;
                }

                /*if (Convert.ToInt32(Console.ReadLine()) == 1) // стек
                {
                    Console.WriteLine("Введите размер стека:");

                    Stack<int> stek = new Stack<int>(Convert.ToInt32(Console.ReadLine()));

                    while (true)
                    {
                        Console.WriteLine("Выберите действие:\n 1 - добавление\n 2 - удаление\n 3 - достать элемент в вершине\n 4 - очистить\n 5 - проверить на пустоту\n 0 - выход");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                try { stek.PUSH(Convert.ToInt32(Console.ReadLine())); }
                                catch { Console.WriteLine("Введён неверный символ!"); }
                                continue;
                            case 2: stek.POP(); continue;
                            case 3: Console.WriteLine(stek.TOP()); continue;
                            case 4: stek.CLEAR(); continue;
                            case 5:
                                if (stek.IsEmpty() == true) Console.WriteLine("Стек пуст!");
                                else Console.WriteLine("Стек не пуст!");
                                continue;
                            default: Environment.Exit(0); break;
                        }
                    }
                }
                else // список или ...
                {
                    LinkedList1<string> list = new LinkedList1<string>();

                    Console.WriteLine("1 - вставка\n  2 - вставка с сортировкой\n 3 - удаление по значению\n 4 - поиск элемента\n 5 - очистка списка\n 0 - выход");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1: Console.WriteLine("Введите символы"); list.Add(Console.ReadLine()); continue;
                        case 2: Console.WriteLine("Введите символы"); list.AddWithSort(Console.ReadLine()); continue;
                        case 3: Console.WriteLine("Введите символы"); list.RemoveAt(list.IndexOf(Console.ReadLine())); continue;
                        case 4: Console.WriteLine("Введите символы"); list.IndexOf(Console.ReadLine()); continue;
                        case 5: list.Clear(); continue;
                        default: Environment.Exit(0); break;
                    }
                }*/
            }
        }
    }
}