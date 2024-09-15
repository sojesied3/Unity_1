using UnityEditor.Experimental;
using UnityEngine;

public class Movement : MonoBehaviour

// Reminder:
// int - Whole Number
// float - decimal number
// string - text
// bool - true or false
{

    public Rigidbody rb;

    public float WalkingForce = 1000f;
    public float SprintingForce = 1500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Time.deltaTime is used so that better computers with more frames cant make the player move forward faster
    // Using FixedUpdate Because We are Messing With Physics
    void FixedUpdate()
    {
        // Add a forward force
        

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, WalkingForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -WalkingForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-WalkingForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(WalkingForce * Time.deltaTime, 0, 0);
        }

    }
}
