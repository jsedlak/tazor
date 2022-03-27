namespace Tazor.Components.Theming;

public interface IBaseTheme : ITheme {
    string PrimaryColor { get; set; }

    string SecondaryColor { get; set; }

    string SuccessColor { get; set; }

    string WarningColor { get; set; }

    string ErrorColor { get; set; }

    string InfoColor { get; set; }

    string ComponentSpacing { get; set; }

    string ComponentPadding { get; set; }
}
