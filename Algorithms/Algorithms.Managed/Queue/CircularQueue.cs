namespace Algorithms.Queue
{
    /// <summary>
    /// In a circular queue, we use an array and two pointers, head and tail. head indicates the start 
    /// position of the queue while tail indicates the ending position of the queue.
    /// </summary>
    public class CircularQueue
    {
        private int[] vector;
        private int head = -1;
        private int tail = -1;

        public CircularQueue(int k)
        {
            vector = new int[k];
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            if (IsEmpty())
            {
                head = 0;
            }

            tail++;
            vector[tail % vector.Length] = value;

            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }

            head++;

            return true;
        }

        public int Front()
        {
            return vector[head % vector.Length];
        }

        public int Rear()
        {
            return vector[tail % vector.Length];
        }

        public bool IsEmpty()
        {
            return tail < 0;
        }

        public bool IsFull()
        {
            return (tail - head + 1 >= vector.Length);
        }
    }
}
