

public class Queue
{
    private int[] queue;
    private int start;
    private int end;
    private int max;
    //private int temp = 0;
    

    public Queue(int size)
    { 
        queue = new int[size];
        start = 0;
        end = -1;
        max = 10;  
    }

    public void Enque(int item)
    {
        
        queue[++end] = item;
        Console.WriteLine(queue[end]);
    }
    
    public int? Dequeue()
    {
        if (start > end)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        int number = queue[start];
        start++;
        return number;
    }

    //method to make this queu cyclic without if conition by only using method
}

public class ArrayQueueOperation()
{
    public static void Main()
    {
        Console.WriteLine("Enter size of queue");
        int size = Convert.ToInt32(Console.ReadLine());
        Queue queue = new Queue(size);
        queue.Enque(1);
        queue.Enque(10);
        Console.WriteLine($"removed number is : {queue.Dequeue()}");
        queue.Enque(17);
        Console.WriteLine($"removed number is : {queue.Dequeue()}");
        queue.Enque(14);
        queue.Enque(2);
        queue.Enque(3);
        queue.Enque(12);
        queue.Enque(32);
        
        Console.WriteLine($"removed number is : {queue.Dequeue()}");

        Console.WriteLine($"removed number is : {queue.Dequeue()}");
        Console.WriteLine($"removed number is : {queue.Dequeue()}");
    }
}
