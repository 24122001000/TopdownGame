using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Despawner despawner;
    public EnemyDameReceiver enemyDameReceiver;

    private void Awake()
    {
        despawner = GetComponent<Despawner>();
        enemyDameReceiver = GetComponent<EnemyDameReceiver>();
    }
}
