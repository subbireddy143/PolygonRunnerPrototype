using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace K12.UnleashGames.PolygonRunner.Controller
{
    public class GameController : MonoBehaviour
    {
        public static bool isPlaying=false;

        public void SetIsPlaying(bool state){
            isPlaying = state;
        }
    }
  
}
