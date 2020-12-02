using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Camera cam;
    public RaycastHit hit;
    public Vector2 input;
    Vector2 startedPos;
    Vector2 delta;
    PointerEventData eventData;
    bool isPointUp;
    private float maxDistance = 100f;
    #region Singleton
    public static InputManager instance = null;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    #endregion

    public void OnPointerDown(PointerEventData _eventData)
    {
        startedPos = _eventData.position;
        eventData = _eventData;
        isPointUp = false;
    }
    public void OnPointerUp(PointerEventData _eventData)
    {
        eventData = null;
        input = new Vector2(0, 0);
        hit = new RaycastHit();
        isPointUp = true;
    }
    private void FixedUpdate()
    {
        if (eventData == null) return;
        Ray ray = cam.ScreenPointToRay(eventData.position);
        Physics.Raycast(ray, out hit);
        delta = eventData.position - startedPos;
        if (isPointUp) delta=new Vector2(0,0);
        input = delta / maxDistance*Time.deltaTime;
    }
}