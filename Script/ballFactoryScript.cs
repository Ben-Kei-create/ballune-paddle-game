using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFactoryScript : MonoBehaviour
{
    
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(ball, transform.position, transform.rotation);
        // InvokeRepeatingとは、指定した関数を繰り返し呼び出すメソッドです。
        // 第1引数: 呼び出す関数名
        // 第2引数: 最初の呼び出しまでの遅延時間（秒）
        // 第3引数: 呼び出し間隔（秒）
        InvokeRepeating("SpawnBall", 0f, 1f);
    }

    void SpawnBall()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-5f, 5f),
            transform.position.y,
            transform.position.z
        );
        // ボールをスポーンする位置をランダムに設定します。
        // X座標は-5から5の間でランダムに選択され、Y座標とZ座標はこのオブジェクトの位置を使用します。
        Instantiate(ball, spawnPosition, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
