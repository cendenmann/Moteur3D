using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameInterface : MonoBehaviour
{

    public GameObject _ingameMenu;
    public GameObject _nextLevelMenu;
    public GameObject _player;

    public Text scoreText;
    private int score;

    // Use this for initialization
    void Start()
    {
        _ingameMenu.SetActive(false);
        _nextLevelMenu.SetActive(false);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _ingameMenu.SetActive(true);
            Time.timeScale = 0.0f;
            Cursor.visible = true;
        }
    }

    public void OnResumeClicked()
    {
        _ingameMenu.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.visible = false;
    }
    //using UnityEngine.SceneManagement;
    public void OnRestartClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }
    public void OnQuitClicked()
    {
        SceneManager.LoadScene("mainMenu");
        Time.timeScale = 1.0f;
    }

    public void OnNextLevel()
    {
        score = _player.GetComponent<PlayerBehaviourScript>().AddScore(0);
        scoreText.text = "Score : " +  score;
        _nextLevelMenu.SetActive(true);
        Time.timeScale = 0.0f;
        Cursor.visible = true;
    }

    public void OnNextClicked()
    {
        SceneManager.LoadScene("nextGame");
        Time.timeScale = 1.0f;
    }
}
