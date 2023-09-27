using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 12f);//thực hiện câu lệnh sau 12s (invoke("biến", số giây))
    }

    private void Destroy()
    {
        Destroy(gameObject);//Phá huỷ gameobject
    }
}
