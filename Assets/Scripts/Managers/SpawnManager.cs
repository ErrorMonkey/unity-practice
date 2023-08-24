using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject EnemyPrefab1;
    //public GameObject EnemyPrefab2;
    public GameObject[] EnemyPrefabs;

    private void Start()
    {
        SpawnRandom();
        //SpawnEnemy(EnemyPrefab1, new Vector3(-1, 2, 0));
        //SpawnEnemy(EnemyPrefab2, new Vector3(1, 2, 0));
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (j % 2 == 0)
        //        {
        //            SpawnEnemy(EnemyPrefab1, new Vector3(i, j, 0));
        //        }
        //        else
        //        {
        //            SpawnEnemy(EnemyPrefab2, new Vector3(i, j, 0));
        //        }
        //    }
        //}
    }

    void SpawnRandom()
    {
        GameObject prefab = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
        Points points = new Points();
        Vector2 pos = points[Random.Range(0,points.GetLength())].GetPos();

        SpawnEnemy(prefab, pos);
        Invoke("SpawnRandom", 1.0f);
    }

    void SpawnEnemy(GameObject prefab, Vector3 position){
        GameObject enemy = Instantiate(prefab);
        enemy.transform.position = position;
        enemy.GetComponent<Enemy>().Move();
    }
}
