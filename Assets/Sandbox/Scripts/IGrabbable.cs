using UnityEngine;

public interface IGrabbable
{
    public void OnHoverEnter();
    public void OnHoverExit();
    public void OnGrab(Transform grabPoint);
    public void OnDrop();
}
