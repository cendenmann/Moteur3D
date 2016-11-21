using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameInterface : MonoBehaviour {

    public GameObject _ingameMenu;
	// Use this for initialization
	void Start () {
        _ingameMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
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
}
