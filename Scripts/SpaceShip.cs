using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour{
    public GameObject explosion;

   private void OnTriggerEnter2D(Collider2D other){
       Debug.Log("hit detected!");
       if (other.tag == "DeathObject"){
       GameObject e = Instantiate(explosion) as GameObject;
       e.transform.position = transform.position;
       FindObjectOfType<AudioManager>().Play("PlayerDeath");
       Destroy(other.gameObject);
       this.gameObject.SetActive(false);  
       } else
       {
         Debug.Log("Player hit a collectable!");  
       }
   }

}
