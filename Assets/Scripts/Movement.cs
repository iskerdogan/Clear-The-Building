using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpPower;
    [SerializeField]
    private float turnSpeed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TakeInput();
    }

    private void TakeInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, Mathf.Clamp((jumpPower * 100) * Time.deltaTime, 0f, 7f), 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(Mathf.Clamp((speed * 100) * Time.deltaTime, 0f, 7f), rb.velocity.y, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, -180f, 0f), turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(Mathf.Clamp((-speed * 100) * Time.deltaTime, -7f, 0f), rb.velocity.y, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 0f), turnSpeed * Time.deltaTime);
        }
        else
        {
            rb.velocity = new Vector3(0f, rb.velocity.y, 0f);
        }
    }
}
