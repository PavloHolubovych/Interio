using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public static Color PickedColor = Color.red;
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        var colorTexture = this.gameObject.GetComponent<Renderer>();
        if (colorTexture!= null)
        {
            PickedColor = colorTexture.material.color;
        }
    }
}
