using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Ice Block")
		{
			Destroy(other.gameObject);
		}
	}
}
