using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LoginManager : MonoBehaviourPunCallbacks
{
    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region UI Callbacks Methods
    public void ConnectAnonymously()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    #endregion

    #region Photon Callbacks Methods
    public override void OnConnected()
    {
        Debug.Log("There is Server avaibale.");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master.");
    }

    #endregion

}
