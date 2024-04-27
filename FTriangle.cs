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

public class FTriangle : FPolygon
{
    // параметры цвет заливки и обводки, и массив точек треугольника
    public FTriangle(Brush fillColor, Brush strokeColor, Point[] points)
        : base(fillColor, strokeColor, points)
    {

    }

}