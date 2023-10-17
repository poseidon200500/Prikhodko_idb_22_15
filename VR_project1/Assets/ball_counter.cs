using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball_counter : MonoBehaviour
{
    public int counter = 100;
    public Text counterText; // Ссылка на компонент Text

    void Start()
    {
        UpdateCounterText(); // Вызываем метод для обновления текста
    }

    void UpdateCounterText()
    {
        counterText.text = "Счет: " + counter.ToString(); // Обновляем текст компонента
    }

    private void OnCollisionEnter(Collision collision)
    {
        counter--;
        UpdateCounterText();
        print(counter);
    }
}
