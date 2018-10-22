using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Stek
{
    public class Stack<T>
    {
        T[] Value;
        int Next;

        public Stack(int length) // конструктор с параметрами
        {
            Value = new T[length];
        }

        public void PUSH(T x) // добавление в стек
        {
            if (Next == Value.Length) throw new InvalidOperationException("Stek perepolnen!");
            else Value[Next++] = x;
        }

        public void POP() // вытаскивание из стека
        {
            if (IsEmpty() == true) throw new InvalidOperationException("Stek pust!");
            else
            {
                Value[--Next] = default(T);
            }
        }

        public T TOP()
        {
            if (IsEmpty() == false) return Value[Next - 1];
            else throw new InvalidOperationException("Stek pust!");
        } // вернуть значение в вершине стека

        public void CLEAR() { Value[0] = default(T); Next = 0; } // очистка стека

        public bool IsEmpty() // пустой ли?
        {
            if (Next == 0) return true;
            else return false;
        }
    }
}