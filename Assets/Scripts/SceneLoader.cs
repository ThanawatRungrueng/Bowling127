using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        // ����¹��ѧ�ҡ����ͧ��� �� MainScene
        SceneManager.LoadScene("SampleScene");
    }
}
