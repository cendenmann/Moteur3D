/* Endenmann Cyrielle
 * Projet 3D
 * Sort class
 */

using UnityEngine;
using System.Collections;

public class Sort : MonoBehaviour {

	public GameObject _player;
	public GameObject _sort;

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
		}
	}

	public void OnPlasticClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item == "plastic") {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
		}
	}

	public void OnPaperClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item == "paper") {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
		}
	}

	public void OnMetalClicked () {
		string item = _player.GetComponent<Inventory> ().LastItem ();
		if (item == "metal") {
			if (_player.GetComponent<Inventory> ().RemoveLastItem ()) {
				_sort.GetComponent<Display> ().DisplayInventory ();
			}
		}
	}
}
