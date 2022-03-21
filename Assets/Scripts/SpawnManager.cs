using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsPrefab;
    public Vector3 spawnPosition = new Vector3(30,0,0);
    private PlayerController playerCtrl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObs",2,2);
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObs()
    {
        if(playerCtrl.gameOver == false)
        {
            Instantiate(obsPrefab, spawnPosition, obsPrefab.transform.rotation);
        }
       
    }
}
