using UnityEngine;
using System.Collections;

public class attackTrigger : MonoBehaviour {

    public int damage = 20;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.isTrigger && other.tag=="Enemy")
        {
            other.SendMessageUpwards("TakingDamage", damage);
        }
    }
}
