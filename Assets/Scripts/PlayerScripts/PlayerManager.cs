using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;

    void Awake() {
        Destroy(this);
        instance = this;
    }

    #endregion

    public GameObject player;
}
