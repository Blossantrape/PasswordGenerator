namespace Core;

public class PasswordSpecification
{
    public bool UseUppercase { get; set; }
    public bool UseNumbers { get; set; }
    public bool UseSymbols { get; set; }

    public PasswordSpecification(bool useUppercase = true, bool useNumbers = true, bool useSymbols = true)
    {
        UseUppercase = useUppercase;
        UseNumbers = useNumbers;
        UseSymbols = useSymbols;
    }
}