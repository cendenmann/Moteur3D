/* Endenmann Cyrielle
 * Projet 3D
 * Inventory class
 */

using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	//Maximum numbers of items
	public static int MaxItems = 200;
	public string[] inventory = new string[MaxItems];

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	// Nombre d'objets dans l'inventaire
	public int LengthInventory() {
		for (int i = 0; i < inventory.Length; i++) {
			if (inventory [i] == string.Empty) {
				return i;
			}
		}
		// Plus de places disponibles
		return inventory.Length;
	}

	// Ajout d'un element dans l'inventaire
	public bool AddItem(string name) {
		if (LengthInventory () < MaxItems) {
			int index = LengthInventory ();
			inventory [index] = name;
			return true;
		} else {
			Debug.Log ("Inventory full");
			return false;
		}
	}

	// Retourne le dernier element de l'inventaire, empty si vide
	public string LastItem() {
		int index = LengthInventory ()-1;
		if (index >= 0) {
			return inventory [index];
		} else {
			return string.Empty;
		}
	}

	// Retrait du dernier element dans l'inventaire
	public bool RemoveLastItem() {
		int index = LengthInventory () - 1;
		inventory [index] = string.Empty;
		if (inventory [index] == string.Empty) {
			return true;
		} else {
			return false;
		}
	}
}
