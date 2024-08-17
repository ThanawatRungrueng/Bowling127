using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public class WinOnCollision : MonoBehaviour
    {
        public string winMessage = "You Win!";
        public Text winText;

        private void Start()
        {
            // ��͹��ͤ�����е͹�������
            winText.enabled = false;
        }
        private void OnCollisionEnter(Collision collision)
        {
            // ��Ǩ�ͺ��Ҽ����蹪��Ѻ�ѵ�ط���˹��������
            if (collision.gameObject.CompareTag("WinObject"))
            {
                // �ʴ���ͤ������
                winText.text = winMessage;
                winText.enabled = true;

                // ��ش�������͹��Ǣͧ������ (�����)
                Rigidbody playerRigidbody = GetComponent<Rigidbody>();
                if (playerRigidbody != null)
                {
                    playerRigidbody.velocity = Vector3.zero;
                    playerRigidbody.angularVelocity = Vector3.zero;
                }

                // ��ش����Ѿവ��
                Time.timeScale = 0;
            }
        }
    }
    }
