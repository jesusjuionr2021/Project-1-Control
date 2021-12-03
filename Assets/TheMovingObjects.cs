using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheMovingObjects : MonoBehaviour
{
    // Runs before start
    private void Awake()
    {
        Debug.Log("Awake method called. ");

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start method called. ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Used for physics calculations
    private void FixedUpdate()
    {

    }
}
