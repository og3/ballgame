using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball, transform.position, transform.rotation);
        InvokeRepeating();
    }

    void SpawnBall()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
