using UnityEngine;

public class LineRotatorScript : MonoBehaviour
{
    public Vector3 Rotation;
    public ShadowGameScript shadowScript;
    public AudioClip rotateSound;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        rotateSound.LoadAudioData();
    }

    void OnMouseDown()
    {
        float volume = Random.Range(0.1f, 0.3f);
        source.PlayOneShot(rotateSound, volume);

        transform.Rotate(Rotation);
        shadowScript.IncrementCount();
        
    }
}
