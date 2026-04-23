using UnityEngine;

public class EnemyBounce : MonoBehaviour
{
    public float bounceForce = 15f;      
    public float upwardBoost = 1f;       

    private void OnTriggerEnter(Collider other)
    {
        
        PlayerController player = other.GetComponent<PlayerController>();
        if (player == null) return;

        
        Vector3 awayDir = (other.transform.position - transform.position).normalized;

        
        Vector3 launchDir = (awayDir + Vector3.up * upwardBoost).normalized;

       
        player.Launch(launchDir, bounceForce);
    }
}