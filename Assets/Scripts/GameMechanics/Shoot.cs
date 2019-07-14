using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform projectileSpawn;
    public GameObject projectile;
	public AudioClip shootSound;
	
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;
	private AudioSource source;
    // Start is called before the first frame update
	
	
    void Start()
    {
        projectileSpawn = this.gameObject.transform;
		//Load shooting sound - Merlin
		source = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    public void shoot()
    {
        currentTime += Time.deltaTime;

        if(Input.GetButton("Fire1") && currentTime > nextFire)
        {
            nextFire += currentTime;
            Instantiate(projectile, projectileSpawn.position, Quaternion.FromToRotation(Vector3.right, transform.right));
			//Add sound to shoot - Merlin
		    float vol = 1.0f;   
			source.PlayOneShot(shootSound,vol);
            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}
