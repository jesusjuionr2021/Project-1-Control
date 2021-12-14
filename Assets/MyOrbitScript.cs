using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOrbitScript : MonoBehaviour
{

    [SerializeField] private GameObject objectToOrbit;

    public float radius = 5f;
    public float speed = 1f;
    private float angle = 1f;
    private Vector3 axis;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Transform position is " + this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Transform objectTransform = objectToOrbit.transform;
        Vector3 position = objectTransform.position;
        axis = Vector3.up; // shorthand for (0, 1, 0)
        angle += Time.deltaTime * speed;
        this.transform.RotateAround(position, axis, angle);
    }
}
