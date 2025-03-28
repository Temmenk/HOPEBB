using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void EndGame ()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Debug.Log("bruhhh... stop hitting things");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}