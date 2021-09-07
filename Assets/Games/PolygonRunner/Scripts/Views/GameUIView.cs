using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using K12.UnleashGames.PolygonRunner.Controller;
using K12.UnleashGames.PolygonRunner.Models;

namespace K12.UnleashGames.PolygonRunner.Views
{
    public class GameUIView : MonoBehaviour
    {
        public Text coinText;
        public GameUIController gameUIController;

        // Update is called once per frame
        void Update()
        {
            gameUIController.SetTextValue(coinText,PlayerModel.coins.ToString());
        }
    }
  
}
