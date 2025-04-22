namespace Generator.Icons;

public static class GeometryDataGenerator
{
    public static string CreateFromFile(string path)
    {
        using var svg = SKSvg.CreateFromFile(path);

        var drawingGroup = new DrawingGroup(svg.Model);

        var geometryString = new StringBuilder();

        foreach (var item in EnumerateGeometryDrawing(drawingGroup.Children))
        {
            var skPath = item.Geometry
                         ??
                         throw new InvalidOperationException();

            var data = ToSvgPathData(skPath, SKMatrix.CreateIdentity());

            geometryString.Append(data);
        }

        return geometryString.ToString();
    }

    private static IEnumerable<GeometryDrawing> EnumerateGeometryDrawing(IEnumerable<Drawing> source)
    {
        foreach (var drawing in source)
        {
            if (drawing is DrawingGroup group)
            {
                foreach (var item in EnumerateGeometryDrawing(group.Children))
                {
                    yield return item;
                }
            }
            else if (drawing is GeometryDrawing geometryDrawing)
            {
                yield return geometryDrawing;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }

    private static string ToSvgPathData(SKPath path, SKMatrix matrix)
    {
        var transformedPath = new SKPath(path);
        transformedPath.Transform(matrix);
        if (transformedPath.FillType == SKPathFillType.EvenOdd)
        {
            // EvenOdd
            var sb = new StringBuilder();
            sb.Append("F0 ");
            sb.Append(transformedPath.ToSvgPathData());
            return sb.ToString();
        }
        else
        {
            // Nonzero 
            var sb = new StringBuilder();
            sb.Append("F1 ");
            sb.Append(transformedPath.ToSvgPathData());
            return sb.ToString();
        }
    }
}