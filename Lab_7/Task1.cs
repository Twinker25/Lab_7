using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    class Array : IOutput
    {
        public int size;
        public Array(int size)
        {
            this.size = size;
        }

        public virtual void Show()
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            Console.Write("Array: ");
            for (int i = 0; i < size; i++) 
            {
                arr[i] = rnd.Next(1, 10);
                Console.Write(arr[i] + " ");
            }
        }
        public virtual void Show(string info)
        {
            Show();
            Console.WriteLine($"\nInformation message: {info}");
        }
    }
}
