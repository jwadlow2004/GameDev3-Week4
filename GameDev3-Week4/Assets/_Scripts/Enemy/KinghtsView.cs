using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.ObserverPattern;

namespace GameDevWithMarco.Enemies
{
    public class KinghtsView : MonoBehaviour
    {

        [SerializeField] GameEvent playerSpottedEvent;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                Debug.Log("Player Spotted");

                playerSpottedEvent.Raise();
            }
        }

    }
}
