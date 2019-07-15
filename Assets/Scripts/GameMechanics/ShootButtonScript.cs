using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButtonScript : MonoBehaviour
{
    static Transform projectileSpawn;
    public GameObject spawnFromGameObject;
    public GameObject projectile;
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        projectileSpawn = spawnFromGameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
    }
    public void shoot()
    {

        if (currentTime > nextFire)
        {
            nextFire += currentTime;
            Instantiate(projectile, projectileSpawn.position, Quaternion.Euler(0, 0, 90), spawnFromGameObject.transform);
            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }

}
