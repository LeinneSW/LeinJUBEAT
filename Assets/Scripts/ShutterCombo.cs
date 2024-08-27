using UnityEngine;

public class ShutterCombo : MonoBehaviour
{
    private bool up;
    private readonly float amplitude = 8f;  // ���������� ������ �ݰ�
    private readonly float frequency = 3.2f;  // �ֱ� (�ʴ� �������� Ƚ��)

    void Start()
    {
        up = gameObject.name.Contains("Up");
    }

    void Update()
    {
        var position = transform.position;
        var percent = GameManager.Instance.ShutterPoint * 810 / 1024;
        var animation = Mathf.Sin(Time.time * frequency * 2 * Mathf.PI) * amplitude;
        if (up)
        {
            position.y = -130 + amplitude + percent + animation;
        }
        else
        {
            position.y = -830 - amplitude - percent - animation;
        }
        transform.position = position;
    }
}
