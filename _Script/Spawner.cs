using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefabs;
    public GameObject spawnPos;
    public List<GameObject> objects;
    public float spawnTimer = 0f;
    public float spawnDelay = 1f;
    public string prefabName ="";
    public string spawnPosName ="";
    public int max = 1;

    private void Awake()
    {
        this.objPrefabs = GameObject.Find(this.prefabName);
        this.spawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefabs.SetActive(false);
        this.objects = new List<GameObject>();
    }
    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual void Spawn()
    {
        if (PlayerController.instance.dameReceiver.IsDead()) return;
        if (this.objects.Count >= max) return;

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;

        GameObject enemy = Instantiate(this.objPrefabs);
        enemy.transform.position = spawnPos.transform.position;
        enemy.transform.parent = transform;
        enemy.SetActive(true);

        this.objects.Add(enemy);

    }

    protected virtual void CheckDead()
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
    }

}
