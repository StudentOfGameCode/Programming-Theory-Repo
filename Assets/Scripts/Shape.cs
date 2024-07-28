using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    public string ShapeName { get; set; }
    public Color ShapeColor { get; set; }
    public TextMeshProUGUI DisplayTextComponent { get; set; } // Add this line

    public abstract void DisplayText();

    protected string GetColorName (Color color)
    {
         if (color == Color.red) return "Red";
         if (color == Color.green) return "Green";
         if (color == Color.blue) return "Blue";
        return "Unkown Color";
    }
}
