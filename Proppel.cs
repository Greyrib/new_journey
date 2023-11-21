using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Proppel : MonoBehaviour
{
    public float acceleration = 100.0f;
    public float maxSpeed;
    public float curSpeed = 0.0f;
    

    /// Start is called before the first frame update
    void Start()
    {
         
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.back * maxSpeed); 
        //transform.Rotate(0f,0f, maxSpeed*Time.fixedDeltaTime,Space.Self);
        
 
        transform.Rotate(Vector3.back*curSpeed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {

            if(maxSpeed < 0.1f) // makes sure to only accellerate if the wheel is below a certain speed;
        
        	{
                maxSpeed = 1000.0f;
             
            }
                //transform.Rotate(0, 0, -maxSpeed*Time.fixedDeltaTime);
                
                
 
                curSpeed += acceleration * Time.deltaTime;
                
 
                if (curSpeed > maxSpeed)
                curSpeed = maxSpeed;          

                
        }

        else if (Input.GetMouseButton(0) == false)
        {
            curSpeed = Mathf.Lerp(curSpeed, 0, 0.9f * Time.deltaTime);
        }
    }

}
