/* Endenmann Cyrielle
 * Projet 3D
 * Affichage class
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Affichage : MonoBehaviour {

	public GameObject _player;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	// 
	public void Couleur(string slot, string name) {
		Image img = GameObject.Find (slot).GetComponent<Image>();
		switch (name) {
		case "metal":
			img.color = Color.red;
			break;
		case "paper":
			img.color = Color.blue;
			break;
		case "plastic":
			img.color = Color.yellow;
			break;
		case "glass":
			img.color = Color.green;
			break;
		case "":
			img.color = Color.clear;
			break;
		}
	}

	//
	public void DisplayInventory() {
		int index = _player.GetComponent<Inventory> ().LengthInventory () - 1;
		for (int i = 1; i < 5; i++) {
			if (index >= 0) {
				Couleur ("Slot" + i, _player.GetComponent<Inventory> ().inventory [index]);
				index--;
			} else {
				Couleur ("Slot" + i, "");
				index--;
			}
		}
	}
}
