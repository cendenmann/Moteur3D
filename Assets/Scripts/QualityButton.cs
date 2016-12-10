/* Endenmann Cyrielle
 * Projet 3D
 * QualityButton class
 */

using UnityEngine;
using System.Collections;

public class QualityButton : MonoBehaviour {

	public int _quality;
	public GameObject _menu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnToggled(bool on) {
		if (on) {
			_menu.GetComponent<MainMenu> ().OnSetQuality (_quality);
		}
	}
}
