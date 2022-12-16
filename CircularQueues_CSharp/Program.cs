using System;

namespace CircularQueues_CSharp
{
    class Queues
    {

        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            //Initializing the values of the variables REAR and FRONT to -1 to indicate that the queues is initially empty
            FRONT = -1;
            REAR = -1;
        }
        public void insert (int element)
        {
            //This statement checks for the overflow condition.
            if((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow");
                return;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
