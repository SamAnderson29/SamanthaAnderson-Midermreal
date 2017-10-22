using UnityEngine;
using System.Collections;

public class RotateItem : MonoBehaviour
{
	public GameObject myRotatingThing;

	public float myRotation = 0.0f;
	public float myRotationAdjustment = 0.1f;

	// Use this for initialization
	void Start ()
	{
		myRotationAdjustment = Random.Range (0.1f, 20.782345435f);
/*
        Debug.Log("transform.rotation.ToString(): " + myRotatingThing.transform.rotation.ToString());
        myRotatingThing.transform.localScale = new Vector3(2.0f, 0.5f, 1.0f);
 */
	}
	
	// Update is called once per frame
	void Update ()
	{
		myRotatingThing.transform.Rotate (new Vector3 (0.0f, 0.0f, myRotationAdjustment));
	}
}
