namespace NSequenceComparer
{
    public class Difference<T>
    {

        public Difference(T element, DifferenceKind differenceKind)
        {
            Element = element;
            DifferenceKind = differenceKind;
        }
        
        public T Element { get; private set; }
        public DifferenceKind DifferenceKind { get; private set; }
    }
}
