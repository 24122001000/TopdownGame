using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDespawner : MonoBehaviour
{
    protected float distance = 0;

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerController.instance.transform.position, transform.position);
        if (distance > 70) Despawn();
    }

    protected virtual void Despawn()
    {
        Destroy(gameObject);
    }
}
