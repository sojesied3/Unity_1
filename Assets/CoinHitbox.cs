using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinHitbox : MonoBehaviour
{
    CarMovement a;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collected: " + collision.gameObject.name);
        if (collision.gameObject.name == "Body")
        {
            a = collision.gameObject.GetComponentInParent<CarMovement>();
            a.AddCoin();
            this.gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0.2f, 0);
    }
}
