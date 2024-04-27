using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP1;

public class FPolygon : Shape
{
    public FPolygon(System.Windows.Media.Brush fillColor, System.Windows.Media.Brush strokeColor, System.Windows.Point[] points)
        : base(fillColor, strokeColor, points)
    {

    }

    public override void Draw(Canvas canvas)
    {
        Polygon polygon = new Polygon();
        polygon.Fill = FillColor;
        polygon.Stroke = StrokeColor;
        polygon.Points = new PointCollection(Points);
        canvas.Children.Add(polygon);
    }

    protected void AddPoint(Point point)
    {
        List<Point> pointsList = new List<Point>(Points);
        pointsList.Add(point);
        Points = pointsList.ToArray();
    }
}