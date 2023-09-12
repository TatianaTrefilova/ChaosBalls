using UnityEngine;

public class GoalGold : MonoBehaviour
{
    // Флаг достижения цели
    public bool isSolved = false;

    // Метод сравнивает тег цели с тегами контактирующих с ним объектов
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;

        // Если тег цели совпадет с тегом, контактирующего с ней объекта, 
        // то объект будет уничтожен, цель выполнена, а источник света в этом углу отключится
        for (int i = 0; collidedWith.tag == gameObject.tag; i++)
        {
            if (i == 3) 
            {
                // Цель достигнута
                isSolved = true;

                // Отключение источника света на объекте-цели
                GetComponent<Light>().enabled = false;

                // Уничтожение цветного шара
                Destroy(collidedWith);
            }
        }
    }
}
