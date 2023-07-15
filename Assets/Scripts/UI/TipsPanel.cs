using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsPanel : BasePanel<TipsPanel>
{
    public UIButton btnEnter;
    public UILabel labInfo;

    public override void Init()
    {
        btnEnter.onClick.Add(new EventDelegate(() =>
        {
            Hide(); // 点击确定隐藏自己
        }));

        Hide();
    }

    public void ChangeInfo(string text)
    {
        labInfo.text = text;
    }
}