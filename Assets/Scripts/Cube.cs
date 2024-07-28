using UnityEngine;

public class Cube : Shape
{
    private void OnMouseDown()
    {
        DisplayText();
    }

    public override void DisplayText()
    {
        if (DisplayTextComponent != null)
        {
            string colorName = GetColorName(ShapeColor);
            DisplayTextComponent.text = $"This is a {colorName} cube named {ShapeName}.";
        }
    }
}
