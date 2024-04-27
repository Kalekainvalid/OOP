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

public class FRectangle : FPolygon
{
    // параметры цвет заливки и обводки, верхняя левая точка, ширина и длина прямоугольника
    public FRectangle(Brush fillColor, Brush strokeColor, Point topLeftPoint, double width, double height)
        : base(fillColor, strokeColor, new Point[0])
    {
        AddRectanglePoints(topLeftPoint, width, height);
    }

    // добавление точек прямоугольника в массив точек
    private void AddRectanglePoints(Point topLeftPoint, double width, double height)
    {
        // Верхняя левая
        AddPoint(topLeftPoint);

        // Верхняя правая
        Point topRightPoint = new Point(topLeftPoint.X + width, topLeftPoint.Y);
        AddPoint(topRightPoint);

        // Нижняя правая
        Point bottomRightPoint = new Point(topLeftPoint.X + width, topLeftPoint.Y + height);
        AddPoint(bottomRightPoint);

        // Нижняя левая
        Point bottomLeftPoint = new Point(topLeftPoint.X, topLeftPoint.Y + height);
        AddPoint(bottomLeftPoint);
    }
    
   
}