using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {
{
	// Update is called once per frame
	void Update ()
	{
			Quaternian euler = Quaternion.Euler(
				new Vector3(0f, 0f, Time.time * 360f ) ):

				Transform.localRotation = euler;
	}
}