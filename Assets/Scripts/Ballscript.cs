using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ballscript : MonoBehaviour {
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    public GameObject scoretext;
    public int score ;
    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    // Use this for initialization
    void Start () {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        

    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        this.scoretext.GetComponent<Text>().text = "score=" + score.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="LargeCloudTag")
        {
            score += 10;
        }
        if (collision.gameObject.tag=="SmallCloudTag")
        {
            score += 20;
        }
        if (collision.gameObject.tag=="LargeStarTag")
        {
            score += 500;
        }
        if (collision.gameObject.tag=="SmallStarTag")
        {
            score += 15;
        }
           
    }
    
        
    
}
