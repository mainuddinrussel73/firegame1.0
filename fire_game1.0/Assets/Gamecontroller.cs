
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamecontroller : MonoBehaviour {

    bool gameHasEnded = false;
    [SerializeField]
    private GameObject gameOverMenu;

	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Gameover");
            
            gameOverMenu.SetActive(true);
            //Time.timeScale = 0;
        }
        
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
