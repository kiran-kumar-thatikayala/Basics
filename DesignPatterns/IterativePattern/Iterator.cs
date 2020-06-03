namespace IterativePattern
{
    public class Iterator : IIterator
    {
        int _currentIndex = 0;
        private readonly IAggregate aggregate;

        public Iterator(IAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public string First {
            get
            {
                _currentIndex = 0;
                return aggregate[_currentIndex];                
            }               
        }

        public string Next
        {
            get
            {
                _currentIndex++;
                if (!IsDone)
                    return aggregate[_currentIndex];
                else
                    return string.Empty;
            }
        }
        public string Current => aggregate[_currentIndex];
        public bool IsDone => _currentIndex >= aggregate.Count;        
    }
}
