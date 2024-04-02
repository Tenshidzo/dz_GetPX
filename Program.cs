
namespace dz_Stack
{
    public class Stack<T>
    {
        private T[] _items;
        private int _top;

        public Stack(int capacity)
        {
            _items = new T[capacity];
            _top = -1;
        }

        public void Push(T item)
        {
            if (_top == _items.Length - 1)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }

            _top++;
            _items[_top] = item;
        }

        public T Pop()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            T item = _items[_top];
            _top--;

            return item;
        }

        public T Peek()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            return _items[_top];
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public void Clear()
        {
            _top = -1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(5);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Peek());
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            try
            {
                stack.Pop(); 
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
