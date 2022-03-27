namespace Tazor.Components.Theming;

public class BaseTheme : IBaseTheme
{
    private readonly Dictionary<string, string> _classMappings = new Dictionary<string, string>();

    public string[] GetKeys() {
        return _classMappings.Keys.ToArray();
    }

    public string this[string index] { 
        get { return _classMappings[index]; }
        set { _classMappings[index] = value; }
    }

    public string PrimaryColor { 
        get { return this[nameof(PrimaryColor)]; }
        set { this[nameof(PrimaryColor)] = value; }
     }
    public string SecondaryColor {
        get { return this[nameof(SecondaryColor)]; }
        set { this[nameof(SecondaryColor)] = value; }
    }

    public string SuccessColor {
        get { return this[nameof(SuccessColor)]; }
        set { this[nameof(SuccessColor)] = value; }
    }

    public string WarningColor {
        get { return this[nameof(WarningColor)]; }
        set { this[nameof(WarningColor)] = value; }
    }

    public string ErrorColor {
        get { return this[nameof(ErrorColor)]; }
        set { this[nameof(ErrorColor)] = value; }
    }

    public string InfoColor {
        get { return this[nameof(InfoColor)]; }
        set { this[nameof(InfoColor)] = value; }
    }

    public string ComponentSpacing {
        get { return this[nameof(ComponentSpacing)]; }
        set { this[nameof(ComponentSpacing)] = value; }
    }

    public string ComponentPadding {
        get { return this[nameof(ComponentPadding)]; }
        set { this[nameof(ComponentPadding)] = value; }
    }
}
