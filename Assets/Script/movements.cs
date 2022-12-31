using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce=2000f;
    public float sidewaysforce=500f;

    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforce*Time.deltaTime);
      
       if(rb.position.y<-0.03f)
      {
        FindObjectOfType<GameManager>().EndGame();
      }  
      
    
      /*if(Input.GetKey("a"))
      {
        rb.AddForce(-sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      }  
      if(Input.GetKey("d"))
      {
        rb.AddForce(sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      }*/

      if(Input.GetAxisRaw("Horizontal")==-1)
      {
        rb.AddForce(-sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      }
       
      if(Input.GetAxisRaw("Horizontal")==1)
      {
        rb.AddForce(sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      } 
    }
    public void Break()
    {

      rb.AddForce(0,-500000000000*Time.deltaTime,0);
    }
     
}
