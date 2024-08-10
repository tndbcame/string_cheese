using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    public float speed = 200.0f;
    public float startPosition;
    public float endPosition;
    public float ObjectPosition;

    void Update()
    {

        // 毎フレームxポジションを少しずつ移動させる
        transform.Translate(0, 1 * speed * Time.deltaTime * 5, 0);

        // スクロールが目標ポイントまで到達したかをチェック
        if (transform.position.y >= ObjectPosition ) Cotroller.isGetPoint = true;
        if (transform.position.y >= endPosition) ScrollEnd();
    }

    void ScrollEnd()
    {
        //Debug.Log(transform.position.y);
        //// 通り過ぎた分を加味してポジションを再設定
        //float diff = transform.position.y - endPosition;
        //Vector3 restartPosition = transform.position;
        //restartPosition.y = startPosition + diff;

        //transform.position = restartPosition;

        // 同じゲームオブジェクトにアタッチされているコンポーネントにメッセージを送る
        SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
    }
}
