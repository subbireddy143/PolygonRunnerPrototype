using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace  K12.UnleashGames.PolygonRunner.Controller
{


  public class GameUIController : MonoBehaviour
    {
        public void MakeInactive(GameObject gameObject){
            gameObject.SetActive(false);
        }
        public void MakeActive(GameObject gameObject){
            gameObject.SetActive(true);
        }
        public void SetTextValue(Text current,string value){
            current.text = value;
        }

        public void LoadLevel(string level){
            SceneManager.LoadScene(level);
        }
    }
}
