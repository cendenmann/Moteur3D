/* Pavlov Catalina - Endenmann Cyrielle
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
	public GameObject _sortMenu;

    public GameObject _player;

	public Text _score;
	private int score;
    public Text timeText;
	public Text timeTextsort;
    private float time;

    public GameObject _sort;
    
    public GameObject _collect;
	public GameObject _time;
	public GameObject _timesort;

    //public GameObject _player;

	private int sort = 0;

    // Use this for initialization
    void Start()
    {
        _ingameMenu.SetActive(false);
        _nextLevelMenu.SetActive(false);
        time = 10;
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
		if (sort == 0) {
			UpdateTime (time);
		} else if (sort == 1) {
			UpdateTimeSort (time);
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


    void UpdateTime(float t)
    {
        int scoreInt = (int)t;
        if (t > 0)
        {
            timeText.text = scoreInt.ToString();
        }
        else
        {
            _player.GetComponent<PlayerBehaviourScript>().isSortMode = true;
            _collect.SetActive(false);
			_time.SetActive (false);
            _sortMenu.SetActive(true);
			_timesort.SetActive (true);
            _sort.GetComponent<Display>().DisplayInventory();
            Cursor.visible = true;
			sort = 1;
			time = 30;
        }
        
    }

	// Endenmann Cyrielle - Time Sort
	public void UpdateTimeSort(float t) {
		int scoreInt = (int)t;
		if (t > 0) {
			timeTextsort.text = scoreInt.ToString ();
		} else {
			_timesort.SetActive (false);
			_sortMenu.SetActive (false);
			_nextLevelMenu.SetActive (true);
            Time.timeScale = 0.0f;
			score = int.Parse (_score.text.ToString ()) + (int)time;
			_score.text = score.ToString ();
			sort = 2;
		}
	}
}
