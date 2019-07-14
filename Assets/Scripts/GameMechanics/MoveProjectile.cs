using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;

    static GameObject CrossHair;

    public static float y_angle = 0.0f;
    public float y_change = 0.0005f;

    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
        CrossHair = GameObject.Find("CrossHair");
        float z_angle = Mathf.Deg2Rad*CrossHair.transform.rotation.eulerAngles.z;
        Debug.Log(Mathf.Deg2Rad*z_angle);
        Vector2 dir = new Vector2(Mathf.Cos(z_angle), Mathf.Sin(z_angle));
        // TODO clamping
        projectile.velocity = dir * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //y_angle += Input.GetAxis("Vertical") * y_change;
        //y_angle = Mathf.Clamp(y_angle, -1.5f, 1.5f);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Collider2D col_child = col.contacts[0].collider;
        if (col_child.gameObject.tag == "Fragment")
        {
            col_child.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
