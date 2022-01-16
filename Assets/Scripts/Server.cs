using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Server : MonoBehaviour
{

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 300, 400));
        if (!NetworkManager.Singleton.IsClient && !NetworkManager.Singleton.IsServer)
        {
            StartButtons();
        }
        else
        {
            StatusLabels();
            SubmitNewPosition();
            Shutdown();
        }
    }

    static void StartButtons()
    {
        if (GUILayout.Button("Host")) NetworkManager.Singleton.StartHost();
        if (GUILayout.Button("Client")) NetworkManager.Singleton.StartClient();
        if (GUILayout.Button("Server")) NetworkManager.Singleton.StartServer();
    }

    static void StatusLabels()
    {
        string mode = NetworkManager.Singleton.IsHost ?
            "Host" : NetworkManager.Singleton.IsServer ? "Server" : "Client";

        GUILayout.Label("Transport: " + NetworkManager.Singleton.NetworkConfig.NetworkTransport.GetType().Name);
        GUILayout.Label("Mode: " + mode);
    }

    static void SubmitNewPosition()
    {
        if (GUILayout.Button(NetworkManager.Singleton.IsServer ? "Move" : "Request Position Change"))
        {
            if (NetworkManager.Singleton.IsServer && !NetworkManager.Singleton.IsClient)
            {
                foreach (ulong uid in NetworkManager.Singleton.ConnectedClientsIds)
                    NetworkManager.Singleton.SpawnManager.GetPlayerNetworkObject(uid).GetComponent<HelloWorldPlayer>().Move();
            }
            else
            {
                NetworkObject playerObject = NetworkManager.Singleton.SpawnManager.GetLocalPlayerObject();
                HelloWorldPlayer player = playerObject.GetComponent<HelloWorldPlayer>();
                player.Move();
            }
        }
    }

    static void Shutdown()
    {
        //if (NetworkManager.Singleton.IsServer)
        //{
            if (GUILayout.Button("Shutdown")) NetworkManager.Singleton.Shutdown();
        //}
    }

}
