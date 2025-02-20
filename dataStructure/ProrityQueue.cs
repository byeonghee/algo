public class DataClass
{
    public int cost;
    public DataClass(int cost)
    {
        this.cost = cost;
    }
}

public class ProrityQueueDemo
{
    private List<DataClass> heap = new();

    public int Count => heap.Count;

    public void Enqueue(DataClass data)
    {
        heap.Add(data);
        int now = heap.Count - 1;

        Console.WriteLine($"target : {data.cost}");

        while (now > 0)
        {
            int parent = (now - 1) / 2; // 부모노드

            Console.WriteLine($"now : {now}, next : {parent}");

            if (heap[now].cost > heap[parent].cost)
                break;

            DataClass temp = heap[now];
            heap[now] = heap[parent];
            heap[parent] = temp;
            now = parent;

            List<int> items = new();
            foreach (DataClass item in heap)
            {
                items.Add(item.cost);
            }

            Console.WriteLine($"heap : {string.Join(",", items)}");
        }

        Console.WriteLine();
    }

    public DataClass Dequeue()
    {
        DataClass ret = heap[0];

        int lastIndex = heap.Count - 1;
        heap[0] = heap[lastIndex];
        heap.RemoveAt(lastIndex);
        lastIndex -= 1;
        int now = 0;

        while (true)
        {
            int left = 2 * now + 1;
            int right = 2 * now + 2;
            int child = now;

            if (left <= lastIndex && heap[child].cost > heap[left].cost)
            {
                child = left;
            }

            if (right <= lastIndex && heap[child].cost > heap[right].cost)
            {
                child = right;
            }

            if (child == now)
            {
                break;
            }

            DataClass temp = heap[now];
            heap[now] = heap[child];
            heap[child] = temp;

            now = child;
        }

        return ret;
    }
}

public class ProrityQueue<T> where T : IComparable<T>
{
    private List<T> heap = new();

    public int Count => heap.Count;

    public void Enqueue(T data)
    {
        heap.Add(data);
        int now = heap.Count - 1;

        Console.WriteLine($"target : {data}");

        while (now > 0)
        {
            int parent = (now - 1) / 2; // 부모노드

            Console.WriteLine($"now : {now}, next : {parent}");

            if (heap[now].CompareTo(heap[parent]) > 0)
                break;

            T temp = heap[now];
            heap[now] = heap[parent];
            heap[parent] = temp;
            now = parent;

        }
    }

    public T Dequeue()
    {
        T ret = heap[0];

        int lastIndex = heap.Count - 1;
        heap[0] = heap[lastIndex];
        heap.RemoveAt(lastIndex);
        lastIndex -= 1;
        int now = 0;

        while (true)
        {
            int left = 2 * now + 1;
            int right = 2 * now + 2;
            int child = now;

            if (left <= lastIndex && heap[child].CompareTo(heap[left]) > 0)
            {
                child = left;
            }

            if (right <= lastIndex && heap[child].CompareTo(heap[right]) > 0)
            {
                child = right;
            }

            if (child == now)
            {
                break;
            }

            T temp = heap[now];
            heap[now] = heap[child];
            heap[child] = temp;

            now = child;
        }

        return ret;
    }
}
