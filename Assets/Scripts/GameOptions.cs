using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class GameOptions : MonoBehaviour
{
        public InputField playerInput;
        public static string input;
        public Text playerName;

        public GameObject pin;
        public AudioSource AudioSource;
        public Toggle soundToggle;
        public static bool sound;

        public Slider rotatorSlider;
        public static float rotatorSpeed = 100f;

        public Slider pinSlider;
        public static float pinSpeed = 20f;

        public Dropdown colorDropdown;
        public GameObject rotatorColor;
        public static int color = 0;

    public void PlayerName()
    {
        input = playerInput.text;
        playerName.text = input;
    }

    public void DisplayName()
    {
        playerName.text = input;
    }
    public void SoundToggle()
    {
        if (soundToggle.isOn)
        {
            pin.GetComponent<AudioSource>().Play();
        }

        else
        {
            pin.GetComponent<AudioSource>().Pause();
        }
        sound = soundToggle;
    }

    public void RotatorSpeed()
    {
        rotatorSpeed = rotatorSlider.value;
    }

    public void PinSpeed()
    {
        pinSpeed = pinSlider.value;
    }

    public void RotatorColor()
    {
        switch (colorDropdown.value)
        {
            case 1:
                rotatorColor.GetComponent<SpriteRenderer>().color = Color.magenta;
                color = colorDropdown.value;
                break;
            case 2:
                rotatorColor.GetComponent<SpriteRenderer>().color = Color.green;
                color = colorDropdown.value;
                break;
            case 3:
                rotatorColor.GetComponent<SpriteRenderer>().color = Color.blue;
                color = colorDropdown.value;
                break;
            default:
                rotatorColor.GetComponent<SpriteRenderer>().color = Color.black;
                color = colorDropdown.value;
                break;
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        colorDropdown.value = color;
        RotatorColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
