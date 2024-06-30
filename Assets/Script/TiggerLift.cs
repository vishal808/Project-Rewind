using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerLift : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other)
    {
        GameEvent.current.DoorTriggerEnter(id);
    }

   private void OnTriggerExit(Collider other)
    {
	
        GameEvent.current.DoorTriggerExit(id);
    }
}
