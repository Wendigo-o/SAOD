﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewList
{
    class NewList<T> : IEnumerable
    {
        Node<T> first = null;
        Node<T> last = null;
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListIEnumerator<T>(ToArray());
        }

        public T this[int index]
        {
            get => Find(index).value;
            set { Find(index).value = value; }
        }

        public void Append(T value) //добавить в конец
        {
            Node<T> newNode = new Node<T>(value);
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.next = newNode;
                newNode.previous = last;
                last = newNode;
            }
        }
        public void Prepend(T value) //добавить в начало
        {
            Node<T> newNode = new Node<T>(value);
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                first.previous = newNode;
                newNode.next = first;
                first = newNode;
            }
        }
        public void Insert(int index, T value) //добавить по id
        {
            if (index < 0 || index > FindSize(first) - 1)
            {
                throw new Exception("Неверный индекс");
            }

            if (index == 0)
            {
                Prepend(value);
            }
            else if (index == FindSize(first))
            {
                Append(value);
            }
            else
            {
                Node<T> newNode = new Node<T>(value);
                Node<T> nowNode = first;
                for (int i = index; i != 1; i--)
                {
                    nowNode = nowNode.next;
                }

                Node<T> nextNode = nowNode.next;
                nowNode.next = newNode;
                newNode.previous = nowNode;
                newNode.next = nextNode;
                nextNode.previous = newNode;
            }
        }


        public void Remove(T Value) //удалить элемент
        {
            if (Find(Value) != null)
            {
                Node<T> now = Find(Value);
                if (now.Equals(first))
                {
                    first = first.next;
                    first.previous = null;
                }
                else if (now.Equals(last))
                {
                    last = last.previous;
                    last.next = null;
                }
                else
                {
                    Remover(now);
                }
            }
            else
            {
                throw new Exception("Нет элемента");
            }
        }
        public void RemoveAt(int index)  //удалить элемент по индексу
        {
            if (index < 0 || index > FindSize(first) - 1 || first == null)
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
                else if (index == FindSize(first))
                {
                    last = last.previous;
                    last.next = null;
                }
                else
                {
                    Remover(Find(index));
                }
            }
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
        public T FindId(int index) //поиск по индексу
        {
            if (Find(index) != null)
            {
                return Find(index).value;
            }
            else
            {
                throw new Exception("Неверный индекс");
            }
        }
        T[] ToArray() //список
        {
            if (first == null)
            {
                return new T[0];
            }

            if (last == first)
            {
                return new T[1] { last.value };
            }

            T[] result = new T[FindSize(first)];

            Node<T> now = first;
            for (int i = 0; now != null; i++)
            {
                result[i] = now.value;
                now = now.next;
            }

            return result;
        }
        void Remover(Node<T> now) 
        {
            Node<T> prevNode = now.previous;
            Node<T> nextNode = now.next;
            prevNode.next = nextNode;
            nextNode.previous = prevNode;
        }
        Node<T> Find(int index)
        {
            if (first == null)
                return null;
            Node<T> now = first;
            while (index != 0)
            {
                now = now.next;
                index--;
            }
            return now;
        }
        Node<T> Find(T value)
        {
            if (first == null)
                return null;
            Node<T> now = first;
            while (!now.value.Equals(value))
            {
                now = now.next;
                if (now == null) { return now; }
            }
            return now;

        }

        int FindSize(Node<T> now)
        {
            if (now == null)
                return 0;

            int size = 1;
            while (now.next != null)
            {
                size++;
                now = now.next;
            }
            return size;
        }
    }
}
