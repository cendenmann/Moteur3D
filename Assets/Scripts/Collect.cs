﻿/* Endenmann Cyrielle - Pavlov Catalina
 * Projet 3D
 * Inventory class
 */

using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	public int scoreValue = 1;

	void Start()
	{

	}

	void OnTriggerEnter(Collider intruder)
	{

        if (intruder.tag == "Player")
        {
            // Cyrielle - Partie Inventory
            switch (this.gameObject.tag)
            {
                case "paper":
                    intruder.GetComponent<Inventory>().AddItem("paper");
                    break;
                case "metal":
                    intruder.GetComponent<Inventory>().AddItem("metal");
                    break;
                case "glass":
                    intruder.GetComponent<Inventory>().AddItem("glass");
                    break;
                case "plastic":
                    intruder.GetComponent<Inventory>().AddItem("plastic");
                    break;
            }
            // Catalina - Partie PlayerBehaviour
            intruder.GetComponent<PlayerBehaviourScript>().AddScore(scoreValue);
            Destroy(this.gameObject);
            intruder.GetComponent<PlayerBehaviourScript>().SendMessage("OnCollect");
        }
	}    
}
