using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class rotateCrossHair : MonoBehaviour
{
    public GameObject anchorObject;
    static GameObject CrossHair;
    static Vector3 anchor;
    // Start is called before the first frame update
    void Start()
    {
        CrossHair = GameObject.Find("CrossHair");
        anchor = anchorObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float strength = CrossPlatformInputManager.GetAxis("Vertical");
        Debug.Log(strength);

        CrossHair.transform.RotateAround(anchorObject.transform.position, new Vector3(0, 0, 1), 1*strength);
    }
}
