using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
	ICommand command;
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Ice Block")
		{

			command = new PlaceItemCommand(other.transform.position, other.transform);
			CommandInvoker.AddCommand(command);

			other.gameObject.SetActive(false);
		}
	}
}
