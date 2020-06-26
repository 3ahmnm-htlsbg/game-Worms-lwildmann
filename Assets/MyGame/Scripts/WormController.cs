using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 x;
    public Vector3 y;
    public Vector3 position;
    public Quaternion quat;
    public ForceMode f;
    public KeyCode jumpkey;
    public KeyCode forwardkey;
    public KeyCode backkey;
    public KeyCode downkey;
    public KeyCode shootkey;
    public GameObject spawnLocation;

    public GameObject projectile;
    
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
            rb.AddForce( y * (-1));
        }

        if (Input.GetKeyDown(downkey))
        {
            Debug.Log("Die Down-Taste wurde gedrückt");
            rb.AddForce(x * (-1));
        }

        if (Input.GetKeyDown(shootkey))
        {
            Debug.Log("Pew Pew");
            position = spawnLocation.transform.position;
            Instantiate(projectile, position, quat);
        }
    }

   

    //Prefab -> pre fabricated = vorab gebaut
}
