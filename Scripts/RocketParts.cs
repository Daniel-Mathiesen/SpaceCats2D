using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketParts : MonoBehaviour
{
    public float speed = 12.5f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
       if(transform.position.x < -screenBounds.x * 2f){
           Destroy(this.gameObject);
       } 
    }
}