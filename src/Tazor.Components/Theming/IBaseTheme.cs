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

    string ComponentBackground { get; set; }

    string Paragraph { get; set; }

    string Lead { get; set; }

    string Heading1 { get; set; }

    string Heading2 { get; set; }

    string Heading3 { get; set; }

    string Heading4 { get; set; }

    string Callout { get; set; }

    string Quote { get; set; }

    string CodeBlock { get; set; }

    string InlineCode { get; set; }

    
}
