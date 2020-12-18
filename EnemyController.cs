using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    GameObject target;
    NavMeshAgent agent;
    SceneController sceneController;
    
    void Start()
    {
        target = GameObject.Find("Player");
        agent = GetComponent<NavMeshAgent>();
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
    }

   
    void Update()
    {
        agent.destination = target.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sceneController.GameOver();
        }
    }
}
