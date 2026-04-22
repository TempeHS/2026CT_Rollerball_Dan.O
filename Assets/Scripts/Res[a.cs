using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform teleportTarget;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = teleportTarget.position;
        }
    }
}