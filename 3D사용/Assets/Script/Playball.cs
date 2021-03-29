using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playball : MonoBehaviour
{

     Rigidbody rigid;
     public float jumpPower;
     bool isJump;
     public int itemCount;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        isJump=false;
    }

    void OnCollisionEnter(Collision collision) {
            if(collision.gameObject.name == "Floor")
            {
            Debug.Log("닿음");
            isJump = false;
            }
            }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h,0,v),ForceMode.Impulse);

        if(Input.GetButtonDown("Jump") && !isJump)
        {   
            Debug.Log("뚜이ㅓ");
            isJump = true;
            rigid.AddForce(new Vector3(0,jumpPower,0),ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Item")
        {
            itemCount++;
            other.gameObject.SetActive(false);
        }
    }
}
