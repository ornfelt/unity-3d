using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    // Public makes it available for change in the inspector
    public float mouseSensitivity = 100f;
 
    float xRotation = 0f; // Rotation around x-asis (see transform on Player)
    float YRotation = 0f; // Rotation around y-axis (see transform on Player)
 
    void Start()
    {
      // Locking the cursor to the middle of the screen and making it invisible
      Cursor.lockState = CursorLockMode.Locked;
    }
 
    // Update is called once per frame
    void Update()
    {
       float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
       float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
 
       // Control rotation around x axis (Look up and down)
       xRotation -= mouseY;
 
       // We clamp the rotation so we cant Over-rotate (like in real life)
       xRotation = Mathf.Clamp(xRotation, -90f, 90f);
 
       // Control rotation around y axis (Look up and down)
       YRotation += mouseX;
 
       // Applying both rotations, Euler deals with x and y
       transform.localRotation = Quaternion.Euler(xRotation, YRotation, 0f); // Z rotation 0f
    }
}
