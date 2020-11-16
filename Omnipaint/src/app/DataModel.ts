export class DataModel {
  public ActiveLayerIndex: number;
  public Layers: Array<LayerLike>
}

export interface LayerLike {

}

export class PixelLayer implements LayerLike {

}

export class TextLayer implements LayerLike {

}


export interface CommandLike {
  Execute(commandData: any, model: DataModel);
}

export  class CommandInstance
{
  public constructor(command: CommandLike, dataModel: DataModel) {
    this.Command = command;
    this.DataModel = dataModel
  }
  public readonly Command: CommandLike;
  public readonly DataModel: DataModel;
}

export class Point {
  public X: number;
  public Y: number;
}

export class PenCommand implements CommandLike {
  Execute() {
    let paintedPoints = commandData.PointsPainted as [Array<Point>]
    model.Layers[model.ActiveLayerIndex]

  }
}

export class ChangeLayerCommand implements CommandLike {
 
  Execute() {
    let layer = commandData.TargetLayer as number;
    model.ActiveLayerIndex = layer;
  }
}

export class Grid {



}
