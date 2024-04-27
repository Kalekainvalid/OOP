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

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        List myShapeList = new List();

        Point[] poligon =
        {
            new Point(160, 150), new Point(175,125), new Point(225,125),
            new Point(240, 150), new Point(175, 175), new Point(225, 175)
        };
        FPolygon pol = new FPolygon(Brushes.WhiteSmoke, Brushes.Transparent, poligon);
        myShapeList.AddShape(pol);

        //круг:
        FCircle circle = new FCircle(Brushes.Yellow, Brushes.Transparent,  new Point(50, 50),30);
        myShapeList.AddShape(circle);


        //прямоугольник:
        FRectangle rectangle = new FRectangle(Brushes.YellowGreen, Brushes.Transparent, new Point(90, 10),140,75 );
        myShapeList.AddShape(rectangle);


        //квадрат:
        FSquare square = new FSquare(Brushes.DarkGray, Brushes.Transparent, new Point(250, 10), 75);
        myShapeList.AddShape(square);


        //треугольник:
        Point[] trianglePoints = { new Point(100, 100), new Point(100,180), new Point(150, 180) };
        FTriangle triangle = new FTriangle(Brushes.DarkRed, Brushes.Transparent, trianglePoints);
        myShapeList.AddShape(triangle);


        //эллипс:
        FEllipse el = new FEllipse(Brushes.DarkOrange, Brushes.Transparent, new Point(50, 140), 25, 40);
        myShapeList.AddShape(el);

        
        myShapeList.DrawAll(Canvas);
    }
}