using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = -160;
    //ゴール地点
    private int goalPos = 120;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;


    private GameObject unitychan;//

    // Use this for initialization
    void Start () {

        this.unitychan = GameObject.Find("unitychan");

    }
	
	// Update is called once per frame
	void Update () {
        //１つ１つにアタッチ
        if (this.transform.position.z < unitychan.transform.position.z-20)
        {
            Destroy(this.gameObject);
        }


    }
}
