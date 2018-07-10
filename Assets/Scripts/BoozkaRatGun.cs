using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class BoozkaRatGun:Item  {
    public override void Use()
    {
        Debug.Log("gun1");
        for (int i = 0; i < 100; i++)
        {
            var rat = Instantiate(ratProjectile);
            var mrat = rat.GetComponent<Rigidbody>();
           

        }
    }

    public GameObject ratProjectile;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
