namespace Quiz.Domain.Contants;

public struct ConstantSize
{
    public int Min { get; }
    public int Max { get; }
    public ConstantSize(int min, int max)
    {
        Min = min;
        Max = max;
    }

    public ConstantSize(int size) : this(size, size) { }
}