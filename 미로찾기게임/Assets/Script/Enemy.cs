using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
   float ran;
   float ran1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ran = Random.Range(-0.2F,0.2F);
        ran1 = Random.Range(-0.1f,0.1f);
        transform.Translate(new Vector2(ran,ran1));

    }
}
