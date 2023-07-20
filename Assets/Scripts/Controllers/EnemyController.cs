using UnityEngine;
using System;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
  
  public float lookRadius = 15f;

  Transform target;
  NavMeshAgent agent;

    int expAmount = 100;
    [SerializeField] float movementSpeed = 5f;


    void Start () {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }


    void Update() {
        if (target != null) {

        float distance = Vector3.Distance(target.position, transform.position);

        if (distance < lookRadius) {
            agent.SetDestination(target.position);
            agent.speed = movementSpeed;

            if (distance <= agent.stoppingDistance) {
                // attack the target
                FaceTarget();
            }
        }
        }
    }

    void FaceTarget() {
        Vector3 direction = (target.position = transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }



}