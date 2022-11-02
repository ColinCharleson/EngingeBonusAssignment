using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
		{
            Destroy(gameObject);
		}
    }

    //Player Stats
    public int playerHealth = 3;

	private void Update()
	{
		if(playerHealth <= 0)
                GameReset();
	}

    public void TakeDamage(int damage)
	{
        playerHealth -= damage;
	}

    public void GameReset()
	{ 
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
	}
}
