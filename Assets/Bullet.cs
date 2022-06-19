using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float holdDownStartTime;
    public Rigidbody2D rbFun;
    public Rigidbody2D rb;
    Transform asdfg;
    public bool flag = true;

    void Start()
    {
        rb.velocity = transform.right * Random.Range(-10f, -5f);
        asdfg = GameObject.Find("Main Circle").transform;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            rbFun.velocity = asdfg.right * Random.Range(5f, 10f);
        }
        if (flag)
        {
            flag = false;
            Invoke("downSpeed", 0.8f);
        }
    }

    void downSpeed()
    {
        rbFun.velocity -= new Vector2(rbFun.velocity.x/2, rbFun.velocity.y/2);
        flag = true;
    }
}
