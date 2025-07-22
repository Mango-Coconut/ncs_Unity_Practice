using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    enum RedBtnState
    {
        standard,
        down,
        held,
        up
    }
    #region field
    private Image graphic;
    #region sprites
    public Sprite stardard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    #endregion
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;
    #endregion

    private void Awake()
    {
        graphic = GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = stardard;
    }

    // Update is called once per frame
    void Update()
    {

        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = stardard;
        }

        boolDisplay1.text = "down : " + down;
        boolDisplay2.text = "held : " + held;
        boolDisplay3.text = "up : " + up;

    }
}
