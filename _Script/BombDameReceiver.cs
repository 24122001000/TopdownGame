using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDameReceiver : DameReceiver
{
    //Kết nối với enemyctrl Khi enemy va chạm với player sẽ biến mất

    
    public override void Receiver(int damage)
    {
        base.Receiver(damage);
        if (this.IsDead())
        {
            Destroy(gameObject);
            EffectsManager.instance.SpawnVFX("Explosion_B", transform.position, transform.rotation);
        }
    }

}
