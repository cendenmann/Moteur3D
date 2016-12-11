/* Pavlov Catalina
 * Projet 3D
 * GameInterface class for Time Mode Play
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameInterface2 : MonoBehaviour
{

    public GameObject _ingameMenu;
    public GameObject _nextLevelMenu;
    public GameObject _player;

    public Text timeText;
    private float time;

    public GameObject _sort;
    public GameObject _sortMenu;
    public GameObject _collect;

    // Use this for initialization
    void Start()
    {
        _ingameMenu.SetActive(false);
        _nextLevelMenu.SetActive(false);
        time = 60;
        UpdateTime(time);
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

        time -= Time.deltaTime;
        UpdateTime(time);
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

    //public void OnNextLevel()
    //{
    //    score = _player.GetComponent<PlayerBehaviourScript>().AddScore(0);
    //    scoreText.text = "Score : " + score;
    //    _nextLevelMenu.SetActive(true);
    //    Time.timeScale = 0.0f;
    //    Cursor.visible = true;
    //}

    void UpdateTime(float t)
    {
        int scoreInt = (int)t;
        if (t > 0)
        {
            timeText.text = scoreInt.ToString();
        }
        else
        {
            _collect.SetActive(false);
            _sortMenu.SetActive(true);
            _sort.GetComponent<Display>().DisplayInventory();
            Time.timeScale = 0.0f;
            Cursor.visible = true;
        }
        
    }
}
