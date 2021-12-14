using UnityEngine;
using UnityEngine.InputSystem;

public class ReportMouseProblem : MonoBehaviour
{
    void Update()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();

        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("A key was pressed" + mousePosition.ToString());
        }

       
    }
}
