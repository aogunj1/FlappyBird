using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScipt : MonoBehaviour
{
   public float flapStrength;
   public Rigidbody2D myRigbody;
   public LogicScript logic;
   
   public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
        myRigbody.velocity = Vector2.up * flapStrength;
    }
    }
   private void OnCollisionEnter2D(Collision2D collision)
   {
    logic.GameOver();
    birdIsAlive = false;
   }
}
