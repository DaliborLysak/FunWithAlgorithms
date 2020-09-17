using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms
{
    public class MergeSort : SortAlgorithm
    {
        public override int[] Sort(int[] data)
        {
            var queue = new Queue<Queue<int>>();

            // split data
            var splitQueue = new Queue<int>();
            for (var i = 0; i < data.Count(); i++)
            {
                splitQueue.Enqueue(data[i]);

                if ((i + 1 < data.Count()) && (data[i] > data[i + 1]))
                {
                    queue.Enqueue(splitQueue);
                    splitQueue = new Queue<int>();
                }
            }
            queue.Enqueue(splitQueue); // last

            // merge data
            do
            {
                var sortedQueue = new Queue<Queue<int>>();
                while (queue.Count > 0)
                {
                    var queue1 = queue.Dequeue();
                    if (queue.Count > 0)
                    {
                        var queue2 = queue.Dequeue();
                        sortedQueue.Enqueue(Merge(queue1, queue2));
                    }
                    else
                    {
                        sortedQueue.Enqueue(queue1);
                    }
                }

                do
                {
                    queue.Enqueue(sortedQueue.Dequeue());
                }
                while (sortedQueue.Count() > 0);

            }
            while (queue.Count > 1);

            return queue.Dequeue().ToArray<int>();
        }

        private Queue<int> Merge(Queue<int> queue1, Queue<int> queue2)
        {
            var sortedQueue = new Queue<int>();
            var count = queue1.Count() + queue2.Count();
            var number1 = queue1.Dequeue();
            var number2 = queue2.Dequeue();
            do
            {
                if (sortedQueue.Count() < count - 1)
                {
                    var smallerNumber = number1 < number2 ? number1 : number2;
                    sortedQueue.Enqueue(smallerNumber);
                }
                else
                {
                    sortedQueue.Enqueue(number1 < number2 ? number2 : number1);
                }

                if (sortedQueue.Count() < count)
                {
                    if (number1 < number2)
                    {
                        Dequeue(queue1, ref number1, queue2, ref number2);
                    }
                    else
                    {
                        Dequeue(queue2, ref number2, queue1, ref number1);
                    }
                }
            }
            while (sortedQueue.Count() < count);

            return sortedQueue;
        }

        private void Dequeue(Queue<int> queue1, ref int number1, Queue<int> queue2, ref int number2)
        {
            if (queue1.Count > 0)
            {
                number1 = queue1.Dequeue();
            }
            else
            {
                number1 = number2;
                if (queue2.Count > 0)
                {
                    number2 = queue2.Dequeue();
                }
            }
        }
    }
}
