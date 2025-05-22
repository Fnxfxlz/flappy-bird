using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject piperPrefab;
    BirdController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1 ,1.5f);

        playerControllerScript = GameObject.Find("Red_Bird_0").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.isAlive == false)
        {
            CancelInvoke();
        }
    }
    
    private void SpawnPipes()
    {
        Instantiate(piperPrefab, new Vector3(8.11f, Random.Range(1, 6.89f), 0), Quaternion.identity);
    }
}    


