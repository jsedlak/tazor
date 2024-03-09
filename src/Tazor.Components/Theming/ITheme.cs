namespace Tazor.Components.Theming;

public interface ITheme
{
    string Name { get; set; }

    TableTheme Table { get; set; }

    bool IsDefault { get; set; }

    FormsTheme Forms { get; set; }

    DialogTheme Dialog { get; set; }

    ContentTheme Content { get; set; }

    PagerTheme Pager { get; set; }

    TabNavTheme TabNav { get; set; }

    DropdownTheme Dropdown { get; set; }

    FlyoutTheme Flyout { get; set; }

    SwitchTheme Switch { get; set; }

    ButtonTheme Button { get; set; } 

    UtilityTheme Utility { get; set; }

    NavigationTheme Navigation { get; set; }
}
