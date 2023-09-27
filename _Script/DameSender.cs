using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DameSender : MonoBehaviour
{

    public int damage = 1;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.ColliderSendDamage(collision);
    }

    protected virtual void ColliderSendDamage(Collider2D collision)
    {
        DameReceiver dameReceiver = collision.GetComponent<DameReceiver>();
        if (dameReceiver == null) return;//Đối tượng va chạm ko có dameReciver thì ko làm gì cả
        dameReceiver.Receiver(damage);
    }
}
