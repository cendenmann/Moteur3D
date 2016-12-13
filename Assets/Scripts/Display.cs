/* Endenmann Cyrielle
 * Projet 3D
 * Affichage class
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Display : MonoBehaviour {

	public GameObject _player;

	public Sprite _spriteMetal;
	public Sprite _spritePaper;
	public Sprite _spritePlastic;
	public Sprite _spriteGlass;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	// 
	public void GiveColor(string slot, string name) {
		Image img = GameObject.Find (slot).GetComponent<Image>();
		switch (name) {
		case "metal":
			img.color = Color.white;
			img.sprite = _spriteMetal;
			break;
		case "paper":
			img.color = Color.white;
			img.sprite = _spritePaper;
			break;
		case "plastic":
			img.color = Color.white;
			img.sprite = _spritePlastic;
			break;
		case "glass":
			img.color = Color.white;
			img.sprite = _spriteGlass;
			break;
		case "":
			img.color = Color.clear;
			break;
		}
	}

	//
	public void DisplayInventory() {
		int index = _player.GetComponent<Inventory> ().LengthInventory ();
		for (int i = 1; i < 5; i++) {
			if (index >= 0) {
				GiveColor ("Slot" + i, _player.GetComponent<Inventory> ().inventory [index]);
				index--;
			} else {
				GiveColor ("Slot" + i, "");
				index--;
			}
		}
	}
}
