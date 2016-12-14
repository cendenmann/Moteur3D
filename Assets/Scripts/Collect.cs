/* Endenmann Cyrielle - Pavlov Catalina
 * Projet 3D
 * Collect class
 */

using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour
{

    public int scoreValue = 1;
    private bool remaining;
    private bool isSortMode;

    void Start()
    {

    }

    void OnTriggerEnter(Collider intruder)
    {

        if (intruder.tag == "Player")
        {

            isSortMode = intruder.GetComponent<PlayerBehaviourScript>().isSortModeOn();
            // Cyrielle - Partie Inventory
            if (isSortMode == false)
            {

                switch (this.gameObject.tag)
                {
                    case "paper":
						remaining = intruder.GetComponent<Inventory>().AddItem(this.gameObject.name.Substring(0,6));
                        break;
                    case "metal":
						remaining = intruder.GetComponent<Inventory>().AddItem(this.gameObject.name.Substring(0,6));
                        break;
                    case "glass":
						remaining = intruder.GetComponent<Inventory>().AddItem(this.gameObject.name.Substring(0,6));
                        break;
                    case "plastic":
						remaining = intruder.GetComponent<Inventory>().AddItem(this.gameObject.name.Substring(0,8));
                        break;
                }

                // Catalina - Partie PlayerBehaviour
                if (remaining)
                {
                    intruder.GetComponent<PlayerBehaviourScript>().AddScore(scoreValue);
                    Destroy(this.gameObject);
                    intruder.GetComponent<PlayerBehaviourScript>().SendMessage("OnCollect");
                }
            }

        }
    }
}
