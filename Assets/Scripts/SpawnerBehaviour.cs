using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{

    public GameObject enemy_prefab;
    public float spawn_time;
    public float spawn_radius;
    private PlayerMovementBehaviour player;
    private float spawn_timer;
	void Start ()
	{
	    spawn_timer = spawn_time;
	    player = GameObject.FindObjectOfType<PlayerMovementBehaviour>();
	}
	
	void Update ()
	{
	    spawn_timer -= Time.deltaTime;
	    if (spawn_timer < 0)
	    {
	        spawn_timer = spawn_time;
	        float spawn_angle = Random.Range(0, 2 * Mathf.PI);
            Vector3 spawn_direction = new Vector3(Mathf.Sin(spawn_angle), 0, Mathf.Cos(spawn_angle));
	        spawn_direction *= spawn_radius;
	        Vector3 spawn_point = this.transform.position + spawn_direction;
	        Instantiate(enemy_prefab, spawn_point, Quaternion.identity);
	    }
	}
}
