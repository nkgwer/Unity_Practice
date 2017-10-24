using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    // speedを制御する
    public float speed = 10;

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y =0;
        if (Input.GetKey(KeyCode.Space))
        {
            y = 1;
        }
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // xとzにspeedを掛ける
        rigidbody.AddForce(x * speed, y * speed, z * speed);
    }
}