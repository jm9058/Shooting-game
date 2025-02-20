using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    [SerializeField]
    private int damage = 5;                 // 운석 공격력
    [SerializeField]
    private GameObject explosoinPrefab2;    // 폭발 효과

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        // 운석에 부딪힌 오브젝트의 태그가 "Player"이면
        if (collision.CompareTag("Player"))
        {
            // 운석 공격력만큼 플레이어 체력 감소
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            // 폭발 이펙트 생성
            // Instantiate(explosoinPrefab2, transform.position, Quaternion.identity);
            // 운석 사망
            // Destroy(gameObject);
            OnDie();
        }    
    }

    public void OnDie()
    {
        // 폭발 이펙트 생성
        Instantiate(explosoinPrefab2, transform.position, Quaternion.identity);
        // 운석 사망
        Destroy(gameObject);
    }
}


/*
 * File : Meteorite.cs
 * Desc
 * : 운석 오브젝트에 부착해서 사용
 *
 * Functions
 *
 */