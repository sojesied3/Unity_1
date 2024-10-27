using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinHitbox : MonoBehaviour
{
    public GameObject MultipleSlash;
    bool isUpward;
    bool isDownward;
    void CoinStageUp()
    {
        this.transform.Translate(0, 0.2f, 0);
    }
    void CoinStageDown()
    {
        this.transform.Translate(0, -0.2f, 0);
    }
    CarMovement a;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collected: " + collision.gameObject.name);
        if (collision.gameObject.name == "Body")
        {
            a = collision.gameObject.GetComponentInParent<CarMovement>();
            a.AddCoin();
            this.gameObject.SetActive(false);
            //MultipleSlash.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        isUpward = true;
        isDownward = false;
    }

    // Update is called once per frame
    void Update()
    {
        //MultipleSlash.SetActive(true);
        this.transform.Rotate(0, 0.2f, 0);
        //this.transform.Translate(0, 0.2f, 0);
        if (this.transform.position.y > 5.5)
        {
            isDownward = true;
            isUpward = false;
        }
        if (this.transform.position.y < 4.5)
        {
            isDownward = false;
            isUpward = true;
        }

        if (isUpward == true)
        {
            this.transform.Translate(0, 0.002f, 0);
        }
        if (isDownward == true)
        {
            this.transform.Translate(0, -0.002f, 0);
        }
    }
}

