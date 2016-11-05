using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate () //guaranteed to run after all the other Update methods
    {
        transform.position = player.transform.position + offset;
    }
}
