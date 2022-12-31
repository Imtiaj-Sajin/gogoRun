using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public movements movement;
   void OnTriggerEnter ()
   {
       FindObjectOfType<GameManager>().Success();
       movement.enabled=false;
    
       FindObjectOfType<movements>().Break();
       //FindObjectOfType<Score>().ResetHighScore();

   }

}
