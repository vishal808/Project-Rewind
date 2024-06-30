using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public int id;
    public float LiftDisc;
	public float initail = 0f;
    void Start()
    {

        GameEvent.current.onDoorTriggerEnter += onLiftUp;
		     GameEvent.current.onDoorTriggerExit += onLiftDown;

    }
    private void onLiftUp(int id)
    {
        if (id == this.id)
            LeanTween.moveLocalY(gameObject, LiftDisc, 4f).setEaseOutQuad();
    }
	 private void onLiftDown(int id)
    {   if(id==this.id)
        LeanTween.moveLocalY(gameObject, initail, 1f).setEaseInQuad();
    }
}
