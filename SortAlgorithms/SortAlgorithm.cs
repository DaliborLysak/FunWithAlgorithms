namespace SortAlgorithms
{
    public class SortAlgorithm : ISortAlgorithm
    {
        public virtual int[] Sort(int[] data)
        {
            return data;
        }

        public virtual ISortable[] Sort(ISortable[] data)
        {
            return data;
        }
    }
}
