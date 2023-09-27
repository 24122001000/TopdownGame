using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageSender : DameSender
{
    //Kết nối với enemyctrl Khi enemy va chạm với player sẽ biến mất

    protected EnemyController enemyController;

    private void Awake()
    {
        enemyController = GetComponent<EnemyController>();
    }

    protected override void ColliderSendDamage(Collider2D collision)
    {
        base.ColliderSendDamage(collision);

        this.enemyController.enemyDameReceiver.Receiver(1);//Gọi hàm despawn làm biến mất enemy

        
    }
}
