using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    // Start is called before the first frame update

    int myNum;
    public int GiftNum;
    public GameObject Box;
    public GameObject Gift;
    public Text numTxt;
    public GameObject B_Reset;

    void Start()
    {
        numTxt.text = "0";

        GiftNum = 10;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     public void Click()
        {
            myNum++;
            numTxt.text = myNum.ToString ();
            Debug.Log("myNum : " + myNum);
            if(myNum == GiftNum) {
                Gift.SetActive(true);
                Box.SetActive(false);
                B_Reset.SetActive(true);
            }
        }

    public void Onclick()
    {
        Gift.SetActive(false);
                Box.SetActive(true);
                B_Reset.SetActive(false);

        myNum = 0;
        numTxt.text = myNum.ToString ();
    }
}
