using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deploySpaceParts : MonoBehaviour
{
    public GameObject SpacePartPrefab;
    public float respawnTime = 10f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start(){
        StartCoroutine(SpacePartWave());
    }
    void Update()
    {
      screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); 
    }
    private void spawnSpaceParts(){
           GameObject a = Instantiate(SpacePartPrefab) as GameObject;
           a.transform.position = new Vector2(screenBounds.x * 1.2f, Random.Range(-screenBounds.y, screenBounds.y));
       } 
    // Update is called once per frame
    IEnumerator SpacePartWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
        spawnSpaceParts();
        }
    }
}
