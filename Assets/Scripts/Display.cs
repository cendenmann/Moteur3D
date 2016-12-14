/* Endenmann Cyrielle
 * Projet 3D
 * Affichage class
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Display : MonoBehaviour {

	public GameObject _player;

	public Sprite _spriteMetal1;
	public Sprite _spriteMetal2;
	public Sprite _spriteMetal3;

	public Sprite _spritePaper1;
	public Sprite _spritePaper2;
	public Sprite _spritePaper3;

	public Sprite _spritePlastic1;
	public Sprite _spritePlastic2;

	public Sprite _spriteGlass1;
	public Sprite _spriteGlass2;

	public GameObject _hand;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	// 
	public void GiveColor(string slot, string name) {
		Image img = GameObject.Find (slot).GetComponent<Image>();
		img.color = Color.white;
		switch (name) {
		case "metal1":
			img.sprite = _spriteMetal1;
			break;
		case "metal2":
			img.sprite = _spriteMetal2;
			break;
		case "metal3":
			img.sprite = _spriteMetal3;
			break;
		case "paper1":
			img.sprite = _spritePaper1;
			break;
		case "paper2":
			img.sprite = _spritePaper2;
			break;
		case "paper3":
			img.sprite = _spritePaper3;
			break;
		case "plastic1":
			img.sprite = _spritePlastic1;
			break;
		case "plastic2":
			img.sprite = _spritePlastic2;
			break;
		case "glass1":
			img.sprite = _spriteGlass1;
			break;
		case "glass2":
			img.sprite = _spriteGlass2;
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
				if (i == 1) {
					_hand.SetActive (true);
				}
				GiveColor ("Slot" + i, _player.GetComponent<Inventory> ().inventory [index]);
				index--;
			} else {
				if (i == 1) {
					_hand.SetActive (false);
				}
				GiveColor ("Slot" + i, "");
				index--;
			}
		}
	}
}
