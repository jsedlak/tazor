using System.Text.RegularExpressions;

namespace Tazor.Components.Theming;

public class TazorTheme : ITazorTheme
{
    //private static readonly Regex ParameterRegex = new Regex(@"\{[^\{\}]*\}");

    protected IDictionary<string, string> _classMappings = new Dictionary<string, string>();

    public TazorTheme(IBaseTheme baseTheme)
    {
        BaseTheme = baseTheme;
    }

    public string[] GetKeys()
    {
        return _classMappings.Keys.ToArray();
    }

    public virtual string CompileFromBase(string input)
    {
        var props = BaseTheme.GetKeys();

        foreach (var prop in props)
        {
            var propValue = BaseTheme[prop];

            if (propValue == null)
            {
                continue;
            }

            input = input.Replace("{" + prop + "}", propValue);
        }

        return input;
    }

    public string this[string index]
    {
        get { return _classMappings[index]; }
        set { _classMappings[index] = CompileFromBase(value); }
    }

    public IBaseTheme BaseTheme { get; set; }

    public string ComponentHeader
    {
        get { return this[nameof(ComponentHeader)]; }
        set { this[nameof(ComponentHeader)] = value; }
    }

    public string Table
    {
        get { return this[nameof(Table)]; }
        set { this[nameof(Table)] = value; }
    }

    public string TableSpacing
    {
        get { return this[nameof(TableSpacing)]; }
        set { this[nameof(TableSpacing)] = value; }
    }

    public string TableHeader
    {
        get { return this[nameof(TableHeader)]; }
        set { this[nameof(TableHeader)] = value; }
    }

    public string TableFooter
    {
        get { return this[nameof(TableFooter)]; }
        set { this[nameof(TableFooter)] = value; }
    }

    public string TableHeaderCell
    {
        get { return this[nameof(TableHeaderCell)]; }
        set { this[nameof(TableHeaderCell)] = value; }
    }

    public string TableEvenRow
    {
        get { return this[nameof(TableEvenRow)]; }
        set { this[nameof(TableEvenRow)] = value; }
    }

    public string TableOddRow
    {
        get { return this[nameof(TableOddRow)]; }
        set { this[nameof(TableOddRow)] = value; }
    }

    public string TableToolbar
    {
        get { return this[nameof(TableToolbar)]; }
        set { this[nameof(TableToolbar)] = value; }
    }

    public string TableCell
    {
        get { return this[nameof(TableCell)]; }
        set { this[nameof(TableCell)] = value; }
    }

    public string CodeBlock {
        get { return this[nameof(CodeBlock)]; }
        set { this[nameof(CodeBlock)] = value; }
    }
}