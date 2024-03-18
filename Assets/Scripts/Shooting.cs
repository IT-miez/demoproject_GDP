using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    public void bulletDestroyer()
    {
        Destroy(bulletPrefab);
    }

    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame) 
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }
}
