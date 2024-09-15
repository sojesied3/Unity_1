using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public GameObject wheels;
    float a;
    float b = 0;
    float c = 5;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float z = this.transform.position.z;
        if (Input.GetKey(KeyCode.W))
        {
            //this.transform.position = new Vector3(x, y, z + 0.1f);
            this.transform.Translate(0, 0, 0.1f);
            wheels.transform.Rotate(0.1f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector3(x, y, z - 0.01f);
        }
    }
}
