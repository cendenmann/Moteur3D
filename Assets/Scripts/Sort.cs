/* Endenmann Cyrielle
 * Projet 3D
 * Sort class
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sort : MonoBehaviour {

	public GameObject _player;
	public GameObject _sort;
	public GameObject _next;
	public GameObject _sortMenu;
	public GameObject _collect;
	public GameObject _interface;
	public GameObject _erreur;

	public Text _score;
	public Text _scoreNext;
	private int scoreValue = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void OnGlassClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item.StartsWith("glass")) {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
			scoreValue++;
		} else {
			_erreur.SetActive (true);
			Time.timeScale = 0.0f;
			scoreValue--;
		}
		UpdateScore ();
	}

	public void OnPlasticClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item.StartsWith("plastic")) {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
			scoreValue++;
		} else {
			_erreur.SetActive (true);
			Time.timeScale = 0.0f;
			scoreValue--;
		}
		UpdateScore ();
	}

	public void OnPaperClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item.StartsWith("paper")) {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
			scoreValue++;
		} else {
			_erreur.SetActive (true);
			Time.timeScale = 0.0f;
			scoreValue--;
		}
		UpdateScore ();
	}

	public void OnMetalClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item.StartsWith("metal")) {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
			scoreValue++;
		} else {
			_erreur.SetActive (true);
			Time.timeScale = 0.0f;
			scoreValue--;
		}
		UpdateScore ();
	}

	public void OnBackClicked() {
		_sortMenu.SetActive(false);
		_collect.SetActive (true);
		Time.timeScale = 1.0f;
		Cursor.visible = false;
	}

	public void OnEndClicked() {
		_sortMenu.SetActive (false);
		_next.SetActive (true);
	}

	public void OnEndTimeClicked() {
		_interface.GetComponent<GameInterface2> ().UpdateTimeSort (0.0f);
	}

	public void OnOkClicked() {
		_erreur.SetActive (false);
		Time.timeScale = 1.0f;
	}

	public void UpdateScore() {
		if (scoreValue < 0) {
			scoreValue = 0;
		}
		_score.text = scoreValue.ToString ();
		DisplayScore();
	}

	public void DisplayScore() {
		_scoreNext.text = _score.text;
	}
}
