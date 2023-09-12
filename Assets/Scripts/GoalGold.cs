using UnityEngine;

public class GoalGold : MonoBehaviour
{
    // ���� ���������� ����
    public bool isSolved = false;

    // ����� ���������� ��� ���� � ������ �������������� � ��� ��������
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;

        // ���� ��� ���� �������� � �����, ��������������� � ��� �������, 
        // �� ������ ����� ���������, ���� ���������, � �������� ����� � ���� ���� ����������
        for (int i = 0; collidedWith.tag == gameObject.tag; i++)
        {
            if (i == 3) 
            {
                // ���� ����������
                isSolved = true;

                // ���������� ��������� ����� �� �������-����
                GetComponent<Light>().enabled = false;

                // ����������� �������� ����
                Destroy(collidedWith);
            }
        }
    }
}
