class Queue()
{
    private int front;

    public static (int[] Queue,int front,int end) Enque()
    {
        Console.WriteLine("enter limit value");
        int value = Convert.ToInt32(Console.ReadLine());
        int[] q = new int[value];
        front = -1;
        int end = -1;

        for (int i = 0; i < value; i++)
        {
            end++;
            q[i] = i;
        }
        front++;
        return (q, front, end);
    }

    public static void Dequeue(int[] q,int f,int e)
    {

        Console.WriteLine("removed from array one elements are : ");
        
        for (int i = f; i < q.Length; i++)
        {

            tempArray[i] = array[data];

            Console.WriteLine(tempArray[i] + " ");
            data++;


        }
    }


}

class ArrayQueueOperation()
{
    
    public static void Main()
    {
        
        Queue queue1 = new Queue();
        Console.WriteLine("enter limit value");
        int limit = Convert.ToInt32(Console.ReadLine());
        int[] queue = new int[limit];
        var data = Queue.Enque();
        DispalyQueueArray(queue);
        Queue.Dequeue(data.Queue,data.front,data.end);
        
    }

    public static void DispalyQueueArray(int[] queueArray)
    {
        Console.WriteLine("Queue is :");
        for (int i = 0; i < queueArray.Length; i++)
        {
            Console.WriteLine(queueArray[i] + " ");
        }
    }



}
