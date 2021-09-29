using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipCollectable : MonoBehaviour
{
    
    public List<string> inventory;

    void Start()
    {
       inventory = new List<string>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Collectable"){
        string itemType = collision.gameObject.GetComponent<CollectableScript>().itemType;
        print("Player collected a:"+ itemType);

        inventory.Add(itemType);
        print("Inventory lenght:"+ inventory.Count);

        Destroy(collision.gameObject);   
        }
    }

    void Update()
    {
        
    }
}
