using UnityEngine;
using System.Collections;

public class TriggerPoint : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("ENTERD " + other.name);
	}

	void OnTriggerStay (Collider other)
	{
		Debug.Log ("STAY " + other.name);
	}

	void OnTriggerExit (Collider other)
	{
		Debug.Log ("EXIT " + other.name);
	}
}
