namespace AM.Common.Validation
{
    public interface IValidationContext<out T>
    {
        T Value { get; }

        string ParameterName { get; }
    }
}