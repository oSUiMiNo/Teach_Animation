using UnityEngine;

public class CubeController0 : MonoBehaviour
{
    // 初回に１回だけ呼ばれる
    void Start()
    {
        transform.localScale += new Vector3(2, 2, 2);
    }
}
