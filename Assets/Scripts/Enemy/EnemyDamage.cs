using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    public Character character;

    [SerializeField] private int damage = 1;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player"){
            character.TakeDamage(damage);
        }
    } 


}
