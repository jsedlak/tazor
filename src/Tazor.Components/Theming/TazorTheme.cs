namespace Tazor.Components.Theming;

public class TazorTheme : ITheme
{
    public string Name { get; set; } = "Unset Theme Name";

    public TableTheme Table { get; set; } = new();

    public FormsTheme Forms { get; set; } = new();

    public DialogTheme Dialog { get; set; } = new();

    public ContentTheme Content { get; set; } = new();

    public PagerTheme Pager { get; set; } = new();

    public TabNavTheme TabNav { get; set; } = new();

    public DropdownTheme Dropdown { get; set; } = new();

    public FlyoutTheme Flyout { get; set; } = new();

    public SwitchTheme Switch { get; set; } = new();

    public ButtonTheme Button { get; set; } = new();

    public UtilityTheme Utility { get; set; } = new();

    public NavigationTheme Navigation { get; set; } = new();

    public LayoutTheme Layout { get; set; } = new();

    public bool IsDefault { get; set; }
}
