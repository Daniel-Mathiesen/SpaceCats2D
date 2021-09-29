using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
      Destroy(gameObject, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
