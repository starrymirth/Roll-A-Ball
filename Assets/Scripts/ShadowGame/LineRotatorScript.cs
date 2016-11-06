using UnityEngine;

public class LineRotatorScript : MonoBehaviour
{
    public Vector3 Rotation;
    public ShadowGameScript shadowScript; 

    void OnMouseDown()
    {
        transform.Rotate(Rotation);
        shadowScript.IncrementCount();
    }
}
