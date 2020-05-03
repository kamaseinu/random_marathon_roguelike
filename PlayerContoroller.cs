using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoroller : MonoBehaviour{

    private Vector3 velocity;              // 移動方向
    private float moveSpeed = 5.0f;        // 移動速度
    Animator animator;

    void Start(){

    }

    void Update(){

      // transformを取得
      Transform myTransform = this.transform;

      // 座標を取得
      Vector3 pos = myTransform.position;

      if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
          pos.z += 1.0f;
      }
      if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
          pos.x -= 1.0f;
      }
      if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)){
          pos.z -= 1.0f;
      }
      if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
          pos.x += 1.0f;
      }


      myTransform.position = pos;  // 座標を設定
    }
}
