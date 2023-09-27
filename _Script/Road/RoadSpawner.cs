using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    protected GameObject road;
    protected GameObject roadSpawnPos;
    protected float distance = 0;
    protected GameObject roadCurrent;

    private void Awake()
    {
        this.road = GameObject.Find("Road");
        this.roadSpawnPos = GameObject.Find("RoadSpawnPos");
        this.road.SetActive(false);

        this.Spawn(this.road.transform.position);
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerController.instance.transform.position, this.roadCurrent.transform.position);
        if (distance > 40) Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = roadSpawnPos.transform.position;
        pos.x = 0;
        this.Spawn(pos);
    }

    protected virtual void Spawn(Vector3 position)
    {
        this.roadCurrent = Instantiate(this.road, position, this.road.transform.rotation);
        this.roadCurrent.transform.parent = transform;
        this.roadCurrent.SetActive(true);
    }
}
