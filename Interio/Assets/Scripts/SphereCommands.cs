using UnityEngine;

public class SphereCommands : MonoBehaviour
{
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        var a = this.gameObject.GetComponent<Renderer>();
        a.material.color = Random.ColorHSV();
    }
}
