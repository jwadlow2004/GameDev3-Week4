using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Enemies
{
      public class KnightSView : MonoBehaviour 
      {

         private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player") { Debug.Log("Player Spotted"); }
        }
        
     
      }
}
    
   

