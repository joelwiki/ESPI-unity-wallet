using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;


public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject ConnectedState;
    public GameObject DisconnectedState;
    public ThirdwebSDK sdk;
    void Start()
    {
        //sdk = new ThirdwebSDK("sepolia", 11155111, new ThirdwebSDK.Options());
    }
    
    public async void ConnectWallet(){

        Debug.LogWarning(
                 "No Client ID provided. You will have limited access to thirdweb services for storage, RPC, and Account Abstraction. You can get a Client ID from https://thirdweb.com/create-api-key/"
             );

        string address = await ThirdwebManager.Instance.SDK.wallet.Connect(new WalletConnection(WalletProvider.WalletConnect, 1));

        Debug.LogWarning(
                    "No Client ID provided. You will have limited access to thirdweb services for storage, RPC, and Account Abstraction. You can get a Client ID from https://thirdweb.com/create-api-key/"
                );

        DisconnectedState.SetActive(false);
        ConnectedState.SetActive(true);
        
        ConnectedState.transform
        .Find("Address")
        .GetComponent<TMPro.TextMeshProUGUI>()
        .text = address;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
