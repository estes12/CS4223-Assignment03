using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int pinCount = 0;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        pinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = pinCount.ToString();
    }
}
