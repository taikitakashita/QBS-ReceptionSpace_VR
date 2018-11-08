using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

public class MyScrollCell : FancyScrollViewCell<MyCellData>
{
    public Text message;

    // 表示を更新する時に呼び出されます
    public override void UpdateContent(MyCellData itemData)
    {
        message.text = itemData.Message;
    }

    // 位置を更新する時に呼び出されます
    // Animator を使用することでアニメーションを適用することも可能です
    public override void UpdatePosition(float position)
    {
        var pos = transform.localPosition;
        pos.x = Mathf.Lerp(50, -50, position);
        transform.localPosition = pos;
    }
}