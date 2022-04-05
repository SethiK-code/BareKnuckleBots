using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createIF;
    public InputField joinIF;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createIF.text);
    }
    
    public void JoinRoom()
    {
        PhotonNetwork.CreateRoom(joinIF.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("GameScene");
    }
}
