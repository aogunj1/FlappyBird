using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScipt : MonoBehaviour
{
   public float flapStrength;
   public Rigidbody2D myRigbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        myRigbody.velocity = Vector2.up * flapStrength;
    }
    }
}
