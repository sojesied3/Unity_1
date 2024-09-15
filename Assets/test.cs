using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    
public class test : MonoBehaviour
{
    //Variable
    float a = 0;
    float b = 7;
    float c = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Function
    void Update()
    {
        //Variable
        b = b+1f;
        a = a+1f;
        c = c+1f;
        //transform.position = new Vector3(10, a, b);
        //Function
        transform.rotation = new Quaternion(a, b, c, 1);
        
    }
}
