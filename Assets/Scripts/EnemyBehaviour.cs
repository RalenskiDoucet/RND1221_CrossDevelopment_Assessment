using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    float Health = 50;
    private PlayerMovementBehaviour player;
    private Vector3 boom;
    public float Speed;
    private CharacterController controller;
	// Use this for initialization
	void Start ()
	{
	    player = GameObject.FindObjectOfType<PlayerMovementBehaviour>();
	}

    void ChangeeEalthValue()
    {
        CollisionDetectionMode.Continuous.CompareTo("Projectile_Prefab");
    }
    void OnHealthValueChanged()
    {
            if (Health < 0)
            {
                Destroy(gameObject);
            }       
    }
	// Update is called once per frame
	void Update ()
	{
	    Vector3 directionToPlayer;
	    directionToPlayer.x = player.transform.position.x - this.transform.position.x;
	    directionToPlayer.y = 0;
	    directionToPlayer.z = player.transform.position.z - this.transform.position.z;
        directionToPlayer.Normalize();
	    transform.position += directionToPlayer * Speed * Time.deltaTime;

	}
}
