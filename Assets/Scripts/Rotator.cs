using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update ()
    {
        float xRotationAngle = 15;
        float yRotationAngle = 30;
        float zRotationAngle = 45;

        transform.Rotate(new Vector3(xRotationAngle, yRotationAngle, zRotationAngle) * Time.deltaTime);
    }
}
