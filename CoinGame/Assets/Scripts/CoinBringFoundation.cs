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
                //�w�肵���X�s�[�h���猻�݂̑��x�������ĉ����͂����߂�
                float currentSpeed = speed - rb.velocity.magnitude;
                //�������ꂽ�����͂ŗ͂�������
                rb.AddForce(new Vector3(0, 0, currentSpeed));
            //}
        }
    }
}
