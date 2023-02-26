using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text displayName;
    // Start is called before the first frame update
    void Start()
    {
        displayName.text = GameOptions.input;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
