using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpPower;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        TakeInput();
    }

    private void TakeInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, (jumpPower * 100) * Time.deltaTime, 0f);
        }
        else
        {
            print("Not Jump");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3((speed * 100) * Time.deltaTime, rb.velocity.y, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector3((-speed * 100) * Time.deltaTime, rb.velocity.y, 0f);
        }
    }
}
