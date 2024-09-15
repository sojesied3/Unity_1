using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ClassCode1 : MonoBehaviour
{
    
    
    public GameObject plane;
        // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        float pX = this.transform.position.x;
        float pY = this.transform.position.y;
        float pZ = this.transform.position.z;
        Debug.Log("Hammer X = " + transform.position.x);
        Debug.Log("Plane X = " + plane.transform.position.x);
        Debug.Log("This Hammer X = " + this.transform.position.x);
        if(Input.GetKey("a"))
        {
            //pX = pX - 0.01f;
            //pX--;
            pX -= 0.01f;
            this.transform.position = new Vector3(pX, pY, pZ);
        }
        if (Input.GetKey(KeyCode.D))
        {     
            pX = pX + 0.01f;
            this.transform.position = new Vector3(pX, pY, pZ);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            pY = pY + 0.01f;
            this.transform.position = new Vector3(pX, pY, pZ);
        }

        if (!(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)))
        {
            if (Input.GetKey(KeyCode.W))
            {
                //transform.position = new Vector3(0, 10, pZ);
                //pZ++;
                pZ += 0.01f;
                this.transform.position = new Vector3(pX, pY, pZ);
            }
            if (Input.GetKey(KeyCode.S))
            {
                pZ = pZ - 0.01f;
                this.transform.position = new Vector3(pX, pY, pZ);
            }
        }
       
    }
}
