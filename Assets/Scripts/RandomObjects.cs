/* Pavlov Catalina
 * Projet 3D
 * Random Objects
 */
using UnityEngine;
using System.Collections;

public class RandomObjects : MonoBehaviour
{
    public GameObject[] rubish = new GameObject[20];
    public int numberEach;
    public float min, max, minr, maxr;
    public ArrayList arrayList = new ArrayList();
    object[] arrayObjects = new object[4];

    void Start()
    {
        PlaceRubbish();
    }

    void PlaceRubbish()
    {
        for (int i = 0; i < rubish.Length; i++)
        {
            for (int j = 0; j < numberEach; j++)
            {
                var v = (GameObject)Instantiate(rubish[i], GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
                v.AddComponent<BoxCollider>().isTrigger = true;
                v.AddComponent<Collect>();
                v.AddComponent<Rigidbody>();
                v.AddComponent<CapsuleCollider>();
            }
          
        }
    }

    Vector3 GeneratedPosition()
    {
        float x, y, z;
        x = Random.Range(min, max);
        y = 10f;
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