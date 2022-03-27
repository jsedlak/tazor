namespace Tazor.Components.Theming;

public interface ITheme {

    string this[string index] { get; set; }

    string[] GetKeys();
}
