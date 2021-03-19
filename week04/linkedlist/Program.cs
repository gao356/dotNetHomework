using System;

namespace week04
{

    public class Node<T>
    {
        public Node<T> NextNode { get; set; }
        public T Data { get; set; }


        public Node(T data)
        {
            Data = data;
            NextNode = null;
        }
    }

    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void Add(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                tail = head;
            }
            else
            {
                tail.NextNode = new Node<T>(data);
                tail = tail.NextNode;
            }
        }

        public void ForEach(Action<T> action)
        {
            if (head == null) return;
            else 
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    action(temp.Data);
                    temp = temp.NextNode;
                }
            }
        }

    }


    class Programe
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.ForEach(d => Console.WriteLine(d));

            int sum = 0;
            list.ForEach(d => sum += d);
            Console.WriteLine("The sum of the datas in the linkedlist is {0}", sum);

            int max = 0;
            int min = 0;
            int count = 0;
            list.ForEach(data =>
            {
                if (count == 0)
                {
                    max = data;
                    min = data;
                    count++;
                }
                else 
                {
                    if (data > max) max = data;
                    if (data < min) min = data;
                    count++;    
                }
            });

            Console.WriteLine("The max of the datas in the linkedlist is {0}", max);
            Console.WriteLine("The min of the datas in the linkedlist is {0}", min);
        }
    }
}
