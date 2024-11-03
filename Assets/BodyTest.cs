using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyTest : MonoBehaviour
{
    int points;
    int tentpoints;
    public void CoinTest()
    {
        tentpoints = points;
        points = tentpoints + 1;
        Debug.Log("Points: " + points);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
