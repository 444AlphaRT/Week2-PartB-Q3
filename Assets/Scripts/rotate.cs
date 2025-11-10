using UnityEngine;

public class Rotate : MonoBehaviour
{
    Camera cam; // מצביע למצלמה הראשית
    float baseSize;  // נשתמש לשמירת גודל המצלמה ההתחלתי 
    int baseHeight;// נשתמש לשמירת גובה המסך בפיקסלים בתחילת המשחק
    void Start()
    {
        cam = Camera.main; // מקבלים גישה למצלמה הראשית במשחק
        baseSize = cam.orthographicSize; // שומרים את הגודל ההתחלתי של שדה הראייה של המצלמה
        baseHeight = Screen.height; // גובה הפיקסלים בתחילת המשחק
    }

    void Update()
    {
        // מחשב יחס בין גובה המסך הנוכחי לגובה ההתחלתי,
        // ומכפיל אותו בגודל המצלמה המקורי כך שהזום יישאר זהה גם כשמסובבים את המסך
        cam.orthographicSize = baseSize * ((float)Screen.height / baseHeight);
    }
}
