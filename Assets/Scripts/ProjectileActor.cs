using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileActor : MonoBehaviour
{

    public float Speed;
    public Vector3 Direction;
    public float Lifetime;
    public GameObject mProjectile;
	// Use this for initialization
    void Start()
    {

    }
    public enum WeaponType
    {
        Weapon_HitScan,
        Weapon_SingleShot,
    }

    public WeaponType Weapon_Type1;

    public void OnCollisionEnter(Collision hit)
    {
        if (hit.collider.tag == "Enemy")
        {
            Destroy((hit.collider.gameObject));
        }
        Destroy(gameObject);
    }
    public void FireHitScan()
    {
        Vector3 fire_Direction = PlatformFireDirection();
        RaycastHit info;
        Ray Fire_Ray=new Ray(transform.position, fire_Direction);
        if (Physics.Raycast(Fire_Ray, out info, 1000))
        {
            if (info.collider.tag == "Enemy")
            {
                Destroy(info.collider.gameObject);
            }
        }
    }

    public Vector3 PlatformFireDirection()
    {
        Vector3 mVect3 = Direction;
        return mVect3;
    }

    public bool PlatformPlayerShouldFire()
    {
        FireHitScan();
        return Instantiate(Projectile_Prefab);
    }

    void FireSingleShot()
    {
        GameObject Projectile = (GameObject) Instantiate(Projectile_Prefab);
        Projectile.transform.position = transform.position;
        ProjectileActor Projectile_Component = Projectile.GetComponent<ProjectileActor>();
        Projectile_Component.Direction = PlatformGetPlayerFireDirection;

    }

    public Vector3 PlatformGetPlayerFireDirection
    {
        get
        {
            return Direction;
        }
        set
        {
            Vector3 Vector3FireDirection  = Direction;
        }
    }

    public GameObject Projectile_Prefab
    {
        get
        {
            return Projectile_Prefab;

        }

        set
        {
            GameObject projectile_prefab = mProjectile;
        }

    }

    // Update is called once per frame
    void Update () {
	    transform.position += Direction * Speed * Time.deltaTime;
	    Lifetime -= Time.deltaTime;
	    if (Lifetime < 0)
	    {
	        Destroy(gameObject);
	    }

        if (PlatformPlayerShouldFire())
        {
            FireHitScan();
        }

        if (PlatformPlayerShouldFire())
        {
            switch (Weapon_Type1)
            {
                case WeaponType.Weapon_HitScan:
                    FireHitScan();
                    break;
                case WeaponType.Weapon_SingleShot:
                    //singleshot weapon call
                    default:
                    break;
            }
        }
    }
}
