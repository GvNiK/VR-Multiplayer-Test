using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIManager : MonoBehaviour
{
    public GameObject connectOptionsPlanel;
    public GameObject connectWithNamePlanel;

    #region  Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        connectOptionsPlanel.SetActive(true);
        connectWithNamePlanel.SetActive(false);
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
