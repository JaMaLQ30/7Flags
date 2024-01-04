using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class NweWorkConnect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    public override void OnConnectedToMaster()
    {
<<<<<<< Updated upstream
        SceneManager.LoadScene(0);
=======
        SceneManager.LoadScene(2);
>>>>>>> Stashed changes
    }
}
