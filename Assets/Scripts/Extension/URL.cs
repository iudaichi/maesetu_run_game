using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class URL : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        Debug.Log(gameManager.Score);
    }
   public void onClick()
    {
        Application.OpenURL("https://twitter.com/intent/tweet?text=%E3%82%B9%E3%82%B3%E3%82%A2%E3%81%AF%E2%97%8B%E2%97%8B%E3%81%A7%E3%81%97%E3%81%9F%EF%BC%81%0A%0A%E3%81%BF%E3%82%93%E3%81%AA%E3%82%82%E6%8C%91%E6%88%A6%E3%81%97%E3%81%A6%E3%81%BF%E3%81%A6%E3%81%AD%EF%BC%81%0A%0Ahttps%3A%2F%2Fiudaichi.github.io%2Fmaesetu_run_game%2F%0A%0A%23%E3%81%AF%E3%81%97%E3%82%8C%EF%BC%81%E3%81%BE%E3%81%88%E3%81%9B%E3%81%A4%0A%23%E3%81%BE%E3%81%88%E3%81%9B%E3%81%A4%0A%23%E3%81%AF%E3%81%97%E3%82%8C%E3%81%BE%E3%81%88%E3%81%9B%E3%81%A4");//""の中には開きたいWebページのURLを入力します
    }
}