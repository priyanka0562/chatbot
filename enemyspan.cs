using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyspan : MonoBehaviour
{
    public Transform[] enemypo;
    public GameObject enemy;
    int enemywait=80;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(enemywait==0)
        {
            Instantiate(enemy, enemypo[Random.Range(0,3)].position, Quaternion.identity);
            enemywait=80;
        }
        else
        {
            enemywait= enemywait-1;
        }
    }
}
