using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Gun:ProjectileActor  {
    void Use()
    {
        Debug.Log("gun1");
        for (int i = 0; i < 100; i++)
        {
            var gun = Instantiate(Projectile);
            var Round = gun.GetComponent<Rigidbody>();
           

        }
    }

    public GameObject Projectile;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
