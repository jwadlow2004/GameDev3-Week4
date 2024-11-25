using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.ObserverPattern;

namespace GameDevWithMarco.Enemies
{
    public class KinghtsView : MonoBehaviour
    {

        [SerializeField] GameEvent playerSpottedEvent;
        bool hasPlayerBeenSpotted = false;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" && !hasPlayerBeenSpotted)
            {
                Debug.Log("Player Spotted");

                playerSpottedEvent.Raise();

                hasPlayerBeenSpotted = true;
            }
        }

    }
}
