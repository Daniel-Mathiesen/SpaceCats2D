using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 1f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start(){
        StartCoroutine(AsteroidWave());
    }
    void Update()
    {
      screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); 
    }
    private void spawnAsteroid(){
           GameObject a = Instantiate(asteroidPrefab) as GameObject;
           a.transform.position = new Vector2(screenBounds.x * 1.1f, Random.Range(-screenBounds.y, screenBounds.y));
       } 
    // Update is called once per frame
    IEnumerator AsteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
        spawnAsteroid();
        }
    }
}
