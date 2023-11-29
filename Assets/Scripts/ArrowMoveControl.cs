using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMoveControl : SimpleMoveControl
{
    protected override bool CheckHorizontalInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            return true;
        }

        return false;
    }

    protected override bool CheckVerticalInput()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            return true;
        }

        return false;
    }

    protected override int GetHorizontalInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            return -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            return 1;
        }

        return 0;
    }

    protected override int GetVerticalInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            return 1;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            return -1;
        }

        return 0;
    }
}
