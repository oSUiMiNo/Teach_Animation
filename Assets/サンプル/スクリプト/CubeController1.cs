using UnityEngine;

public class CubeController1 : MonoBehaviour
{
    // 毎フレーム呼ばれる
    void Update()
    {
        // 移動
        transform.position += new Vector3(0.01f, 0, 0);
    }
}
