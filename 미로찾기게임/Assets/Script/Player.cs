using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int move_method;
    public Vector2 speed_vec;
    public float speed;
    public Text score;
    public int num;
    public GameObject Image;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "0";
        Image.SetActive(false);
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
            num++;
            score.text=num.ToString();
        }
        else if(collision.CompareTag("enemy"))
        {
            Destroy(gameObject);
            Image.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {   
        if(move_method == 0)
        {
        speed_vec = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed_vec.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed_vec.x -= speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed_vec.y += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed_vec.y -= speed;
        }
        transform.Translate(speed_vec);
        }
        else if(move_method == 1)
        {
            speed_vec.x = Input.GetAxis("Horizontal")*speed;
            speed_vec.y = Input.GetAxis("Vertical")*speed;

            transform.Translate(speed_vec);
        }
        else if(move_method == 2)
        {
        speed_vec = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed_vec.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed_vec.x -= speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed_vec.y += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed_vec.y -= speed;
        }
        GetComponent<Rigidbody2D>().velocity = speed_vec;
        }
    }
}
