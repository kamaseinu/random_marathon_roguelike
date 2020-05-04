using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

  int[,] map;

    void Start()
    {

      //マップ情報を取得
      map = DungeonManager.GetMap();

    }


    void Update()
    {

      //敵とプレイヤーの座標を取得
      Transform myTransform = this.transform;
      Vector3 my_pos = myTransform.position;
      Vector3 me_pos = GameObject.Find("me(Clone)").transform.position;

      //近くにいるかどうか（周囲６マス以内かどうか）
      if ((my_pos.x >= me_pos.x-6.0f && my_pos.x <= me_pos.x+6.0f) && (my_pos.z >= me_pos.z-6.0f && my_pos.z <= me_pos.z+6.0f)) {   //近い場合

      }else{    //遠い場合（ランダム行動）
        if (Input.anyKeyDown){
            int xxx = Random.Range(0, 100);
            if (xxx <= 25) {
              if (map[(int)my_pos.x, (int)my_pos.z + 1] != 0) my_pos.z += 1.0f;
            }else if (xxx <= 50) {
              if (map[(int)my_pos.x - 1, (int)my_pos.z] != 0) my_pos.x -= 1.0f;
            }else if (xxx <= 75) {
              if (map[(int)my_pos.x, (int)my_pos.z - 1] != 0) my_pos.z -= 1.0f;
            }else{
              if (map[(int)my_pos.x + 1, (int)my_pos.z] != 0) my_pos.x += 1.0f;
            }
        }
      }

      myTransform.position = my_pos;  // 座標を設定
    }
}
