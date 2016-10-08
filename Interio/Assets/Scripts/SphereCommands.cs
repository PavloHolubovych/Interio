using UnityEngine;

public class SphereCommands : MonoBehaviour
{
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        var textureToFill = this.gameObject.GetComponent<Renderer>();
        if (textureToFill)
        {
            textureToFill.material.color = ColorPicker.PickedColor;
        }
    }
}
