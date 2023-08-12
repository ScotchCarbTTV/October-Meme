using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;

    [SerializeField] GameObject barrelEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //shoot a bullet
            GameObject newBullet = Instantiate(bulletPrefab, barrelEnd.transform.position, barrelEnd.transform.rotation);
            if(newBullet.TryGetComponent<Bullet>(out Bullet bullet))
            {
                bullet.SetDir(barrelEnd.transform.forward);
            }
            
        }
    }
}
