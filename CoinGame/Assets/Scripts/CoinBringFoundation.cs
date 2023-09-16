using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBringFoundation : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Transform myTransform = this.transform;
        if (myTransform.position.z >= -16 && myTransform.position.z <= -10)
        {
            //if (rb.velocity.magnitude < 10)
            //{
                //指定したスピードから現在の速度を引いて加速力を求める
                float currentSpeed = speed - rb.velocity.magnitude;
                //調整された加速力で力を加える
                rb.AddForce(new Vector3(0, 0, currentSpeed));
            //}
        }
    }
}
