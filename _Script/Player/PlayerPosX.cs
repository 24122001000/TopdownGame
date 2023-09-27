using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosX : Spawner
{

    int dem = 0;

    // Start is called before the first frame update
    /*void Start()
    {
        this.objPrefabs = GameObject.Find("Bom");
        this.spawnPos = GameObject.Find("BomSpawner");
        this.objPrefabs.SetActive(false);
        this.objects = new List<GameObject>();
    }*/

    private void Reset()
    {
        this.prefabName = "Bom";
        this.spawnPosName = "BomSpawner";
        this.max = 7;
    }

    // Update is called once per frame
    void Update()
    {
        this.Spawn();
        this.CheckDead();
    }
    protected override void Spawn()
    {

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;

        if (this.objects.Count >= 7) return;//Lượng quái spawn ra ko lớn hơn 7
        int index = this.objects.Count + 1; ;

        GameObject minion = Instantiate(this.objPrefabs);//Khởi tạo minion và gán bằng minionprefab

        minion.transform.position = transform.position;//vị trí của minion khi spawn bằng vị trí của player
        minion.transform.parent = spawnPos.transform;
        minion.gameObject.SetActive(true);//Thay đổi trạng thái của gameObject

        index = index + dem;
        minion.name = "Bom #" + index;
        this.objects.Add(minion);
    }

    /*void CheckDead()
    {
        GameObject minion;
        for(int i = 0; i < this.objects.Count; i++)
        {
            minion = this.objects[i];
            if(minion == null)// nếu minion missing
            {
                dem++;
                this.objects.RemoveAt(i);// remove minion đó
            }
        }
    }*/


}
