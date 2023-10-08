using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 导入场景管理命名空间

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // 检查碰撞对象是否带有"Enemy"标签
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ReloadScene();
        }
    }

    void ReloadScene()
    {
        // 获取当前活动场景的索引并重新加载它
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}

