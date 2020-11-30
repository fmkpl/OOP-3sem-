using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp1
{
    class Softwares<T> : IList<T> where T : Software
    {
        private List<T> collection;
        public Softwares(params T[] software) 
        {
            collection = new List<T>();
            foreach (var i in software) 
            {
                collection.Add(i);
            }
        }
        public Softwares()     
        {
            collection = new List<T>();
        }
        public int IndexOf(T value)
        {
            
            for (int i = 0; i < collection.Count; ++i) 
            {
                if (collection[i] == value) 
                {
                    
                    return i;
                }
            }
            return -1;
                
        }
        public void RemoveAt(int index)
        {
            collection.RemoveAt(index);
        }
        public void Insert(int index, T value) 
        {
            collection.Insert(index, value);
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < collection.Count) return collection[index];
                else throw null;
            }

            set
            {
                collection[index] = value;
            }
        }
        public void Add(T item) 
        {
            collection.Add(item);
        }
        public void Clear() 
        {
            for (int i = 0; i < collection.Count; i++) 
            {
                collection.RemoveAt(i);
            }
        }
        public bool Remove(T item) 
        {
            for (int i = 0; i < collection.Count; i++) 
            {
                if (collection[i] == item)
                {
                    collection.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool Contains(T item) 
        {
            for (int i = 0; i < collection.Count; i++) 
            {
                if (collection[i] == item) 
                {
                    return true;
                }
            }
            return false;
        }
        public void CopyTo(T[] array, int arrayIndex) 
        {
            collection.CopyTo(array,arrayIndex);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)collection).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)collection).GetEnumerator();
        }
        public int Count
        {
            get
            {
                return collection.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
    }
}
