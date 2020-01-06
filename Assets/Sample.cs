using UnityEngine;
using UnityEngine.Networking;

public class Sample : MonoBehaviour
{
    // 0649 caution

    [SerializeField]
    protected int serializedProtected;

    // 109 caution

    protected new Renderer renderer;

    void Update()
    {
        // 0618 caution

        var networkManager = NetworkManager.singleton;
    }
}