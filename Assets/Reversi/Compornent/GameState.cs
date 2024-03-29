using Unity.Entities;
using Unity.Tiny.Core2D;

public struct GameState : IComponentData
{
    //ゲームが進行中なのか、終了しているのか格納します
    public bool IsActive;

    //  どちらのターンなのかを格納します
    public int NowTurn;

    // 決着がついたかどうか格納します
    public bool GameEnd;

    //勝者を格納します 0=未確定　1=黒 2=白
    public int WinnetNum;
}
