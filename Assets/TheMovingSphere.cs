using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheMovingSphere : MonoBehaviour
{
    
    int myFirstInt;
    float myFirstFloat;
    string myFirstString = "Hello";

    GameObject myFirstObject;
    Camera myMainCamera;
    SphereCollider mySphereCollider;
    TheMovingSphere myNewScript;

    [SerializeField] private Color sphereColor;

    // Runs before start
    void Awake()
    {
       
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Runs when the script is enabled
    void OnEable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("You pressed the left mouse button");
        }

        if (Input.GetKeyDown("a"))
        {
            Debug.Log("You pressed the 'a' key");
        }

        // Create a ray starting at this object and going forward.
        Ray myRay = new Ray(transform.position, transform.forward);
        RaycastHit rayHit; // Variable to store raycast output.

        if(Physics.Raycast(myRay, out rayHit, Mathf.Infinity))
        {
            // If the raycast hits something, print out it's name.
            Debug.LogFormat("You hit {0}!", rayHit.collider.name);
        }
    }

    // Used for physics calculations
    void FixedUpdate()
    {

    }

    
    void DebugExample()
    {
        // Prints messages to the Unity Console.
        Debug.Log("This is a normal log message");
        Debug.LogWarning("This is a warning message");
        Debug.LogError("This is an error message");

        // An easy way of passing arguements into debug statements.
        Debug.LogFormat("Current Time: {0}", Time.time);
        Debug.LogWarningFormat("Time Since Last Frame: {0}", Time.deltaTime);
        Debug.LogErrorFormat("Time Scale: {0}", Time.timeScale);
    }
}
