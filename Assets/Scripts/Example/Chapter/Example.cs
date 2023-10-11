using UnityEngine;

public class Example
{
    string[] names = {"jhon", "chulsoo", "bbobbi", "noorung"};

    void Start()
    {
        Debug.Log((int)Days.Mon);
        Debug.Log(names[0]);
    }
}
// 열거형을 사용하는 이유.
// 배열의 인덱스로 호출하는 게 아니라 텍스트로 호출이 가능해
// 인덱스로 호출할 때보다 가독성이 좋다
enum Days
{
    Mon, Tue, Wed, Thu, Fri, Sat, Sun
}

enum Names {
    john, bbobbi = 2, noorung
}

