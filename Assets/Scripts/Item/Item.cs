using UnityEngine;


public abstract class Item : MonoBehaviour
{
    private void Start()
    {
        DestroyAfterTime();
    }

    // 1. 시간이 지나면 사라지는
    public abstract void DestroyAfterTime();
    // 2. 아이템을 획득하면 적용되는
    public abstract void ApplyItem();

    public void DestroyThis()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            ApplyItem();
        }
    }
}

public interface IEffect
{
    void GetOpaque();
}