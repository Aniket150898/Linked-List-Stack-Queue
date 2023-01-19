namespace QueueUsingLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(36);
            linkedListQueue.Enqueue(72);
            linkedListQueue.Enqueue(82);
            linkedListQueue.Display();// this.top=this.top.next
            Console.ReadKey();
        }
    }
}