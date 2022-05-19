using System.Collections;
using System;
using System.Threading;

namespace OrientedObjectProgramation;

public class MultithreadingProductConsumer
{
    int size;
    public int[] _array;
    private object lockObj = new object();

    public MultithreadingProductConsumer()
    {
        size = 100;
        _array = new int[size];
    }

    public int SizeArray(Array tab)
    {
        return tab.Length;
    }

    private void product()
    {
        int i = 0;
        while (true) {
            lock (lockObj) {
                if (i >= _array.Count()) {
                    Thread.Sleep(1000);
                    i = 0;
                }
                _array[i] = i++;

            }
        }
    }
    private void Consumer()
    {
        int i = 0;
        while (true) {
            lock (lockObj) {
                if (i >= size) {
                    size *= 2;
                    _array = new int[size];
                    i = 0;
                }
                if (i != _array[i]) {
                    Thread.Sleep(200);
                }
                Console.WriteLine($"array :: {_array[i++]} | size :: {size}");
            }
        }
    } 
    public void ProductConsumer()
    {
        Console.WriteLine(SizeArray(_array));
        Thread productT = new Thread(new ThreadStart(product));
        Thread consumerT = new Thread(new ThreadStart(Consumer));

        productT.Start();
        consumerT.Start();
    }

} 