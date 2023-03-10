using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    // unity all was using float values
    private Vector3 offset= new Vector3(14.25f, 0.49f, 0.21f);

    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
