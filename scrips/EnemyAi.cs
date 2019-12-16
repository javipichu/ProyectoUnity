using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI
;
public class EnemyAi : MonoBehaviour
{
    GameObject player;
    NavMeshAgent enemy;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
        {
            Debug.Log("Did you forgot to rag your player or FPS Controler");
        }

        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
            enemy.destination = player.transform.position;
        
    }
}
