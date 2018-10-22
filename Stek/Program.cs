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
                        Console.WriteLine("Введите размер стека:");
                        Stack<int> stek = new Stack<int>(Convert.ToInt32(Console.ReadLine()));

                        while (flagStack == true) // стек
                        {
                            Console.WriteLine("Выберите действие:\n 1 - добавление\n 2 - удаление\n 3 - достать элемент в вершине\n 4 - очистить\n 5 - проверить на пустоту\n 6 - Печать стека\n 0 - выход");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    try { stek.PUSH(Convert.ToInt32(Console.ReadLine())); Console.WriteLine("Элемент добавлен в стек!"); }
                                    catch { Console.WriteLine("Стек переполнен или введён неверный символ!"); }
                                    continue;
                                case 2: stek.POP(); Console.WriteLine("Элемент удалён!"); continue;
                                case 3: Console.WriteLine("Элемент в вершине - " + stek.TOP()); continue;
                                case 4: stek.CLEAR(); Console.WriteLine("Стек очищен!"); continue;
                                case 5:
                                    if (stek.IsEmpty() == true) Console.WriteLine("Стек пуст!");
                                    else Console.WriteLine("Стек не пуст!");
                                    continue;
                                case 6: for (int i = stek.GetLength(); i != 0; i--) stek.Print(i - 1); continue;
                                default: flagStack = false; break;
                            }
                        }
                        continue;

                    case 2:
                        LinkedList1<char> list = new LinkedList1<char>();

                        while (flagList == true)
                        {
                            Console.WriteLine("1 - вставка\n  2 - вставка с сохранением упорядоченности\n 3 - удаление по значению\n 4 - поиск элемента\n 5 - печать списка\n 6 - очистка списка\n 0 - выход");

                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1: Console.WriteLine("Введите символы"); list.Add(Console.ReadLine()[0]); Console.WriteLine("Элемент добавлен в список!"); continue;
                                case 2: Console.WriteLine("Введите символы"); list.AddWithSort(Console.ReadLine()[0]); Console.WriteLine("Элемент добавлен в список с сортировкой!"); continue;
                                case 3: Console.WriteLine("Введите символы"); list.RemoveAt(list.IndexOf(Console.ReadLine()[0])); Console.WriteLine("Элемент удалён из списка!"); continue;
                                case 4: Console.WriteLine("Введите символы"); Console.WriteLine(list.IndexOf(Console.ReadLine()[0]) + " - индекс элемента\n"); continue;
                                case 5: foreach (var a in list) { Console.WriteLine(a + " "); } continue;
                                case 6: list.Clear(); continue;
                                default: flagList = false; break;
                            }
                        }
                        continue;
                    default: Environment.Exit(0); break;
                }
            }
        }
    }
}