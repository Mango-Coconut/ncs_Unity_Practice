using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�� ���� ������Ʈ�� x ��ġ�� ��Ÿ���ϴ�.

        /*�ȳ��ϼ���.
         * �� �ٷ� ������ �ּ��Դϴ�.
         * */
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
