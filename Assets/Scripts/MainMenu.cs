/* Endenmann Cyrielle - Pavlov Catalina
 * Projet 3D
 * MainMenu class
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject _menu;
    public GameObject _mode;
    public GameObject _options;
    public GameObject _howto;
    public GameObject _player;
    public bool simple;
    public bool time;

    // Use this for initialization
    void Start()
    {
        _options.SetActive(false);
        _options.SetActive(false);
        simple = false;
        time = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    //PAVLOV Catalina
    // Play game
    public void OnPlayClicked()
    {
        _menu.SetActive(false);
        _mode.SetActive(true);
    }

    //PAVLOV Catalina
    // Load time scene
    public void OnTimeModeClicked()
    {
        _player.SetActive(true);
        _mode.SetActive(false);
        time = true;
    }

   

    //PAVLOV Catalina
    // Load simple scene
    public void OnSimpleModeClicked()
    {
        _player.SetActive(true);
        _mode.SetActive(false);
        simple = true;
    }

    public void OnTinaClicked()
    {
        if (time)
        {
            SceneManager.LoadScene("timemode");

        }
        if (simple)
        {
            SceneManager.LoadScene("game");
        }

        Time.timeScale = 1.0f;
    }

    public void OnTimClicked()
    {
        if (time)
        {
            SceneManager.LoadScene("timemodeTim");

        }
        if (simple)
        {
            SceneManager.LoadScene("gameTim");
        }

        Time.timeScale = 1.0f;
    }

    // Options
    public void OnOptionsClicked()
    {
        _menu.SetActive(false);
        _options.SetActive(true);
    }

    public void OnSetQuality(int value)
    {
        QualitySettings.SetQualityLevel(value, false);
    }

    // How to play
    public void OnHowToClicked()
    {
        _menu.SetActive(false);
        _howto.SetActive(true);
    }

    // Quit game
    public void OnQuitClicked()
    {
        Application.Quit();
    }

    // Back
    public void OnBackClicked()
    {
        _menu.SetActive(true);
        _options.SetActive(false);
        _mode.SetActive(false);
        _howto.SetActive(false);
    }

    public void OnBackClickedPlayer()
    {
        _player.SetActive(false);
        _mode.SetActive(true);
    }
}
