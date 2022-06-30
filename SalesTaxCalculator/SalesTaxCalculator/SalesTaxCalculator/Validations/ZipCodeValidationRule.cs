namespace SalesTaxCalculator.Validations;

public class ZipCodeValidationRule<T> : IValidationRule<T>
{
    public string ValidationMessage { get; set; }

    public bool Check(T value)
    {
        if (value == null)
        {
            return false;
        }
        var length = value.ToString().Length;
        //right now supported 5-Digit ZIP or ZIP+4 (5+4)
        return length is 5 or 5 + 4;
    }
}