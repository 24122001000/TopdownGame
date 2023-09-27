using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
   
    

    /*private void Awake()
    {
        this.objPrefabs = GameObject.Find("Enemy");
        this.spawnPos = GameObject.Find("EnemySpamPos");
        this.objPrefabs.SetActive(false);

        this.objects = new List<GameObject>();
    }*/
    private void Reset()
    {
        this.prefabName = "Enemy";
        this.spawnPosName = "EnemySpamPos";
    }

    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }


    /*protected void Spawn()
    {
        if (PlayerController.instance.dameReceiver.IsDead()) return ;
        if (this.objects.Count >= maxEnemy) return;

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;

        GameObject enemy = Instantiate(this.objPrefabs);
        enemy.transform.position = spawnPos.transform.position;
        enemy.transform.parent = transform;
        enemy.SetActive(true);

        this.objects.Add(enemy);
    }*/

    /*void CheckDead()
    {
        GameObject enemy;
        for (int i = 0; i < this.objects.Count; i++)
        {
            enemy = this.objects[i];
            if (enemy == null)// nếu enemy missing
            {
                this.objects.RemoveAt(i);// remove enemy đó
            }
        }
    }*/
}
