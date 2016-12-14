/* Endenmann Cyrielle
 * Projet 3D
 * Inventory class
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Inventory : MonoBehaviour {

	//Maximum numbers of items
	public int MaxItems;
	public string[] inventory;

	private int _number = 0;

	public GameObject _message;

	// Use this for initialization
	void Start () {
		StartInventory (MaxItems);
	}

	// Update is called once per frame
	void Update () {

	}

	// Initialisation de l'inventaire
	public void StartInventory(int mi) {
		inventory = new string[mi];

	}

	// Nombre d'objets dans l'inventaire
	// Retourne la position du dernier emplacement non vide
	public int LengthInventory() {
		if (_number > 0) {
			return _number - 1;
		} else {
			return -1;
		}
	}

	// Ajout d'un element dans l'inventaire
	public bool AddItem(string name) {
		int index = _number;
		if (index < MaxItems) {
			_number++;
			inventory [index] = name;
			return true;
		} else {
			_message.GetComponent<DisplayMessage> ().AppearMessage ();
			Debug.Log ("Inventory full");
			return false;
		}
	}

	// Retourne le dernier element de l'inventaire, empty si vide
	public string LastItem() {
		int index = LengthInventory ();
		if (index >= 0) {
			return inventory [index];
		} else {
			return string.Empty;
		}
	}

	// Retrait du dernier element dans l'inventaire
	public bool RemoveLastItem() {
		int index = LengthInventory ();
		inventory [index] = string.Empty;
		_number--;
		if (inventory [index] == string.Empty) {
			return true;
		} else {
			return false;
		}
	}
}
