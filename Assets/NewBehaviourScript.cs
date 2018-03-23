using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    Rigidbody rb;

    public Text countText;
    public Text winText;

    int count;
    public float speed;

	// Use this for initialization
	void Start () {
		
        rb=GetComponent<Rigidbody>();

        countText.text =" 0";
        countText.text = "分數:";
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //transform.Translate(x,0,z);
        rb.AddForce(new Vector3(x,0,z) * speed);

	}

    void OnTriggerEnter(Collider other) { 
        
           
            other.gameObject.SetActive(false);
            count++;
            countText.text = "分數:" + count.ToString();

        if(count>=2){
            winText.text = "You Win!";
        }
            
    }
}
