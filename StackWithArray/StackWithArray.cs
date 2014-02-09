namespace Stack
{
    public class StackWithArray
    {
        private string[] stackWithArray; 
        public int index = -1;

        public StackWithArray()
        {
            stackWithArray = new string[2];
        }

        public void Push(string element)
        {
            if (IsFull())
                Resize();
            stackWithArray[++index] = element;
        }

        public string Pop()
        {
            if (IsEmpty())
                return "There are no more elements in the stack";
            else
                return stackWithArray[index--];
        }

        public void Resize()
        {
            string[] copy = new string[stackWithArray.Length * 2];
            for (int i = 0; i <= index; i++)
            {
                copy[i] = stackWithArray[i];
            }
            stackWithArray = copy;
        }

        public bool IsEmpty()
        {
            return index == -1;
        }

        public bool IsFull()
        {
            return index == stackWithArray.Length - 1;
        }
    }
}
