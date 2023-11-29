using UnityEngine;

public class SimpleMoveControl : MonoBehaviour
{
    protected float _speed = 3f;
    protected virtual int GetHorizontalInput()
    {
        return 0;
    }

    protected virtual int GetVerticalInput()
    {
        return 0;
    }

    protected virtual bool CheckHorizontalInput()
    {
        return false;
    }

    protected virtual bool CheckVerticalInput()
    {
        return false;
    }

    private void Update()
    {
        if (CheckHorizontalInput())
        {
            transform.position = transform.position + transform.right * GetHorizontalInput() * _speed * Time.deltaTime;
        }

        if (CheckVerticalInput())
        {
            transform.position = transform.position + transform.forward * GetVerticalInput() * _speed * Time.deltaTime;
        }
    }
}
