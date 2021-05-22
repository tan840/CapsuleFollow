using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField] NavMeshAgent nav;
    GameManager gameManager;
    private bool firstcollide = true;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            nav.SetDestination(player.position);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            player = collision.gameObject.transform;
            if (firstcollide)
            {
                gameManager.Player_UI_text();
            }

            firstcollide = false;

        }
    }
}
