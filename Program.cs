
using GenericTask;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose the Operation : \n1: Stack\n2: Queue");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                StackOperation();
                break;
            case 2:
                QueueOperation();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        static void StackOperation()
        {
            Console.WriteLine("Enter the Datatype (int or char)");

            string dType = Console.ReadLine();

            switch (dType.ToLower())
            {
                case "int":
                    GenericStack<int> intStack = new GenericStack<int>(5);
                    StackFlow(intStack);
                    break;
                case "char":
                    GenericStack<char> charStack = new GenericStack<char>(5);
                    StackFlow(charStack);
                    break;

            }
        }
        static void StackFlow<T>(GenericStack<T> stack)
        {
            while (true)
            {
                Console.WriteLine("\nChoose the operation : \n1: Push\n2: Pop\n3: Peek\n4: IsEmpty\n5: Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the value : ");
                        T value = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                        stack.push(value);
                        break;
                    case 2:
                        Console.WriteLine("Popped Element : " + stack.pop());
                        break;
                    case 3:
                        Console.WriteLine("Top Element : " + stack.peek());
                        break;
                    case 4:
                        Console.WriteLine("Stack is Empty : " + stack.IsEmpty());
                        break;
                    case 5:
                        return;
                }
            }
        }
        static void QueueOperation()
        {
            GenericQueue<ChatMessage> queue = new GenericQueue<ChatMessage>(5);
            int msgId = 0;
            while (true)
            {
                Console.WriteLine("\nChoose the operation : \n1: Enter a message\n2: Dequeue\n3: IsFull\n4: IsEmpty\n5: Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the Message : ");
                        string msg = Console.ReadLine();
                        ChatMessage message = new ChatMessage { 
                            MessageId = msgId,
                            Content = msg,
                            TimeStamp = DateTime.Now,
                            SourceId = msgId,
                            };
                        msgId++;
                        queue.Enqueue(message);

                        break;
                    case 2:
                        message = queue.Dequeue();
                        Console.WriteLine($"MessageId: {message.MessageId}, Content: {message.Content}, TimeStamp: {message.TimeStamp}, SourceId: {message.SourceId}");

                        break;
                    case 3:
                        Console.WriteLine("Is Full : " + queue.IsFull());
                        break;
                    case 4:
                        Console.WriteLine("Is Empty : " + queue.IsEmpty());
                        break;
                    case 5:
                        return;
                }
            }
        }
            
        

    }
}
