using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;
    public float maxMovement = 14.0f;

    public float jumpForce = 5.0f;
    Rigidbody rd;

    private void Start()
    {
        rd = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
        Jumping();
    }

    public void Movement()
    {
        // Horizontal Movement
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 hPos = transform.position;
        hPos.x += horizontalInput * speed * Time.deltaTime;

        if (hPos.x > maxMovement)
        {
            hPos.x = maxMovement;
        }
        else if (hPos.x < -maxMovement)
        {
            hPos.x = -maxMovement;
        }
        transform.position = hPos;

        // Vertical Movement
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 vPos = transform.position;
        vPos.z += verticalInput * speed * Time.deltaTime;

        if (vPos.z > maxMovement)
        {
            vPos.z = maxMovement;
        }
        else if (vPos.z < -maxMovement)
        {
            vPos.z = -maxMovement;
        }
        transform.position = vPos;
    }

    private void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rd.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
