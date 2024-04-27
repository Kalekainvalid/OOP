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
public class FCircle : FEllipse
{
    public FCircle(Brush fillColor, Brush strokeColor, Point center, double radius)
        : base(fillColor, strokeColor, center, radius, radius)
    {

    }

}