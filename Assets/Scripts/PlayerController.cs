using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 20;
    private float rotateSpeed = 50;
    public int force = 10;
    public Rigidbody rb;
 
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.left * Time.deltaTime * speed* vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,1,0) * force, ForceMode.Impulse);
            Debug.Log("пробел");
        }
    }
}
