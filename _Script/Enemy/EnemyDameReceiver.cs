using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDameReceiver : DameReceiver
{
    //Kết nối với enemyctrl Khi enemy va chạm với player sẽ biến mất

    protected EnemyController enemyController;

    private void Awake()
    {
        enemyController = GetComponent<EnemyController>();
    }

    private void Reset()
    {
        base.hp = 3;
    }
    public override void Receiver(int damage)
    {
        base.Receiver(damage);
        if (this.IsDead())
        {
            EffectsManager.instance.SpawnVFX("Explosion_A", transform.position, transform.rotation);
            enemyController.despawner.Despawn();
        }
    }

}
