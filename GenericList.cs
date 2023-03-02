using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Classes {
    public class GenericList<T> {
        T[] data;             // All lists are made up of arrays.
        private int count;

        public T this[int i] {        // Allows us to index our list. [0]
            get { return data[i]; }
            set { data[i] = value; }
        }

        public int Count {              // [1]
            get { return count; }
        }

        public GenericList() {               // Constructor that declares the size of our list.
            data = new T[10];
        }

        public void Add(T item) {
            if(count == data.Length) {
                Resize();
            }

            data[count] = item;
            count++;
        }

        // 1 2 3 4 5 6 7    Count: 6 <=>    1 2 3 4 6 7 7
        public void RemoveAt(int index) {
            for (int i = 0; i < count-1; i++) {
                data[i] = data[i+1];
            }
            count--;
        }

        private void Resize() {             // Resize our list
            T[] temp = data;              // Temporary storage
            data = new T[count * 2];

            for (int i = 0; i < count; i++) {   // [2]
                data[i] = temp[i];
            }
        }
    }
}