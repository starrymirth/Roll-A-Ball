using UnityEngine;

public class LineRotatorScript : MonoBehaviour
{
    public Vector3 Rotation;

    void OnMouseDown()
    {
        transform.Rotate(Rotation);
    }
}
