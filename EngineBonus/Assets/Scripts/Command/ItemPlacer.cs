using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{
    static List<Transform> items;
   
    public static void PlaceItem(Transform item)
	{
		Transform newItem = item;
		if(items == null)
		{
			items = new List<Transform>();
		}

		item.gameObject.SetActive(true);
		items.Add(newItem);
	}
}
