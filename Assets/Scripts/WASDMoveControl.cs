using UnityEngine;

public class WASDMoveControl : SimpleMoveControl
{
    protected override bool CheckHorizontalInput()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            return true;
        }

        return false;
    }

    protected override bool CheckVerticalInput()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            return true;
        }

        return false;
    }

    protected override int GetHorizontalInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            return -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            return 1;
        }

        return 0; 
    }

    protected override int GetVerticalInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            return 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            return -1;
        }

        return 0;
    }
}
