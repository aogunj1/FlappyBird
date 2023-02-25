using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightChange = 10;

    // Start is called before the first frame update
    void Start()
    {
         spawnFirstPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){

            timer += Time.deltaTime;
        }
        else {
           spawnFirstPipe();
            timer = 0;
        }
        
     
    }
    void spawnFirstPipe(){
        float lowPipe = transform.position.y - heightChange;
        float highPipe = transform.position.y + heightChange;
 Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowPipe , highPipe), 0) , transform.rotation);
    }
}
