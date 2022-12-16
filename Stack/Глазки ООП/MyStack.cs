using System;
using System.Windows.Forms;

namespace Stack
{
    internal class MyStack
    {
        int[] mas; //переменная массива
        int kolvo = 0; //количество элементов в стеке
        public int kol_vo
        {
            get { return kolvo; }
            set { kolvo = value; }
        }
        public MyStack(int a)
        {
            mas = new int[a]; //объявление массива длинной а
        }

        public void Push(int p)
        {
            if(kolvo < mas.Length)
            {
                mas[kolvo] = p;
                kolvo++;
            }
            else
            {
                throw new Exception("Стек переполнен");
            }
        }

        public int Pop()
        {
            if (kolvo != 0)
            {
                kolvo--;
                int top = mas[kolvo];
                mas[kolvo] = 0;
                return top;
            }
            else
            {
                throw new Exception("Стек пуст");
            }

        }

        public int Top()
        {
            if (kolvo != 0) return mas[kolvo - 1];
            else throw new Exception("Стек пуст");
        }

        public int[] ToArray()
        {
            return mas;
        }

    }
}