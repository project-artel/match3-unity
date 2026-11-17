#if ARTEL_GAME_FUNCTIONS
using Artel;
using Match3.Game;

internal static class Match3ResetGameCheat
{
    [ArtelOverrideCheat("reset_game", "진행 중인 보드를 닫고 레벨 선택 메뉴로 돌아갑니다. 저장된 별은 유지합니다.")]
    private static void ResetGame()
    {
        var game = GameController.Instance;
        if (game == null)
            throw new System.InvalidOperationException("게임이 초기화되지 않았습니다.");

        game.ShowMenu();
    }
}
#endif
