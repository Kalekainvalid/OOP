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

public abstract class Sprite
{
    public Brush FillColor { get; set; }
    public Brush StrokeColor { get; set; }

    public Sprite(Brush fillColor, Brush strokeColor)
    {
        FillColor = fillColor;
        StrokeColor = strokeColor;
    }

    public abstract void Draw(Canvas canvas);
}