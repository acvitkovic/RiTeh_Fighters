using UnityEngine;
using UnityEngine.UI;

public class ChangeAlpha : MonoBehaviour
{
    private Image image; // Reference to the image component

    public void lowerAlpha()
    {
        // Get the image component attached to the same game object as this script
        image = GetComponent<Image>();

        // Set the image's color with half alpha
        Color color = image.color;
        color.a = 0.3f;
        image.color = color;
    }

    public void maxAlpha()
    {
        image = GetComponent<Image>();

        Color color = image.color;
        color.a = 1f;
        image.color = color;
    }
}
