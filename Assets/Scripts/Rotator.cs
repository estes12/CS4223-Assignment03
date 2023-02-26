using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
    public GameObject rotator;
    // Start is called before the first frame update
    void Start()
    {
        speed = GameOptions.rotatorSpeed;
        switch (GameOptions.color)
        {
            case 1:
                rotator.GetComponent<SpriteRenderer>().color = Color.magenta;                
                break;
            case 2:
                rotator.GetComponent<SpriteRenderer>().color = Color.green;               
                break;
            case 3:
                rotator.GetComponent<SpriteRenderer>().color = Color.blue;     
                break;
            default:
                rotator.GetComponent<SpriteRenderer>().color = Color.black;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
