using UnityEngine;
using UnityEngine.Events;   // UnityEvent を使うための名前空間

/// <summary>
/// スイッチを制御するコンポーネント。
/// GameObject に追加されているトリガーにプレイヤーが接触したら、Actions に登録した関数を呼び出す。
/// </summary>
public class Switch : MonoBehaviour
{
    [Tooltip("スイッチのトリガーに Player が接触した時に呼ぶ関数を登録する。")]
    [SerializeField] UnityEvent m_actions = default;
    [SerializeField] UnityEvent m_action = default;
    [SerializeField]bool el = true;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") &&el)
        {
            // 登録した関数を呼び出す。
            m_actions.Invoke();
           
        }
        
        if (collision.gameObject.tag.Equals("Player") && el==false)
        {
            m_action.Invoke();
            
        }
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        el = false;
    }
   // void OnTriggerEnter2D(Collider2D collision)
   // {
   //     if(el==false)
   //     {
    //        el = true;
   //     }
    //}

}
