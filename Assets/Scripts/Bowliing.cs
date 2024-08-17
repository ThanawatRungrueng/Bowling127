using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Bowliing : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    int forcePower;

    [SerializeField]
    float Increment;

    public string winMessage = "You Win!";
    public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winText.enabled = false;
    }

    void Update()
    {
        // ���������Ѻ��������ѧ������ ��ҵ�ͧ���
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShootBowl();
        }

        // ��äǺ����������͹����ѧ������
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }

        // ��Ǩ�ͺ��á����� R ������ʵ�����
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void ShootBowl()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);
    }

    public void MoveLeft()
    {
        transform.position += new Vector3(-Increment, 0f, 0f);
    }

    public void MoveRight()
    {
        transform.position += new Vector3(Increment, 0f, 0f);
    }

    public void MoveDown()
    {
        transform.position += new Vector3(0f, 0f, -Increment);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WinObject"))
        {
            winText.text = winMessage;
            winText.enabled = true;

            Rigidbody playerRigidbody = GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                playerRigidbody.velocity = Vector3.zero;
                playerRigidbody.angularVelocity = Vector3.zero;
            }

            Time.timeScale = 0;
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
