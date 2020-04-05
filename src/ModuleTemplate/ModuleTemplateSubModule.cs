using JetBrains.Annotations;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace ModuleTemplate {

  [PublicAPI]
  public class ModuleTemplateSubModule : MBSubModuleBase {

    protected override void OnSubModuleLoad() {
      // your code here
      base.OnSubModuleLoad();
    }

    protected override void OnSubModuleUnloaded() {
      // your code here
      base.OnSubModuleUnloaded();
    }

    protected override void OnBeforeInitialModuleScreenSetAsRoot() {
      // your code here
      base.OnBeforeInitialModuleScreenSetAsRoot();
    }

    protected override void OnGameStart(Game game, IGameStarter gameStarterObject) {
      // your code here
      base.OnGameStart(game, gameStarterObject);
    }

    protected override void OnApplicationTick(float dt) {
      // your code here
      base.OnApplicationTick(dt);
    }

    public override void OnGameLoaded(Game game, object initializerObject) {
      // your code here
      base.OnGameLoaded(game, initializerObject);
    }

    public override void OnNewGameCreated(Game game, object initializerObject) {
      // your code here
      base.OnNewGameCreated(game, initializerObject);
    }

    public override void BeginGameStart(Game game) {
      // your code here
      base.BeginGameStart(game);
    }

    public override void OnCampaignStart(Game game, object starterObject) {
      // your code here
      base.OnCampaignStart(game, starterObject);
    }

    public override void OnMultiplayerGameStart(Game game, object starterObject) {
      // your code here
      base.OnMultiplayerGameStart(game, starterObject);
    }

    public override void OnGameInitializationFinished(Game game) {
      // your code here
      base.OnGameInitializationFinished(game);
    }

    public override bool DoLoading(Game game) {
      // your code here
      return base.DoLoading(game);
    }

    public override void OnGameEnd(Game game) {
      // your code here
      base.OnGameEnd(game);
    }

    public override void OnMissionBehaviourInitialize(Mission mission) {
      // your code here
      base.OnMissionBehaviourInitialize(mission);
    }

  }

}