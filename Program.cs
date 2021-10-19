using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OOP_Lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    public class Set<T>// множество Set
    {
        private static List<T> items = new List<T>();
        public int Count => items.Count;// счётчик
        public Set(T item)//конструктор
        {
            items.Add(item);
        }

        public void Add(T item)// добавление только неповторяющихся элементов
        {
            if (items.Contains(item))
            {
                return;
            }

            items.Add(item);
        }

        public void Remove(T item)//удаление элементов
        {
            items.Remove(item);
        }
        private T[] arr = new T[100];

       
        public T  this[int i]// индексатор
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        //перегрузка операций
        

        public static bool operator < (Set<T> item1, T item2)
        {
            if (items.Contains(item2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Set<T> item1, T item2)
        {
            throw new NotImplementedException();
        }
        /*public static bool operator >(Set<T> set1, Set<T> set2)
        {
            // Проверяем входные данные на пустоту.
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            // Перебираем элементы первого множества.
            // Если все элементы первого множества содержатся во втором,
            // то это подмножество. Возвращаем истину, иначе ложь.
            var result = set1.items.All(s => set2.items.Contains(s));
            return result;
        }

        public static bool operator <(Set<T> set1, Set<T> set2)
        {
            throw new NotImplementedException();
        }*/
    }
}