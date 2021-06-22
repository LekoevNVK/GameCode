using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Unit : MonoBehaviour
{
    public virtual void ReceiveDamage()
    {
        Die();
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}
