using UnityEngine;
using System.Globalization;
using UnityEngine.UI;

public class SnakeMove : MonoBehaviour
{
    [SerializeField] private Rigidbody RB;
    [SerializeField] private Text TXT1;
    [SerializeField] private SnakeLength snakeLength;
    [SerializeField] private ModeFever modeFever;
    [SerializeField] private OnDeath onDeath;

    private float PushTimer = 0;
    private float SpeedTimer = 0.2f;
    private float FeverTimer = 0;
    private float PostFeverTimer = 0;

    private float speed = 15;
    [HideInInspector] public float Speed { get { return speed; } set { speed = value; } }

    private bool ActivateLeft = false;
    private bool ActivateRight = false;

    void Update()
    {
        // ���� ModeFever �������, �� ��������� �����������(���� ��������� �� ��������)
        if (FeverTimer <= 0)
        {
            // ��������� ������� �� ��������
            SpeedTimer += Time.deltaTime / (500 - StaticOptions.Difficulty);

            // �������� ����� � ����������� ���������� ���������
            RB.velocity = new Vector3(6 + speed * SpeedTimer - 0.01f * snakeLength.GetToScore(), 0, RB.velocity.z);
            TXT1.text = (this.transform.position.x - 4).ToString("N0", CultureInfo.CurrentCulture);

            // ������ �� ������ ������� "��������" �������
            if (PushTimer > 0)
            {
                PushTimer -= Time.deltaTime;
                if (PushTimer <= 0)
                {
                    PushTimer = 0;
                    ActivateLeft = false;
                    ActivateRight = false;
                }
            }

            // �������� � ������� ��� ������� �� �����/������ ����� ������
            if (ActivateLeft)
            {
                RB.velocity = new Vector3(RB.velocity.x, 0, +(4 + speed * SpeedTimer / 1.5f - 0.009f * snakeLength.GetToScore()));
            }
            else if (ActivateRight)
            {
                RB.velocity = new Vector3(RB.velocity.x, 0, -(4 + speed * SpeedTimer / 1.5f - 0.009f * snakeLength.GetToScore()));
            }

            // ��������� �������� ������� ��� �������� � �������
            transform.eulerAngles = new Vector3(0, -RB.velocity.z, -90);
        }
        // ModeFever �������� ������
        else
        {
            transform.position = Vector3.Lerp(this.transform.position, new Vector3(this.transform.position.x, this.transform.position.y, 0), 1.5f);
            RB.velocity = new Vector3((6 + speed * SpeedTimer - 0.01f * snakeLength.GetToScore()) * 3.5f - StaticOptions.Difficulty / 100, 0, 0);

            FeverTimer -= Time.deltaTime;
            if (FeverTimer <= 0)
            {
                FeverTimer = 0;
                modeFever.FeverMode = false;
            }
        }

        if (PostFeverTimer > 0)
        {
            PostFeverTimer -= Time.deltaTime;
            if (PostFeverTimer <= 0)
            {
                PostFeverTimer = 0;
                StaticOptions.Immortality = false;
            }
        }
    }

    // ModeFever ���������
    public void ActivateFever()
    {
        if (PushTimer > 0) PushTimer = 0;
        transform.eulerAngles = new Vector3(0, 0, -90);
        FeverTimer = 5;

        if (!StaticOptions.Immortality)
        {
            StaticOptions.Immortality = true;
            PostFeverTimer = 6;
        }
    }

    // �������� �������� �����
    public void LeftDown()
    {
        if (PushTimer <= 0 && FeverTimer <= 0)
        {
            ActivateLeft = true;
        }
    }

    public void LeftUp()
    {
        ActivateLeft = false;
    }

    // �������� �������� ������
    public void RightDown()
    {
        if (PushTimer <= 0 && FeverTimer <= 0)
        {
            ActivateRight = true;
        }
    }

    public void RightUp()
    {
        ActivateRight = false;
    }


    // ������������ �� ������
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "RightBorder")
        {
            ActivateLeft = true;
            ActivateRight = false;
            PushTimer = StaticOptions.Difficulty / 200;
        }

        if (collision.transform.name == "LeftBorder")
        {
            ActivateLeft = false;
            ActivateRight = true;
            PushTimer = StaticOptions.Difficulty / 200;
        }
    }
}
