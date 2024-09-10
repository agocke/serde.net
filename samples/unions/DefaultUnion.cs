
abstract partial record Sum
{
    private Sum() { }

    public sealed partial record A : Sum
    {
        public required int A { get; init; }
    }
    public sealed partial record B : Sum
    {
        public required string B { get; init; }
    }
}