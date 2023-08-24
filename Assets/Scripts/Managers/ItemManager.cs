using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] ItemPrefabs;
    public Point[] points = {
        new Point(0,0),
        new Point(1,0),
        new Point(0,1),
        new Point(2,0),
        new Point(0,2),
        new Point(-1,0),
        new Point(0,-1),
        new Point(-2,0),
        new Point(0,-2)
    };

    void Start()
    {
        SpawnRandom();
        //GameObject CoinPrefab = GetItem(Items.Coin);
        //GameObject SpeedUpPrefab = GetItem(Items.SpeedUp);

        //for (int i = 0; i < 5; i++)
        //{
        //    Points points = new Points();
        //    GameObject ItemPrefab = ItemPrefabs[Random.Range(0,ItemPrefabs.Length)];
        //    Vector2 pos = points[Random.Range(0,points.GetLength())].GetPos();
            
        //    SpawnItem(ItemPrefab, pos);
        //}
    }

    void SpawnRandom()
    {
        GameObject prefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
        Points points = new Points();
        Vector2 pos = points[Random.Range(0, points.GetLength())].GetPos();

        SpawnItem(prefab, pos);
        Invoke("SpawnRandom", 1.0f);
    }

    void SpawnItem(GameObject ItemPrefab, Vector2 pos){
        GameObject item = Instantiate(ItemPrefab);
        item.transform.position = pos;
    }

    GameObject GetItem(Items item)
    {
        return ItemPrefabs[(int)item];
    }
}

enum Items
{
    Coin, SpeedUp, PowerUp, DefenseUp
}

class Points
{
    public Point[] points = {
        new Point(0,0),
        new Point(1,0),
        new Point(0,1),
        new Point(2,0),
        new Point(0,2),
        new Point(-1,0),
        new Point(0,-1),
        new Point(-2,0),
        new Point(0,-2)
    };

    public Point this[int index]{
        get {
            return points[index];
        }
        set {
            points[index] = value;
        }
    }

    public int GetLength(){
        return points.Length;
    }
}

public struct Point
{
    int x;
    int y;

    public Point(int x, int y){
        this.x = x;
        this.y = y;
    }

    public Vector2 GetPos(){
        return new Vector2(this.x, this.y);
    }

}