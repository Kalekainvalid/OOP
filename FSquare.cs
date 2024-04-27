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

public class FSquare : FRectangle
{
    // верхняя левая точка и длина стороны квадрата
    public FSquare(Brush fillColor, Brush strokeColor, Point topLeftPoint, double sideLength)
        : base(fillColor, strokeColor, topLeftPoint, sideLength, sideLength)
    {
    }
    
}