using UnityEngine;
using UnityEngine.UI;

public class ShadowGameScript : MonoBehaviour
{
    private static int count;
    public Text countText;
    public Text winText;
    public GameObject[] Lines;

    void Start()
    {
        count = 0;
        setCountText();
        winText.text = "";
    }

    void Update()
    {
        bool won = true;
        foreach (var line in Lines)
        {
            Vector3 angles = line.gameObject.transform.rotation.eulerAngles;
            bool isvalid = Mathf.Abs(angles.x % 180) < 0.01
                        && Mathf.Abs(angles.y % 180) < 0.01
                        && Mathf.Abs(angles.z % 180) < 0.01;
            won = won && isvalid;
        }
        if (won)
        {
            winText.text = "You Win!";
            if (count == 10)
            {
                winText.text += "*";
            }
        }
    }

    public void IncrementCount()
    {
        count += 1;
        setCountText();
    }

    void setCountText()
    {
        countText.text = string.Format("Score: {0}", count);
    }
}
