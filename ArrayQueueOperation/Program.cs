class Queue()
{
    

    public static (int[] Queue,int front,int end) Enque()
    {
        Console.WriteLine("enter limit value");
        int value = Convert.ToInt32(Console.ReadLine());
        int[] q = new int[value];
        int front = -1;
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
        
        for (int i = f; i < e; i++)
        {
            Console.WriteLine(q[f]);
        }
    }


}

class ArrayQueueOperation()
{
    
    public static void Main()
    {
        
        var data = Queue.Enque();
        //DispalyQueueArray(queue);
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
