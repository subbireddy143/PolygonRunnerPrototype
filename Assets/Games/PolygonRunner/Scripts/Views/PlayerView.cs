using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using K12.UnleashGames.PolygonRunner.Models;
using K12.UnleashGames.PolygonRunner.Controller;

namespace K12.UnleashGames.PolygonRunner.Views
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField]
        public PlayerModel player;
        public PlayerController playerController;
        public GameObject reStartButton;
        
        // Start is called before the first frame update
        void Start()
        {
            GameController.isPlaying = true;
            player = new PlayerModel();
            player.forwardSpeed = 0f;
            player.sideSpeed = 0.01f;
        }

        // Update is called once per frame
        void Update()
        {
            playerController.MoveForward(player.forwardSpeed);
            if(GameController.isPlaying){
                playerController.SideMovements(player.sideSpeed);
            }
        }

        private void OnCollisionEnter(Collision other) {
            if(other.gameObject.tag == "Block"){
                player.forwardSpeed = 0;
                GameController.isPlaying = false;
                reStartButton.SetActive(true);
            }
        }

        private void OnTriggerEnter(Collider other) {
            if(other.gameObject.tag=="Coin"){
                PlayerModel.coins++;
                Destroy(other.gameObject);
            }
            if(other.gameObject.tag=="Finish"){
                reStartButton.SetActive(true);
                player.forwardSpeed = 0;
                transform.position = Vector3.Lerp((transform.position), 
                    new Vector3(transform.position.x,transform.position.y+2f,
                    transform.position.z+1.5f),
                    0.5f);
            }
        }
        public void SetForwardSpeed(int value){
            player.forwardSpeed = value;
        }

    }
  
}
