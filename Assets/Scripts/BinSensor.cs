/* Endenmann Cyrielle
 * Projet 3D
 * BinSensor class
 */

using UnityEngine;
using System.Collections;

public class BinSensor : MonoBehaviour {
	
	public GameObject _sort;
	public GameObject _sortMenu;
	public GameObject _collect;
	public GameObject _wait;

	public bool timeMode;

	// Use this for initialization
	void Start () {
		_sortMenu.SetActive (false);
		_collect.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown(KeyCode.Backspace))
		{
			_sortMenu.SetActive(false);
			_collect.SetActive (true);
			Time.timeScale = 1.0f;
			Cursor.visible = false;
		}
	}

	void OnTriggerEnter(Collider intruder) {
		if (intruder.tag == "Player" && !timeMode) {
			_collect.SetActive (false);
			_sortMenu.SetActive (true);
			_sort.GetComponent<Display> ().DisplayInventory ();
			Time.timeScale = 0.0f;
			Cursor.visible = true;
		}
	}
}
