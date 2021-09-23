using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject followTarget;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /// <summary>
        ///followTarget is what you want the camera to follow and moveSpeed is the speed at which it should move.
        ///Vector3.Lerp() is called to calculate the required position of the CameraMount.
        /// </summary>   
        if (followTarget != null)
        {
            transform.position = Vector3.Lerp(transform.position,
                followTarget.transform.position, Time.deltaTime * moveSpeed);
        }
        
    }
}
