using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnBullet;
    int BulletCount = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BulletCount > 0)
        {
            if (Input.GetMouseButtonDown(1))
            {
                var fire = Instantiate(bulletPrefab, spawnBullet.position, Quaternion.identity);
                BulletCount -= 1;
            }
        }
    }
}
