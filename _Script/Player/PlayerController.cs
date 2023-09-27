using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public DameReceiver dameReceiver;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        PlayerController.instance = this;
        this.dameReceiver = GetComponent<DameReceiver>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
