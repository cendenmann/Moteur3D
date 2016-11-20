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
        PlaceCubes();
    }

    void PlaceCubes()
    {

        for (int i = 0; i < numberOfObjects; i++)
        {
            Instantiate(paper, GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
            Instantiate(plastic, GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
            Instantiate(metal, GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
            Instantiate(glass, GeneratedPosition(), Quaternion.Euler(GeneratedRotation()));
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