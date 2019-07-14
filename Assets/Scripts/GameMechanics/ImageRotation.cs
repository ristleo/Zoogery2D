using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRotation : MonoBehaviour
{
    public float rotationalSpeed;

    public Rigidbody2D image;

    // Start is called before the first frame update
    void Start()
    {
        image = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SpinImage();
    }

    public void SpinImage()
    {
        image.AddTorque(-Input.GetAxis("Horizontal") * rotationalSpeed, ForceMode2D.Impulse);
    }
}