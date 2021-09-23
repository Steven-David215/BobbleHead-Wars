using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime; //time.deltatime is important and makes things work.
        pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = pos; //updates the gameobject which could be represented using 'this.' but isn't necessary.
    }
}
