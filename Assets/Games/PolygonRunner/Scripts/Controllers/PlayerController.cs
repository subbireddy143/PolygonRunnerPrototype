using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace K12.UnleashGames.PolygonRunner.Controller
{
    public class PlayerController : MonoBehaviour
    {
        public Rigidbody player;
        public Transform playerMesh;
        public void MoveForward(float speed){
            player.velocity = new Vector3(0,0,speed);
        }
        public void MoveUp(float speed){
            player.velocity = new Vector3(0,speed,0);
        }

        public void SideMovements(float moveSpeed){
            if(Input.touchCount>0)//Input.GetMouseButtonDown(0)
            {
                Touch touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    case TouchPhase.Moved:
                        playerMesh.position = new Vector3(
                            Mathf.Clamp(playerMesh.position.x+touch.deltaPosition.x*moveSpeed,-2,2),
                            playerMesh.position.y,
                            playerMesh.position.z
                        );
                        // playerMesh.Rotate(0,0,1f*touch.deltaPosition.x,Space.Self);
                        playerMesh.localEulerAngles = new Vector3(0,0,Mathf.Clamp(-1.5f*touch.deltaPosition.x,-10,10));
                        break;
                    case TouchPhase.Ended:
                        playerMesh.localEulerAngles = new Vector3(0,0,0);
                        break;
                }
            }
        }

    }
}

