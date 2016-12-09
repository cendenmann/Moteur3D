/* Endenmann Cyrielle
 * Projet 3D
 * BinSensor class
 */

using UnityEngine;
using System.Collections;

public class BinSensor : MonoBehaviour {
	
	public GameObject _tri;

	// Use this for initialization
	void Start () {
		_tri.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown(KeyCode.Backspace))
		{
			_tri.SetActive(false);
			Time.timeScale = 1.0f;
			Cursor.visible = false;
		}
	}

	void OnTriggerEnter(Collider intruder) {
		if (intruder.tag == "Player") {
			_tri.SetActive (true);
			_tri.GetComponent<Display> ().DisplayInventory();
			Time.timeScale = 0.0f;
			Cursor.visible = true;
		}
	}
}
