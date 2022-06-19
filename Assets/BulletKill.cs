using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletKill : MonoBehaviour
{
    [SerializeField] private LvlProgress lvlProgress;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        int cur = lvlProgress.curLvl;
        int randDamage = Random.Range(2*cur, 5*cur);
        DamagePopup.Create(transform.localPosition, (int)randDamage);
        lvlProgress.UpdateProgressFill(randDamage);

        if (collision.gameObject.TryGetComponent<Enemy> (out Enemy enemyComponent)) 
        {
            enemyComponent.takeDamage();
        }
        Destroy(gameObject);
    }
    void Awake()
    {
        lvlProgress = LvlProgress.FindObjectOfType<LvlProgress>();
    }

}
