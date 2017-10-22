using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
	public int aPublicVariable = 123;
	int aVariable = 234897;

    void Awake() {
        //Debug.Log("This is Awake() saying hello!!");
    }
    
	// Use this for initialization
	void Start ()
	{
		/*
        Debug.Log("Normal info in console");
        Debug.LogWarning("This will be a warning, usually, if something is no longer supported or if it will cause possible issues but still run");
        Debug.LogError("Oh Sh!t, there goes the planet!");
        */
		//Debug.Log("This is Start() saying hello!!");
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Debug.Log("This is Update() saying hello!!");
		aPublicVariable++;
	}

	void FixedUpdate ()
	{
		//Debug.Log("This is FixedUpdate() saying hello!!");
	}
}
