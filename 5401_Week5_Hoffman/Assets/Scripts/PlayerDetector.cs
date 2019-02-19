using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, fwd, out hit, 5))
        {
            if (hit.collider.tag == "Obstacle")
            {
                Debug.Log(hit.transform.gameObject + " is detected!");
            }
            
        }
        else
        {
            Debug.Log("Nothing ahead!");
        }
    }
}
