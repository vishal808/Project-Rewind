using System.Collections;
//using System;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public int id;
	public float initail = 0f;
	public float Final = 3f;
    void Start()
    {

        GameEvent.current.onDoorTriggerEnter += onDoorOpen;
        GameEvent.current.onDoorTriggerExit += onDoorClose;
    }
    private void onDoorOpen(int id)
    {
        if(id==this.id)
        LeanTween.moveLocalY(gameObject, initail+Final, 1f).setEaseOutQuad();
    }
    private void onDoorClose(int id)
    {   if(id==this.id)
        LeanTween.moveLocalY(gameObject, initail, 1f).setEaseInQuad();
    }
   

}
