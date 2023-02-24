using System.Text.RegularExpressions;

namespace Tazor.Components.Theming;

public class TazorTheme : ITazorTheme
{
    //private static readonly Regex ParameterRegex = new Regex(@"\{[^\{\}]*\}");

    protected IDictionary<string, string> _classMappings = new Dictionary<string, string>();

    public TazorTheme(IBaseTheme baseTheme)
    {
        Base = baseTheme;
    }

    public string[] GetKeys()
    {
        return _classMappings.Keys.ToArray();
    }

    public virtual string CompileFromBase(string input)
    {
        var props = Base.GetKeys();

        foreach (var prop in props)
        {
            var propValue = Base[prop];

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

    public IBaseTheme Base { get; set; }

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

    public string TableBody
    {
        get { return this[nameof(TableBody)]; }
        set { this[nameof(TableBody)] = value; }
    }

    public string TableFooter
    {
        get { return this[nameof(TableFooter)]; }
        set { this[nameof(TableFooter)] = value; }
    }

    public string TableSummary
    {
        get { return this[nameof(TableSummary)]; }
        set { this[nameof(TableSummary)] = value; }
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

    public string Panel
    {
        get { return this[nameof(Panel)]; }
        set { this[nameof(Panel)] = value; }
    }

    /// <summary>
    /// Gets or Sets the class for the dialog window
    /// </summary>
    public string DialogWindow
    {
        get { return this[nameof(DialogWindow)]; }
        set { this[nameof(DialogWindow)] = value; }
    }

    /// <summary>
    /// Gets or Sets the classes that style the overlay behind the dialog window
    /// </summary>
    public string DialogOverlay
    {
        get { return this[nameof(DialogOverlay)]; }
        set { this[nameof(DialogOverlay)] = value; }
    }

    /// <summary>
    /// Gets or Sets the classes for the inside div of the dialog
    /// </summary>
    public string DialogWindowInner
    {
        get { return this[nameof(DialogWindowInner)]; }
        set { this[nameof(DialogWindowInner)] = value; }
    }

    public string DialogHeader
    {
        get { return this[nameof(DialogHeader)]; }
        set { this[nameof(DialogHeader)] = value; }
    }

    public string DialogContent
    {
        get { return this[nameof(DialogContent)]; }
        set { this[nameof(DialogContent)] = value; }
    }

    public string DialogFooter
    {
        get { return this[nameof(DialogFooter)]; }
        set { this[nameof(DialogFooter)] = value; }
    }

    /// <summary>
    /// Gets or Sets the class for the button
    /// </summary>
    public string Button
    {
        get { return this[nameof(Button)]; }
        set { this[nameof(Button)] = value; }
    }

    /// <summary>
    /// Gets or Sets the class for the inside content of a button
    /// </summary>
    public string ButtonInner
    {
        get { return this[nameof(ButtonInner)]; }
        set { this[nameof(ButtonInner)] = value; }
    }

    #region Menu
    public string Menu
    {
        get { return this[nameof(Menu)]; }
        set { this[nameof(Menu)] = value; }
    }

    public string HorizontalMenu
    {
        get { return this[nameof(HorizontalMenu)]; }
        set { this[nameof(HorizontalMenu)] = value; }
    }

    public string VerticalMenu
    {
        get { return this[nameof(VerticalMenu)]; }
        set { this[nameof(VerticalMenu)] = value; }
    }

    public string MenuHeadingItem
    {
        get { return this[nameof(MenuHeadingItem)]; }
        set { this[nameof(MenuHeadingItem)] = value; }
    }

    public string MenuHeadingAnchor
    {
        get { return this[nameof(MenuHeadingAnchor)]; }
        set { this[nameof(MenuHeadingAnchor)] = value; }
    }

    public string MenuDropdownWrapper
    {
        get { return this[nameof(MenuDropdownWrapper)]; }
        set { this[nameof(MenuDropdownWrapper)] = value; }
    }

    public string MenuItem
    {
        get { return this[nameof(MenuItem)]; }
        set { this[nameof(MenuItem)] = value; }
    }

    public string MenuAnchor
    {
        get { return this[nameof(MenuAnchor)]; }
        set { this[nameof(MenuAnchor)] = value; }
    }
    #endregion

    public string TextBox
    {
        get { return this[nameof(TextBox)]; }
        set { this[nameof(TextBox)] = value; }
    }

    public string SelectInput
    {
        get { return this[nameof(SelectInput)]; }
        set { this[nameof(SelectInput)] = value; }
    }

    public string Label
    {
        get { return this[nameof(Label)]; }
        set { this[nameof(Label)] = value; }
    }

    public string SubLabel
    {
        get { return this[nameof(SubLabel)]; }
        set { this[nameof(SubLabel)] = value; }
    }

    #region Alerts
    public string AlertGlobal
    {
        get { return this[nameof(AlertGlobal)]; }
        set { this[nameof(AlertGlobal)] = value; }
    }

    public string AlertInfo
    {
        get { return this[nameof(AlertInfo)]; }
        set { this[nameof(AlertInfo)] = value; }
    }

    public string AlertWarning
    {
        get { return this[nameof(AlertWarning)]; }
        set { this[nameof(AlertWarning)] = value; }
    }

    public string AlertError
    {
        get { return this[nameof(AlertError)]; }
        set { this[nameof(AlertError)] = value; }
    }

    public string AlertSuccess
    {
        get { return this[nameof(AlertSuccess)]; }
        set { this[nameof(AlertSuccess)] = value; }
    }
    #endregion
}