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

public class List
{
    private List<Sprite> shapes; // Список фигур

    // Конструктор
    public List()
    {
        shapes = new List<Sprite>(); // Инициализация
    }

    // Метод для добавления фигуры в список
    public void AddShape(Sprite Sprite)
    {
        shapes.Add(Sprite);
    }

    // Метод для рисования
    public void DrawAll(Canvas canvas)
    {
        shapes.ForEach(shape => shape.Draw(canvas));
    }
}