using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public static GameEvent current;
    private void Awake()
    {
        current = this;
    }
    public event Action<int> onDoorTriggerEnter;
    public void DoorTriggerEnter(int id)
    {
        if(onDoorTriggerEnter!=null)
        {
            onDoorTriggerEnter(id);
        }
    } 
    public event Action<int> onDoorTriggerExit;
    public void DoorTriggerExit(int id)
    {
        if(onDoorTriggerExit!=null)
        {
            onDoorTriggerExit(id);
        }
    } 
    public event Action<int> onLiftEnter;
    public void LiftEnter(int id)
    {
        if(onLiftEnter != null)
        {
            onLiftEnter(id);
        }
    }
	
    
}
