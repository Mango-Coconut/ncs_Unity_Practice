using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    
    
    void TemperatureTest ()
    {
        // 커피 온도가 가장 뜨거운 섭취 온도보다 높은 경우
        if(coffeeTemperature > hotLimitTemperature)
        {
            // 다음을 실행합니다.
            print($"{coffeeTemperature} Coffee is too hot.");
        }
        // 그렇지 않고 커피 온도가 가장 차가운 섭취 온도보다 낮은 경우
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // 다음을 실행합니다.
            print($"{coffeeTemperature} Coffee is too cold.");
        }
        // 둘 다 해당하지 않는 경우
        else
        {
            // 다음을 실행합니다.
            print($"{coffeeTemperature} Coffee is just right.");
        }
    }
}
