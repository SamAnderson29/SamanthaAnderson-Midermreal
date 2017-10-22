using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour
{
	void Update ()
	{
		GetComponent<Light> ().intensity = Random.Range (1.5f, 8.0f);
	}
}