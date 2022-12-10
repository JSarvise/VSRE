using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject GameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelScript.numPieces == 0)
        {
            GameOver();
        }
        
    }
    public void pauseGame()
    {
        PausePanel.SetActive(true);
        moved.isPaused= true;
    }
    public void ResumeGame()
    {
        PausePanel.SetActive(false);
        moved.isPaused = false;
    }
    public void GameOver()
    {
        if (LevelScript.numPieces == 0)
        {
            LevelScript.numPieces = 5;
            GameOverPanel.SetActive(true);
            moved.isPaused = true;
        }
    }
}
