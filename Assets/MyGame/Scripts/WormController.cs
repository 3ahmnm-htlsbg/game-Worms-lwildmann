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
    public KeyCode forwardkey;
    public Keycode backkey;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpkey))
        {
            Debug.Log("Die Jump-Taste wurde gedrückt");
            // Dieser Code wird ausgeführt sobald die in der Variable ausgewählte Taste gedrückt wird. (Kannst du ihm Unity auswählen).
            rb.AddForce(x,f);
        }

        if (Input.GetKeyDown(forwardkey))
        {
            Debug.Log("Die Forward-Taste wurde gedrückt");
            rb.AddForce(y,f);
        }

        if (Input.GetKeyDown(backkey))
        {
            Debug.Log("Die Back-Taste wurde gedrückt");
            rb.AddForce(-forwardkey);
        }
    }
}
