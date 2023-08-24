using UnityEngine;
using System.Collections;

public class CollectionExample : MonoBehaviour
{
	// * 배열의 비효율성
	// - 크기를 변경할 수 없다.

	int[] numbers = new int[5];

    private void Start()
    {
        numbers[0] = 1;
        numbers = new int[6];
    }
}

