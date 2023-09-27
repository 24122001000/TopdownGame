using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReciever : DameReceiver
{
    protected PlayerController playerController;

    private void Awake()
    {
        this.playerController = GetComponent<PlayerController>();
    }

    public override void Receiver(int damage)
    {
        base.Receiver(damage);
        if (this.IsDead()) 
        { 
            this.playerController.playerStatus.Dead();
            UIManager.instance.btnGameOver.SetActive(true);
        }
    }
}
