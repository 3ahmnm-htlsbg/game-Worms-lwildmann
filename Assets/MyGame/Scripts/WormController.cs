using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 x;
    public Vector3 y;
    public ForceMode f;
    public KeyCode jumpkey;
    public KeyCode sidekey;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpkey))
        {
            Debug.Log("Die Jump-Taste wurde gedrückt");
            // Dieser Code wird ausgeführt sobald die in der Variable ausgewählte Taste gedrückt wird. (Kannst du ihm Unity auswählen).
            rb.AddForce(x,f);
        }

        if (Input.GetKeyDown(sidekey))
        {
            Debug.Log("Die Side-Taste wurde gedrückt");
            rb.AddForce(y,f);
        }
    }
}
