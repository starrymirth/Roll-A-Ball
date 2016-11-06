using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int count;
    public Text countText;
    public Text winText;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            source.Play();
            other.gameObject.SetActive(false);
            count += 1;
            setCountText();
            if (count >= 8)
            {
                winText.text = "You Win!";
            }
        }
    }

    void setCountText()
    {
        countText.text = string.Format("Score: {0}", count);
    }
}
