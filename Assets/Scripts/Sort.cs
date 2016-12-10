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

	public Text _score;
	private int scoreValue = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void OnGlassClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item == "glass") {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
			scoreValue++;
		} else {
			scoreValue--;
		}
		UpdateScore ();
	}

	public void OnPlasticClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item == "plastic") {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
			scoreValue++;
		} else {
			scoreValue--;
		}
		UpdateScore ();
	}

	public void OnPaperClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item == "paper") {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
			scoreValue++;
		} else {
			scoreValue--;
		}
		UpdateScore ();
	}

	public void OnMetalClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item == "metal") {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
			scoreValue++;
		} else {
			scoreValue--;
		}
		UpdateScore ();
	}

	public void UpdateScore() {
		if (scoreValue < 0) {
			scoreValue = 0;
		}
		_score.text = scoreValue.ToString ();
	}
}
