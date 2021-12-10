using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float radius = 5;
    public int numSpheres = 20;
    // Start is called before the first frame update

    public int TestInt()
    {
        return 0;
    }

    
    IEnumerator Start()
    {
        for(int i=0; i< numSpheres; i++)
        {
            Vector3 position = radius * Random.insideUnitSphere;
            Instantiate(prefab, position, Quaternion.identity);

            yield return new WaitForSeconds(1);
        }


        yield return null;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
