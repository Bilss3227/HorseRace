using UnityEngine;

public class followplayer : MonoBehaviour
{
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private Vector3 offset;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = transformPlayer.position + offset;
    }
}
