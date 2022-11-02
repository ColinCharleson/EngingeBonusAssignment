using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public int damage = 1;
	public float speed = 1;
	Rigidbody rb;

	private Vector3 startPos;
	void Start()
	{
		rb = GetComponent<Rigidbody>();

		startPos = this.transform.position;
	}

	private void Update()
	{
		rb.velocity = new Vector2(speed, rb.velocity.y);

		if(this.transform.position.x > 15 || this.transform.position.x < -15)
		{
			this.transform.position = startPos;
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			HealthManager.instance.TakeDamage(damage);
		}

		if (other.tag == "Hammer")
		{
			this.transform.position = startPos;
		}
	}
}
