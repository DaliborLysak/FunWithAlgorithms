using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms
{
    public partial class MergeSort
    {
        public override ISortable[] Sort(ISortable[] data)
        {
            var queue = new Queue<Queue<ISortable>>();

            // split data
            var splitQueue = new Queue<ISortable>();
            for (var i = 0; i < data.Count(); i++)
            {
                splitQueue.Enqueue(data[i]);

                if ((i + 1 < data.Count()) && (data[i].GetSortValue() > data[i + 1].GetSortValue()))
                {
                    queue.Enqueue(splitQueue);
                    splitQueue = new Queue<ISortable>();
                }
            }
            queue.Enqueue(splitQueue); // last

            // merge data
            do
            {
                var sortedQueue = new Queue<Queue<ISortable>>();
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

            return queue.Dequeue().ToArray<ISortable>();
        }

        private Queue<ISortable> Merge(Queue<ISortable> queue1, Queue<ISortable> queue2)
        {
            var sortedQueue = new Queue<ISortable>();
            var count = queue1.Count() + queue2.Count();
            var number1 = queue1.Dequeue();
            var number2 = queue2.Dequeue();
            do
            {
                if (sortedQueue.Count() < count - 1)
                {
                    var smallerNumber = number1.GetSortValue() < number2.GetSortValue() ? number1 : number2;
                    sortedQueue.Enqueue(smallerNumber);
                }
                else
                {
                    sortedQueue.Enqueue(number1.GetSortValue() < number2.GetSortValue() ? number2 : number1);
                }

                if (sortedQueue.Count() < count)
                {
                    if (number1.GetSortValue() < number2.GetSortValue())
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

        private void Dequeue(Queue<ISortable> queue1, ref ISortable number1, Queue<ISortable> queue2, ref ISortable number2)
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
