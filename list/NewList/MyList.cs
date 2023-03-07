using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewList
{
    internal class MyList<T> : IEnumerable
    {
        Node<T> first = null;
        Node<T> last = null;
        int count = 0;
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<T>(ToArray());
        }
        public void Append(T value)   //добавить в конец
        {
            Node<T> appended_value = new Node<T>(value); //добавляемое значение
            if (first == null)
            {
                first = appended_value;
                last = appended_value;               
            }
            else
            {
                last.next = appended_value;
                appended_value.previous = last;
                last = appended_value;
            }
            count++;
        }

        public void Prepend(T value) //добавить в начало
        {
            Node<T> prepended_value = new Node<T>(value); //добавляемое значение
            if (first == null)
            {
                first = prepended_value;
                last = prepended_value;
            }
            else
            {
                first.previous = prepended_value;
                prepended_value.next = first;
                first = prepended_value;
            }
            count++;
        }
        public void Insert(int index, T value) //добавить по индексу
        {
            if (index >= 0 && index <= count)
            {
                if (index == 0)
                {
                    Prepend(value);
                }
                else if (index == count)
                {
                    Append(value);
                }
                else
                {
                    Node<T> inserted_value = new Node<T>(value);
                    Node<T> now = first;
                    for (int i = 0; i < index; i++)
                    {
                        now = now.next;
                    }

                    Node<T> next_inserted_value = now.next;
                    now.next = inserted_value;
                    inserted_value.previous = now;
                    inserted_value.next = next_inserted_value;
                    next_inserted_value.previous = inserted_value;
                    count++;
                }
            }
            else
            {
                throw new Exception("Неверный индекс");
            }
        }
        public void Remove(T value)  //удалить по значению
        {
            if (Find(value) != null)
            {
                Node<T> removed_value = Find(value); //удаляемое значение
                if (removed_value.Equals(first))
                {
                    first.previous = null;
                    first = first.next;                   
                }
                else if (removed_value.Equals(last))
                {
                    last = last.previous;
                    last.next = null;
                }
                else
                {
                    Remover(removed_value);
                }
                count--;
            }
            else
            {
                throw new Exception("Нет элемента");
            }
        }

        Node<T> Find(T value)
        {
            if (first == null)
            {
                return null;
            }
            Node<T> now = first;
            while (!now.value.Equals(value))
            {
                now = now.next;
                if (now == null) 
                { 
                    return null; 
                }
            }
            return now;
        }

        public ref T FindRef(T value) //поиск элемента
        {
            if (Find(value) != null)
            {
                return ref Find(value).value;
            }
            else
            {
                throw new Exception("Нет элемента");
            }

        }
        Node<T> FindIndex(int index)
        {
            if (index<count)
            {
                if (first == null)
                    return null;
                Node<T> now = first;
                while (index > 0)
                {
                    now = now.next;
                    index--;
                }
                return now;
            }
            else
            {
                throw new Exception("Неверный индекс");
            }
        }
        public T FindRefIndex(int index) //поиск по индексу
        {
            if (FindIndex(index) != null)
            {
                return FindIndex(index).value;
            }
            else
            {
                throw new Exception("Неверный индекс");
            }
        }
        void Remover(Node<T> now)
        {
            Node<T> previous_value = now.previous;
            Node<T> next_value = now.next;
            previous_value.next = next_value;
            next_value.previous = previous_value;
        }

        public void RemoveIndex(int index)  //удалить элемент по индексу
        {
            if (index < 0 || index > count - 1 || first == null)
            {
                throw new Exception("Неверный индекс");
            }
            else
            {
                if (index == 0)
                {
                    if (first.next != null)
                    {
                        first = first.next;
                        first.previous = null;
                    }
                    else
                    {
                        first = null;
                        last = null;
                    }

                }
                else if (index == count - 1)
                {
                    last = last.previous;
                    last.next = null;
                }
                else
                {
                    Remover(FindIndex(index));
                }
                count--;
            }
        }



        public T[] ToArray()
        {
            T[] array = new T[count];

            Node<T> now = first;
            for (int i = 0; now != null; i++)
            {
                array[i] = now.value;
                now = now.next;
            }
            return array;
        }

    }
}