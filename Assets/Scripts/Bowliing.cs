using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class Bowliing : MonoBehaviour
{

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    int forcePower;

    [SerializeField]
    float Increment;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           ShootBowl();
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
    }
    public void ShootBowl()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);   
    }
    public void MoveLeft()
    {
        transform.position += new Vector3(-Increment, 0f, 0f);
    }
    public void MoveRight()
    {
        transform.position += new Vector3(Increment, 0f, 0f);
    }

}
