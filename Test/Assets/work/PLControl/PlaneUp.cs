using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlaneUp : MonoBehaviour {

    //出せる制限
    public int PlanetCount = 2;
    int SaveCount;

    // 生成したいPrefab
    public GameObject Prefab;
    // クリックした位置座標
    private Vector3 clickPosition;

    //接地判定
    public bool OnGround { get; set; }  //追記


    bool frg = false;
    private GameObject toggle_instance;
  
    // Use this for initialization
    void Start()
    {
        SaveCount = PlanetCount;
    }

    // Update is called once per frame
    void Update()
    {
        // マウス入力で左クリックをした瞬間
        if (Input.GetMouseButtonDown(0) && PlanetCount != 0)
        {
            //古いものを消す
            if (frg)
            {
                Destroy(toggle_instance);
                frg = false;
            }



            // ここでの注意点は座標の引数にVector2を渡すのではなく、Vector3を渡すことである。
            // Vector3でマウスがクリックした位置座標を取得する
            clickPosition = Input.mousePosition;
            // Z軸修正
            clickPosition.z = 18.5f;
            // オブジェクト生成 : オブジェクト(GameObject), 位置(Vector3), 角度(Quaternion)
            // ScreenToWorldPoint(位置(Vector3))：スクリーン座標をワールド座標に変換する
            toggle_instance = Instantiate(Prefab, Camera.main.ScreenToWorldPoint(clickPosition), Prefab.transform.rotation) as GameObject;


            PlanetCount--;
            frg = true;
        }


            //消す
            if (Input.GetMouseButtonDown(2))
        {
            Destroy(toggle_instance);
            frg = false;
        }


        }

    private void OnTriggerStay(Collider collision)
    {
        PlanetCount = SaveCount;
    }

        //何もないときに0を返す
        public Vector3 Planet()
    {
        if (toggle_instance != null)
        {
            return toggle_instance.transform.position;
        }
        else
        {
            return Vector3.zero;
        }
        
    }
    public bool PlanetFrg() //受け渡し
    {
        return frg;
    }

    //カウントの受け渡し
    public int PlanetCounter()
    {
        return PlanetCount;
    }
}