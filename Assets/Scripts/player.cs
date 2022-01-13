using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f; 

    float dirX; 


    // Update is called once per frame
    void Update()
    {
      dirX = Input.GetAxisRaw("Horizontal");  

      Debug.Log(dirX);

      transform.position += new Vector3(dirX, 0, 0) * speed * Time.deltaTime;
    }
}
