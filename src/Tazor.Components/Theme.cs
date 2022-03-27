using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tazor.Components;

public static class Theme
{
    /// <summary>
    /// Gets or Sets the spacing around a generic component. Generally used to set margin-top and margin-bottom
    /// </summary>
    public static string ComponentSpacing { get; set; } = "mt-5 mb-5";

    /// <summary>
    /// Gets or Sets the styles for the header of a generic component
    /// </summary>
    public static string ComponentHeader { get; set; } = "bg-white dark:bg-blue-600 text-gray-800 dark:text-white px-5 py-4";

    public static string Table { get; set; } = "min-w-full";

    public static string TableSpacing { get; set; } = ComponentSpacing;

    public static string TableHeader { get; set; } = ComponentHeader;

    public static string TableFooter { get; set; } = ComponentHeader;

    public static string TableColumnHeaderCell { get; set; } = "font-medium cursor-pointer text-sm px-5 py-4";

    public static string TableEvenRow { get; set; } = "text-sm text-gray-900 dark:text-white font-light px-6 py-4 whitespace-nowrap";

    public static string TableOddRow { get; set; } = TableEvenRow;

    public static string TableSummaryRow { get; set; } = $"{TableEvenRow} bg-gray-300 text-gray-900 dark:bg-blue-700 dark:text-white font-medium";

    public static string TableToolbar { get; set; } = $"{ComponentHeader.Replace("bg-blue-600", "bg-blue-700")} flex justify-between items-center px-5 py-4";

    public static string TableCell { get; set; } = "px-6 py-4";
}
