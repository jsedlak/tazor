# Tazor
Tazor is a simple UI toolkit for Blazor. The goal is to create a handful of components that may be used to create an application. Below are the components that are being worked on, or planned to be implemented in the future.

## Using Tazor

Add Tailwind via Program.cs in your Blazor Client (or Blazor Server) project

```csharp
builder.Services.AddTazor();
```

Link to the Tailwind javascript at the end of the document, before the `</body>` tag.

```html
<script src="_content/Tazor.Components/tazor.js"></script>
```

## Internal Tailwind Dependencies

Tazor is dependent on the [Tailwind](https://tailwindcss.com/) class names for styling. Chris Sainty has a great article on how to [Add Tailwind to Blazor](https://chrissainty.com/adding-tailwind-css-v3-to-a-blazor-app/).

```json
"autoprefixer": "^9",
"gulp": "^4.0.2",
"gulp-postcss": "^7",
"precss": "^4.0.0",
"tailwindcss": "npm:@tailwindcss/postcss7-compat"
```

## Theming

The Tazor Base and Child theme supports consistent styling of your application across all Tazor components. Supported via an injected `ITazorTheme` service, developers may easily extend both the base and child theme with their own properties.

```csharp
builder.Services.AddTazorTheme(
    primaryColor: "blue", // must have a full tailwind pallette available.
    configureBase: (theme) =>
    {
        // configure named elements of the base theme
        theme.ComponentBackground = "bg-brand text-white";
    },
    configureTheme: (theme) => {
        // configure custom and named elements of the child theme
        theme["IntroParagraph"] = "leading-loose text-lg";
        theme.DialogWindow = "{ComponentBackground} p-5 rounded";
    }
);
```
## DataGrid

The DataGrid component allows for the rapid creation of a styled table that supports advanced features like Column Visibility, Sorting, Paging and more. Columns are added via code and typed to the object type the DataGrid is displaying.

```razor
<DataGrid 
    SummaryRow=@SummaryRowMode.VisibleItems 
    Items=@_items 
    Columns=@_columns 
/>

@* ... *@

@code {
    private IEnumerable<Column<ProductDataItem>> _columns = new[]
    {
        new Column<ProductDataItem>{ Title = "Id", Field = m => m.Id },
        new Column<ProductDataItem>{ Title = "Title", Field = m => m.Title },
        new Column<ProductDataItem>{ 
            Title = "Cost", 
            Field = m => m.Cost, 
            Markup = m => new MarkupString(m.Cost.ToString("C2")),
            Summary = m => m.Sum(p => p.Cost).ToString("C2") 
        },
        new Column<ProductDataItem>{ Title = "Created", Field = m => m.Created, Format = "yyyy-MM-dd" },
    };
}
```

## Dialog

Docs coming soon...

## Buttons

Docs coming soon...

## Popup

Docs coming soon...

## Slide Out

Docs coming soon...

## Menus / Breadcrumbs

Docs coming soon...

## Utilities

### Breakpoint Indicator

Supports programmatical notification of when the browser window has crossed a breakpoint threshold. Useful for controlling whether an entire component or its alternate is rendered among other things.

**SAMPLE NEEDED**

### Online Status Indicator

Indicates whether or not the browser is Offline or Online and supports an event callback for when the status has changed.

### Dark Mode Switcher

Supports switching the dark mode class on the html/body elements.

### Click Container

Supports detecting when a click has happened outside an intended target.