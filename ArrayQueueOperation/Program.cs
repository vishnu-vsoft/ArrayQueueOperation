

public class QueueOld
{
    private int[] queue;
    private int start;
    private int end;
    private int size;
    //private int temp = 0;
    

    public QueueOld(int size)
    { 
        queue = new int[size];
        start = 0;
        end = 0;
        this.size = size;  
    }

    public void Enque(int item)
    {
        //if (end == max - 1)
        //{
        //    start = 0;
        //    end = -1;
        //    queue[++end] = item;
        //    Console.WriteLine(queue[end]);
        //    return;
        //}
        try
        {
                if (end + 1 > size)
                {
                    throw new IndexOutOfRangeException();
                }
                queue[end] = item;
                //Console.WriteLine(queue[end]);
                end++;
            
        }catch(IndexOutOfRangeException ex)
        {
            end = (end % size);
            queue[end] = item;
            end++;
        } 
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
    

    public void Display()
    {
        for(int i = start; i < end; i++)
        {
            Console.WriteLine(queue[i]);
        }
    }
}



public class Queue
{
    private int[] queue;
    private int start;
    private int end;
    private int maxSize;

    public Queue(int Size)
    {
        queue = new int[Size];
        start = -1;
        end = -1;
        maxSize = Size;
    }

    public void Enque(int item)
    {
        if(getQueueSize() >= maxSize)
            throw new Exception("Size exceeded. Cannot proceed!");

        end = increment(end);
        queue[end] = item;
    }

    public int Dequeue()
    {
        int size = getQueueSize();
        if (size == 0)
            throw new Exception("No items in Queue");

        start = increment(start);
        int retVal = queue[start];
        queue[start] = -1;
        return retVal;
    }

    private int getQueueSize()
    {
        if (end < 0) return 0;
        if (end == start) return 1;

        int diff = end - start;
        if (diff > 0) return diff;

        int firstHalf = maxSize - start;
        int secondHalf = end;
        return firstHalf + secondHalf;
    }

    private int increment(int currI)
    {
        return (++currI % maxSize);
    }
}

public class ArrayQueueOperation()
{
    public static void Main()
    {
        Queue queue = new Queue(2);
        int outNo= 0;

        
        queue.Enque(1);
        outNo = queue.Dequeue();
        outNo = queue.Dequeue();
        queue.Enque(1);

        outNo = queue.Dequeue();

        queue.Enque(1);
        queue.Enque(2);

        outNo = queue.Dequeue();
        outNo = queue.Dequeue();

        queue.Enque(1);
        outNo = queue.Dequeue();
        queue.Enque(2);
        outNo = queue.Dequeue();

    }
}
