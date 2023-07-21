using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    public Character character;

    [SerializeField] private int damage = 1;


    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player"){
            character.TakeDamage(damage);
        }
    } 


}
