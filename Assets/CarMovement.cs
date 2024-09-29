using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public GameObject frontleft_wheel;
    public GameObject frontright_wheel;
    public GameObject backleft_wheel;
    public GameObject backright_wheel;
    public GameObject LeftTurn;
    public GameObject RightTurn;
    float a;
    float b = 0;
    float c = 5;
    void ShowPosition()
    {
        Debug.Log(this.transform.position);
    }
    int AddNumber(int i, int j)
    {
        int k = i + j;
        return k;
    }
    float AddNumber(float i, float j)
    {
        float k = i + j;
        return k;
    }
    double AddNumber(double i, double j)
    {
        double k = i + j;
        return k;
    }
    string AddNumber(string i, string j)
    {
        string k = i + j;
        return k;
    }
    void ShowAnyPosition(GameObject obj)
    {
        Debug.Log(obj.transform.position);
    }

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
        /*ShowPosition();
        ShowAnyPosition(this.gameObject);
        ShowAnyPosition(frontleft_wheel);
        ShowAnyPosition(frontright_wheel);
        AddNumber(1, 2);
        int result = AddNumber(3, 4);
        Debug.Log("result =" + result);
        float result2 = AddNumber(x, y);
        Debug.Log("result =" + result2);
        ShowPosition();*/
        if (x == y)
        {

        }
        if (!(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)))
        {
            if (Input.GetKey(KeyCode.W))
            {
                //this.transform.position = new Vector3(x, y, z + 0.1f);
                this.transform.Translate(0, 0, 0.1f);
                frontleft_wheel.transform.Rotate(1f, 0, 0);
                frontright_wheel.transform.Rotate(1f, 0, 0);
                backleft_wheel.transform.Rotate(1f, 0, 0);
                backright_wheel.transform.Rotate(1f, 0, 0);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                //this.transform.position = new Vector3(x, y, z - 0.01f);
                this.transform.Translate(0, 0, -0.1f);
                frontleft_wheel.transform.Rotate(-1f, 0, 0);
                frontright_wheel.transform.Rotate(-1f, 0, 0);
                backleft_wheel.transform.Rotate(-1f, 0, 0);
                backright_wheel.transform.Rotate(-1f, 0, 0);
            }
        }

        else
        {
            this.transform.Translate(x, 0, 0);
            frontleft_wheel.transform.Rotate(0, 0, 0);
            frontright_wheel.transform.Rotate(0, 0, 0);
            backleft_wheel.transform.Rotate(0, 0, 0);
            backright_wheel.transform.Rotate(0, 0, 0);
        }

        if (!(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)))
        {
            Debug.Log(frontleft_wheel.transform.localRotation.x);
            float qX = frontleft_wheel.transform.localRotation.x;
            float qY = frontleft_wheel.transform.localRotation.y;
            float qZ = frontleft_wheel.transform.localRotation.z;
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.RotateAround(LeftTurn.transform.position, Vector3.down, 1);
                frontleft_wheel.transform.localRotation = Quaternion.Euler(qX, -30, 0);
                frontright_wheel.transform.localRotation = Quaternion.Euler(qX, -30, 0);
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                frontleft_wheel.transform.localRotation = Quaternion.Euler(qX, 0, 0);
                frontright_wheel.transform.localRotation = Quaternion.Euler(qX, 0, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                this.transform.RotateAround(RightTurn.transform.position, Vector3.up, 1);
                frontleft_wheel.transform.localRotation = Quaternion.Euler(qX, 30, 0);
                frontright_wheel.transform.localRotation = Quaternion.Euler(qX, 30, 0);
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                frontleft_wheel.transform.localRotation = Quaternion.Euler(qX, 0, 0);
                frontright_wheel.transform.localRotation = Quaternion.Euler(qX, 0, 0);
            }
        }
        else
        {
            frontleft_wheel.transform.rotation = Quaternion.Euler(0, 0, 0);
            frontright_wheel.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
