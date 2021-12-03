using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float radius = 5;
    // Start is called before the first frame update
    void Start()
    {

        Vector3 position = radius * Random.insideUnitSphere;
        Instantiate(prefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
