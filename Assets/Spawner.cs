using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float radius = 5.0f;
    public int numSpheres = 20;

    [SerializeField] private Color sphereColor;

    private Renderer rend;



    public int TestInt()
    {
        return 0;
    }

    // Start is called before the first frame update

    void Start()
    {
        
        
        for (int i = 0; i < numSpheres; i++)
        {
            Vector3 position = radius * Random.insideUnitSphere;
            GameObject go = Instantiate(prefab, position, Quaternion.identity);

            rend = go.GetComponent<Renderer>();

            // check null when using GetConponent.
            if(rend != null)
            {
                Material mat = new Material(this.rend.material);
                mat.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                rend.material = mat; // rend could be null if game object has no render.
            }
            
        }
    }


    //IEnumerator Start()
    //{
    //    for(int i=0; i< numSpheres; i++)
    //    {
    //        Vector3 position = radius * Random.insideUnitSphere;
    //        Instantiate(prefab, position, Quaternion.identity);

    //        yield return new WaitForSeconds(1);
    //    }


    //    yield return null;

    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
