using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class TimeBody : MonoBehaviour {

	bool isRewinding = false;

	public float recordTime = 5f;
	GameObject post;
   PostProcessVolume volume ;
    ColorGrading     colorGradingLayer     = null;
	Vignette vig = null;
	List<PointInTime> pointsInTime;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		post = GameObject.Find("PostProcess");
		pointsInTime = new List<PointInTime>();
		rb = GetComponent<Rigidbody>();
	    	volume = GameObject.Find("PostProcess").GetComponent<PostProcessVolume>();
		 volume.profile.TryGetSettings(out colorGradingLayer);
		 volume.profile.TryGetSettings(out vig);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("q")){Time.timeScale = 2f;
		colorGradingLayer.enabled.value = true;
		colorGradingLayer.saturation.value = -20f;
		vig.enabled.value = true;
		vig.intensity.value=0.55f;
		StartRewind();}
		if (Input.GetKeyUp("q"))
		{
			Time.timeScale = 1f;
			 colorGradingLayer.enabled.value = true;
			colorGradingLayer.saturation.value = 5f;
			vig.enabled.value = true;
			vig.intensity.value=0f;
			StopRewind();}
	}

	void FixedUpdate ()
	{
		if (isRewinding)
			Rewind();
		else
			Record();
	}

	void Rewind ()
	{
		if (pointsInTime.Count > 0)
		{
			PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
			transform.rotation = pointInTime.rotation;
			pointsInTime.RemoveAt(0);
		} else
		{
			StopRewind();
		}
		
	}

	void Record ()
	{
		if (pointsInTime.Count > Mathf.Round(recordTime / Time.fixedDeltaTime))
		{
			pointsInTime.RemoveAt(pointsInTime.Count - 1);
		}

		pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
	}

	public void StartRewind ()
	{
		isRewinding = true;
		rb.isKinematic = true;
	}

	public void StopRewind ()
	{
		isRewinding = false;
		rb.isKinematic = false;
	}
}
