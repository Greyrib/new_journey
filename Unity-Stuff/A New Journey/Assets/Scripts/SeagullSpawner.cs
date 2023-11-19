using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagullSpawner : MonoBehaviour
{
    public GameObject seagull;
    public SeagullInfo seagullInfo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnSeagull();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSeagull()
    {
        Vector3 spawnPoint = new(transform.position.x, transform.position.y * 5, transform.position.z);
        GameObject current_seagull = Instantiate(seagull, spawnPoint, Quaternion.identity);
        current_seagull.name = seagullInfo.prefabName;
    }
}
