using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static public UIManager instance;

    public GameObject btnGameOver;

    // Start is called before the first frame update
    void Start()
    {
        UIManager.instance = this;
        this.btnGameOver = GameObject.Find("btnGameOver");
        this.btnGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
