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
        Debug.Log(projectileSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shoot()
    {
        currentTime += Time.deltaTime;

        if (true)//(currentTime > nextFire)
        {
            Debug.Log("Servus");
            nextFire += currentTime;
            Instantiate(projectile, projectileSpawn.position, Quaternion.FromToRotation(Vector3.right, transform.right));
            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }

}
