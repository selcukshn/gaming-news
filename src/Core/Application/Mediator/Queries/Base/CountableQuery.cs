namespace Application.Mediator.Queries.Base
{
    public class CountableQuery
    {
        private int _count = 5;
        public int Count
        {
            get => _count;
            set
            {
                if (int.TryParse(value.ToString(), out int count))
                {
                    if (count > 0)
                        _count = count;
                }
            }
        }
        public CountableQuery(int count)
        {
            Count = count;
        }
    }
}