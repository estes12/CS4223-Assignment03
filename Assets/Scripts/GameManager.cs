using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    public Rotator rotator;
    public Spawner spawner;
    
    public Animator animator;

    private bool isPaused;

    public GameObject resumeButton;
    public GameObject pauseMenu;
    public void EndGame()
    {
        if (gameEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameEnded = true;
      
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
        resumeButton.gameObject.SetActive(true); // show the Resume button
    }
    public void ResumeGame() // called from ESC; also attached to the resume button
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        resumeButton.gameObject.SetActive(false); // hide the Resume button while playing

    }

    public void QuitButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }



    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // ESC key pauses AND resumes
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
}
