using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    public Character character;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Enemy"){
            character.TakeDamage(2);
        }
    } 
}
