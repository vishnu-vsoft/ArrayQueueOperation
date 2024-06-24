

public class Queue
{
    private int[] queue;
    private int start;
    private int end;
    private int max;
    private int temp = 0;
    

    public Queue(int size)
    { 
        queue = new int[size];
        start = 0;
        end = -1;
        max = size;  
    }

    public void Enque(int item)
    {
        if (end == max - 1)
        {
            start = 0;
            end = -1;
            queue[++end] = item;
            Console.WriteLine(queue[end]);
            return;
        }
        queue[++end] = item;
        Console.WriteLine(queue[end]);
    }

    public int? Dequeue()
    {
        //int temp = end;
        
        if (start > end)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        int number = queue[start];
        start++;
        
        return number;
        
    }
}

public class ArrayQueueOperation()
{
    public static void Main()
    {
        Console.WriteLine("Enter size of queue");
        int size = Convert.ToInt32(Console.ReadLine());
        Queue queue = new Queue(size);
        queue.Enque(1);
        queue.Enque(11);
        queue.Enque(111);
        queue.Enque(1111);
        queue.Enque(2);
        queue.Enque(22);
        queue.Enque(222);
        queue.Enque(2222);
        Console.WriteLine($"removed number is : {queue.Dequeue()}");
        Console.WriteLine($"removed number is : {queue.Dequeue()}");
        Console.WriteLine($"removed number is : {queue.Dequeue()}");
        //Console.WriteLine($"removed number is : {queue.Dequeue()}");
        //Console.WriteLine($"removed number is : {queue.Dequeue()}");
    }
}
