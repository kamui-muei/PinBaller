using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //Materialを入れる
    Material myMaterial;
    //スコアを表示するテキスト
    private GameObject scoreText;
    //初期化
    int score = 0;


    // Start is called before the first frame update
    void Start()
    {

        //オブジェクトにアタッチしているMateriakを取得
        this.myMaterial = GetComponent<Renderer> ().material;

        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }


    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.score += 1;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            this.score += 2;
        }
        else if(other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 3;
        }
        else if(other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 5;
        }

        this.scoreText.GetComponent<Text> ().text = "SCORE:" + this.score;
    }


}
