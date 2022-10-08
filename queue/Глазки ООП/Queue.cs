using System;
using System.Windows.Forms;

namespace Глазки_ООП
{

    internal class Queue<T>
    {
        T[] mas; 
        int head = 0; 
        int tail = 0;
        int count = 0;
        public Queue(int capacity)
        {
            mas = new T[capacity];
        }

        public void Push(T push)
        {
            if (count < mas.Length)
            {
                mas[tail] = push;
                if (tail == mas.Length - 1) { tail = 0; }
                else { tail++; }
                count++;
            }
            else
            {
                throw new MyException("Очередь переполнена");
            }
        }

        public T Pop()
        {
            if (count != 0)
            {
                T top = mas[head];                             
                if ( head == mas.Length - 1) { head = 0; }
                else { head++; }                             
                count--;
                return top;
            }
            else
            {
                throw new MyException("Очередь пуста");
            }
        }

        public T Top()
        {
            if (count != 0) return mas[head];
            else throw new MyException("Очередь пуста");
        }

        public T[] List()
        {
            T[] mas_c = new T[count];
            int count_mas = head;
            for (int i = 0; i < count; i++)
            {
                if (count_mas >= mas.Length) { count_mas = 0; }
                mas_c[i] = mas[count_mas];
                count_mas++;
            }
                return mas_c;           
        }
    }
}