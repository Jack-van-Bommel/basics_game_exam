using UnityEditor.Rendering;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Camera in room
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    // Camera on player
    [SerializeField] private Transform player;

    private void Update()
    {
        // Camera in room
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);

        // Camera on player
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }

}
