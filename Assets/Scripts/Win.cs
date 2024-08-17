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
            // ซ่อนข้อความชนะตอนเริ่มเกม
            winText.enabled = false;
        }
        private void OnCollisionEnter(Collision collision)
        {
            // ตรวจสอบว่าผู้เล่นชนกับวัตถุที่กำหนดหรือไม่
            if (collision.gameObject.CompareTag("WinObject"))
            {
                // แสดงข้อความชนะ
                winText.text = winMessage;
                winText.enabled = true;

                // หยุดการเคลื่อนไหวของผู้เล่น (ถ้ามี)
                Rigidbody playerRigidbody = GetComponent<Rigidbody>();
                if (playerRigidbody != null)
                {
                    playerRigidbody.velocity = Vector3.zero;
                    playerRigidbody.angularVelocity = Vector3.zero;
                }

                // หยุดการอัพเดตเกม
                Time.timeScale = 0;
            }
        }
    }
    }
