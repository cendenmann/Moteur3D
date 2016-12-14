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
            Debug.Log(isSortMode);
            // Cyrielle - Partie Inventory
            if (isSortMode == false)
            {

                switch (this.gameObject.tag)
                {
                    case "paper":
                        remaining = intruder.GetComponent<Inventory>().AddItem("paper");
                        break;
                    case "metal":
                        remaining = intruder.GetComponent<Inventory>().AddItem("metal");
                        break;
                    case "glass":
                        remaining = intruder.GetComponent<Inventory>().AddItem("glass");
                        break;
                    case "plastic":
                        remaining = intruder.GetComponent<Inventory>().AddItem("plastic");
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
