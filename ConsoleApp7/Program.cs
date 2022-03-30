using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(17);
            list.Add(21);
            list.Add(74);
            list.Add(57);
            list.Add(98);
            list.Add(86);
            Console.WriteLine(list.Indexof(21));
        }
    }
    class CustomList<T>
    {
        private T[] _list;
        public int count;


        public CustomList()
        {
            _list = new T[0];
        }
        public CustomList(params T[] nums)
        {
            _list = new T[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                _list[i] = nums[i];
            }
        }
        public void Add(T input)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = input;
        }
        public void Show()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }
        public void reverse()
        {
            for (int i = _list.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_list[i]);
            }
        }

        public void Count()
        {
            for (int i = 0; i < _list.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        public int Indexof(T input)
        {
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(input))
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexof(T input)
        {
            for (int i = _list.Length - 1; i >= 0; i--)
            {
                if (_list[i].Equals(input))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

