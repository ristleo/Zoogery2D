using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
	public AudioClip explosion;
	
    public static float y_angle = 0.0f;
    public float y_change = 0.0005f;
    public float moveSpeed = 10.0f;
	
	private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
        projectile.velocity = new Vector2(1.0f, y_angle) * moveSpeed;
		source = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        y_angle += Input.GetAxis("Vertical") * y_change;
        y_angle = Mathf.Clamp(y_angle, -1.5f, 1.5f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Collider2D col_child = col.contacts[0].collider;
	    float vol = 1.0f;   
		//source.PlayOneShot(explosion,vol);
        if (col_child.gameObject.tag == "Fragment")
        {
            col_child.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
