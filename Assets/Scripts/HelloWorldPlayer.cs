using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class HelloWorldPlayer : NetworkBehaviour
{
    public NetworkVariable<Vector3> Position = new NetworkVariable<Vector3>();

    public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
            Move();
        }
    }

    public void Move()
    {
        if (NetworkManager.Singleton.IsServer)
        {
            Vector3 randomPosition = GetRandomPositionOnPlane();
            transform.position = randomPosition;
            Position.Value = randomPosition;
        }
        else
        {
            SubmitPositionRequestServerRpc();
        }
    }

    [ServerRpc]
    void SubmitPositionRequestServerRpc(ServerRpcParams rpcParams = default)
    {
        Position.Value = GetRandomPositionOnPlane();
    }

    static Vector3 GetRandomPositionOnPlane()
    {
        return new Vector3(Random.Range(0f, 1000f), 50f, Random.Range(0f, 1000f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Position.Value;
    }
}
