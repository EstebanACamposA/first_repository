using DataStructures.Lists;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            // Lists.LinkedList<int> listilla = new(1);
            // listilla.Add(2);
            // listilla.Add(3);
            // listilla.Add(4);
            // listilla.Add(5);

            // listilla.Display();

            // listilla.Delete();
            // listilla.Display();

            // listilla.DeleteAt(2);
            // listilla.Display();

            // int found_at = listilla.FindAt(1).Data;
            // System.Console.WriteLine("found_at: " + found_at);

            // bool is_empty = listilla.IsEmpty();
            // System.Console.WriteLine("is_empty: " + is_empty);

            // int len = listilla.Len();
            // System.Console.WriteLine("len: " + len);

            // Lists.LinkedList<int> lista = new();
            // lista.Display("lista");
            // bool is_empty = lista.IsEmpty();
            // System.Console.WriteLine("is_empty: " + is_empty);
            // lista.AddAt(1, 0);
            // lista.Display("Added (1) at 0.");
            // lista.Delete();
            // lista.Display("Deleted last node.");
            // lista.Delete();
            // lista.Display("Attempted to delete empty list.");



            // StackLinkedList<int> pila = new(1);
            // pila.Display("Pila muestra.");
            // pila.Push(2);
            // pila.Push(3);
            // pila.Push(4);
            // pila.Display("Pila");

            // int peek1 = pila.Peek();
            // System.Console.WriteLine("peek1: " + peek1);
            // pila.Display("Despues de Peek");
            // int pop1 = pila.Pop();
            // System.Console.WriteLine("pop1: " + pop1);
            // pila.Display("Despues de Pop");
            // int size1 = pila.Size();

            QueueLinkedList<int> cola = new(1);
            cola.Display("Cola muestra.");
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);
            cola.Display("Cola");

            int peek1 = cola.Peek();
            System.Console.WriteLine("peek1: " + peek1);
            cola.Display("Despues de Peek");
            int dequeue1 = cola.Dequeue();
            System.Console.WriteLine("Dequeue1: " + dequeue1);
            cola.Display("Despues de dequeue");
            int size1 = cola.Size();
            System.Console.WriteLine("size1 = " + size1);

        }
    }
}