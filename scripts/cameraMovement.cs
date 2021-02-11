using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public float xPos;
    public float posit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-xPos, 0f, 0f) * moveSpeed * Time.deltaTime;
        posit = transform.position.x;
    }
}
