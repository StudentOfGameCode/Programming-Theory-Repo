using UnityEngine;
using TMPro;

public class ShapeManager : MonoBehaviour
{
    public GameObject SpherePrefab;
    public GameObject CubePrefab;
    public GameObject CylinderPrefab;
    public TextMeshProUGUI DisplayText; // Add this line

    void Start()
    {
        if (SpherePrefab == null || CubePrefab == null || CylinderPrefab == null || DisplayText == null)
        {
            Debug.LogError("One or more prefabs or DisplayText are not assigned in the Inspector.");
            return;
        }

        CreateShape(SpherePrefab, "Sphere", Color.red);
        CreateShape(CubePrefab, "Cube", Color.green);
        CreateShape(CylinderPrefab, "Cylinder", Color.blue);
    }

    void CreateShape(GameObject shapePrefab, string name, Color color)
    {
        Debug.Log($"Creating shape: {name}");
        GameObject shapeObject = Instantiate(shapePrefab);
        Shape shape = shapeObject.GetComponent<Shape>();
        if (shape == null)
        {
            Debug.LogError("Shape component is missing on the prefab.");
            return;
        }
        shape.ShapeName = name;
        shape.ShapeColor = color;
        shapeObject.GetComponent<Renderer>().material.color = color;
        shape.DisplayTextComponent = DisplayText; // Assign the TMP text component to the shape
    }
}
