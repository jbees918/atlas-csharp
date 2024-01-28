Based on 1-enqueue, add a new method Dequeue() to the class Queue<T> that removes the first node in the queue and returns its value.

If the queue is empty, the method should write Queue is empty to the console and return the default value of the parameter’s type
carrie@ubuntu:~/csharp-generics/2-dequeue$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("First value: " + myIntQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());

        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());
    }
}
carrie@ubuntu:~/csharp-generics/2-dequeue$
carrie@ubuntu:~/csharp-generics/2-dequeue$ dotnet run
Number of nodes in queue: 2
First value: 100
Number of nodes in queue: 1
----------
Number of nodes in queue: 1
First value: 9.8
Number of nodes in queue: 0
Queue is empty
First value: 0
carrie@ubuntu:~/csharp-generics/2-dequeue$
Repo:

GitHub repository: atlas-csharp
Directory: csharp-generics
File: 2-dequeue/, 2-dequeue/2-dequeue.csproj, 2-dequeue/queue.cs