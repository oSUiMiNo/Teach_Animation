using UnityEngine;

public class CubeController2 : MonoBehaviour
{
    // 毎フレーム呼ばれる
    void Update()
    {
        // 回転
        transform.Rotate(0, 0.5f, 0);
    }
}
