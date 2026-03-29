using System.Text.RegularExpressions;

namespace Generator.Icons.Utilities;

public static partial class GeometryPathOptimizer
{
    public static string Optimize(string geometryPath, int decimals = 1)
    {
        return NumberRegex().Replace(geometryPath, match =>
        {
            var value = double.Parse(match.Value);

            // Round to desired precision
            var rounded = Math.Round(value, decimals);

            // Convert back to string without trailing zeros
            var str = rounded.ToString("G");

            return str;
        });
    }

    [GeneratedRegex(@"-?\d+\.\d+|-?\d+")]
    internal static partial Regex NumberRegex();
}