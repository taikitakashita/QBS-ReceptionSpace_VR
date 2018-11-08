using FancyScrollView;
using System.Linq;

public class MyScrollView : FancyScrollView<MyCellData>
{
    public ScrollPositionController controller;

    private void Awake()
    {
        // セルのデータのリスト
        cellData = Enumerable.Range(0, 8)
            .Select(i => new MyCellData { Message = "Cell " + i })
            .ToList()
        ;

        // セルの数を設定
        controller.SetDataCount(cellData.Count);

        // セルの位置を更新する時に呼び出されるコールバックを設定
        controller.OnUpdatePosition(p => UpdatePosition(p));

        // 表示を更新
        UpdateContents();
    }
}