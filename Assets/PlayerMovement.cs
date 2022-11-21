using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0){
            transform.Translate(transform.right * movementSpeed * Time.deltaTime, Space.World);
        } else if(Input.GetAxisRaw("Horizontal") < 0){
            transform.Translate(-transform.right * movementSpeed * Time.deltaTime, Space.World);
        }
        if(Input.GetAxisRaw("Vertical") > 0){
            transform.Translate(transform.up * movementSpeed * Time.deltaTime, Space.World);
        } else if(Input.GetAxisRaw("Vertical") < 0){
            transform.Translate(-transform.up * movementSpeed * Time.deltaTime, Space.World);
        }
    }
}
