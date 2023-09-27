using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 20f;
    public float dislimit = 3f;
    public float ramdomPos = 0;

    
    private void Awake()
    {
        this.player = PlayerController.instance.transform;

        this.ramdomPos = Random.Range(-6, 6);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        this.Follow();
    }

    void Follow()
    {
        Vector3 pos = this.player.position;
        pos.x = ramdomPos;

        Vector3 distance = pos - transform.position;

        if (distance.magnitude >= this.dislimit)//Nếu khoảng cách lớn hơn bằng 3 thì quái bắt đầu dí
        {
            Vector3 targetPoint = pos - distance.normalized * this.dislimit;

            transform.position =
                Vector3.MoveTowards(transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }
    }
}
