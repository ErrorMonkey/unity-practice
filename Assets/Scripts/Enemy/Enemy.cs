using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 유니티에서의 객체 생성
    // 1. 생성자를 통한 객체 생성
    // 2. 스크립트를 게임오브젝트에 부착해서 생성
    
    // * 피격 과정
    // 1. 적군과 총알이 충돌
    // - Collider
    // 2. 충돌 시 적군의 체력이 감소
    // - OnCollisionEnter2D -> 콜라이더 끼리의 충돌을 스크립트로 가져온다.
    // - OnCollisionStay2D, OnCollisionExit2D
    // 3. 충돌 후 총알이 소멸

    // * tag
    // - 유니티의 게임 오브젝트를 구분하기 위한 요소
    
    private float health = 50.0f;
    public float Speed = 1000f;

    public float Health{
        get { return health; }
    }
 
    void TakeDamage(float value) {
        health -= value;
        Debug.Log("enemy의 체력 "+health);  

        if (health <=0)
        {
            Die();
        }
    }

    void Die() {
        Destroy(gameObject);
    }

    public float GetHealth() {
        return health;
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            // 나랑 충돌한 총알을 없애라
            TakeDamage(10);
            coll.gameObject.SetActive(false);
        }
    }

    public virtual void Move(){
        
    }
}