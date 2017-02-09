using UnityEngine;
using System.Collections;
using System;

public class Clocks : MonoBehaviour
{
	public GameObject hourHand;
	public GameObject minuteHand;
	public GameObject secondHand;

	void Update()
	{
		DateTime time = DateTime.Now;
		int seconds = time.Second;
		float seconds_normalized = seconds / 60f;
		float seconds_degrees = seconds_normalized * 360f;
		float clockwise_seconds = 360f - seconds_degrees;


		Vector3 secondsRotation = new Vector3(0f, 0f, clockwise_seconds);
		Quaternion secondsRotationQuat = Quaternion.Euler(secondsRotation); 
		secondHand.transform.rotation = secondsRotationQuat;

		DateTime time = DateTime.Now;
		int minutes = time.Minutes;
		float minutes_normalized = Minutes / 60f;
		float minutes_degrees = Minutes_normalized * 360f;
		float clockwise_Minutes = 360f - minutes_degrees;


		Vector3 secondsRotation = new Vector3(0f, 0f, clockwise_seconds);
		Quaternion secondsRotationQuat = Quaternion.Euler(secondsRotation); 
		secondHand.transform.rotation = secondsRotationQuat;



	}
}
