/* Pavlov Catalina
 * Projet 3D
 * Random Objects
 */
using UnityEngine;
using System.Collections;

public class RandomObjects : MonoBehaviour
{

    public GameObject paper, plastic, metal, glass;
    public int numberOfObjects;
    public float min, max, minr, maxr;
    public ArrayList arrayList = new ArrayList();

    void Start()
    {
        PlaceRubbish();
    }

    void PlaceRubbish()
    {

        for (int i = 0; i < numberOfObjects; i++)
        {
            var v1 = (GameObject)Instantiate(paper, GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
            var v2 = (GameObject)Instantiate(plastic, GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
            var v3 = (GameObject)Instantiate(metal, GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
            var v4 = (GameObject)Instantiate(glass, GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
            v1.AddComponent<BoxCollider>().isTrigger = true;
            v2.AddComponent<BoxCollider>().isTrigger = true;
            v3.AddComponent<BoxCollider>().isTrigger = true;
            v4.AddComponent<BoxCollider>().isTrigger = true;
            v1.AddComponent<Collect>();
            v2.AddComponent<Collect>();
            v3.AddComponent<Collect>();
            v4.AddComponent<Collect>();
        }
    }

    Vector3 GeneratedPosition()
    {
        float x, y, z;
        x = Random.Range(min, max);
        y = 0.1f;
        z = Random.Range(min, max);

        Vector3 pos = new Vector3(x, y, z);

        if (arrayList.IndexOf(pos) != -1)
        {
            return Vector3.zero;
        }
        else
        {
            arrayList.Add(pos);
            return pos;
        }
    }

    Vector3 GeneratedRotation()
    {
        float x, y, z;
        x = Random.Range(minr, maxr);
        y = Random.Range(minr, maxr);
        z = Random.Range(minr, maxr);
        return new Vector3(x, y, z);
    }
}