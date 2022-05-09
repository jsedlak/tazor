namespace Tazor.Components.Theming;

public class BaseTheme : IBaseTheme
{
    private readonly Dictionary<string, string> _classMappings = new Dictionary<string, string>();

    public string[] GetKeys()
    {
        return _classMappings.Keys.ToArray();
    }

    public string this[string index]
    {
        get { return _classMappings[index]; }
        set { _classMappings[index] = value; }
    }

    public string PrimaryColor
    {
        get { return this[nameof(PrimaryColor)]; }
        set { this[nameof(PrimaryColor)] = value; }
    }
    public string SecondaryColor
    {
        get { return this[nameof(SecondaryColor)]; }
        set { this[nameof(SecondaryColor)] = value; }
    }

    public string SuccessColor
    {
        get { return this[nameof(SuccessColor)]; }
        set { this[nameof(SuccessColor)] = value; }
    }

    public string WarningColor
    {
        get { return this[nameof(WarningColor)]; }
        set { this[nameof(WarningColor)] = value; }
    }

    public string ErrorColor
    {
        get { return this[nameof(ErrorColor)]; }
        set { this[nameof(ErrorColor)] = value; }
    }

    public string InfoColor
    {
        get { return this[nameof(InfoColor)]; }
        set { this[nameof(InfoColor)] = value; }
    }

    public string ComponentSpacing
    {
        get { return this[nameof(ComponentSpacing)]; }
        set { this[nameof(ComponentSpacing)] = value; }
    }

    public string ComponentPadding
    {
        get { return this[nameof(ComponentPadding)]; }
        set { this[nameof(ComponentPadding)] = value; }
    }

    public string Paragraph
    {
        get { return this[nameof(Paragraph)]; }
        set { this[nameof(Paragraph)] = value; }
    }

    public string Lead
    {
        get { return this[nameof(Lead)]; }
        set { this[nameof(Lead)] = value; }
    }

    public string Heading1
    {
        get { return this[nameof(Heading1)]; }
        set { this[nameof(Heading1)] = value; }
    }
    public string Heading2
    {
        get { return this[nameof(Heading2)]; }
        set { this[nameof(Heading2)] = value; }
    }

    public string Heading3
    {
        get { return this[nameof(Heading3)]; }
        set { this[nameof(Heading3)] = value; }
    }

    public string Heading4
    {
        get { return this[nameof(Heading4)]; }
        set { this[nameof(Heading4)] = value; }
    }

    public string Callout
    {
        get { return this[nameof(Callout)]; }
        set { this[nameof(Callout)] = value; }
    }

    public string Quote
    {
        get { return this[nameof(Quote)]; }
        set { this[nameof(Quote)] = value; }
    }

    public string CodeBlock
    {
        get { return this[nameof(CodeBlock)]; }
        set { this[nameof(CodeBlock)] = value; }
    }

    public string InlineCode
    {
        get { return this[nameof(InlineCode)]; }
        set { this[nameof(InlineCode)] = value; }
    }

    public string ComponentBackground
    {
        get { return this[nameof(ComponentBackground)]; }
        set { this[nameof(ComponentBackground)] = value; }
    }
}
