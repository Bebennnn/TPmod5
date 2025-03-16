using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    class DataGeneric<T>
        {
            T data;

            public DataGeneric(T data)
            {
                this.data = data;
            }
            public void Print()
            {
                Console.WriteLine("Data yang tersimpan adalah: " + data);
            }
    }

