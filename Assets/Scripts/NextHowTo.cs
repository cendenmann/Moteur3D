/* Endenmann Cyrielle
 * Projet 3D
 * NextHowTo class
 */

using UnityEngine;
using System.Collections;

public class NextHowTo : MonoBehaviour {

	public GameObject _panel;
	public GameObject _next;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Next
	public void OnNextClicked() {
		_panel.SetActive (false);
		_next.SetActive (true);
	}
}
